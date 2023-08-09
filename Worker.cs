using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MimeKit;
using MailKit.Net.Smtp;
using OfficeOpenXml;
using WorkerService1.Models;
using WorkerService1.NewFolder;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Tls;
using System.Net.Mail;
using SendGrid;
using SendGrid.Helpers.Mail;
using Org.BouncyCastle.Asn1.Pkcs;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace EmailWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger; 
        private readonly IConfiguration _config;
        private readonly IHostApplicationLifetime _appLifetime;

        public Worker(ILogger<Worker> logger, IConfiguration config, IHostApplicationLifetime appLifetime)
        {
            _logger = logger; 
            _config = config;
            _appLifetime = appLifetime;
        }

        ResponseClass _responceResult = new();
        private CancellationToken stoppingToken;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    DateTime currentTime = DateTime.Now;
                    TimeSpan desiredTime = new TimeSpan(01, 04, 00); // Desired time is 9:00 AM

                    //if (currentTime.TimeOfDay == desiredTime)
                    if (currentTime.TimeOfDay.Hours == desiredTime.Hours && currentTime.TimeOfDay.Minutes == desiredTime.Minutes)
                    {
                        _logger.LogInformation("Started" + DateTime.Now);
                        // Perform your work here
                        var currentDate = DateTime.Now.Date;
                        //var dayOfWeek = (int)currentDate.DayOfWeek;
                        var dayOfWeek = currentDate.ToString("dddd");
                        var currentMonth = currentDate.Month;
                        var nextMonth = currentMonth == 12 ? 1 : currentMonth + 1;
                        var currentYear = currentDate.Year;
                        var date = currentDate.Day;

                        WMSContext db = new();

                        var clientlist = db.Whclients.Where(a => a.Inventoryreport == true).ToList();
                        //Parallel.ForEach(clientlist, item =>
                        //{
                        foreach (var item in clientlist)
                        {
                            string invp = item.Inventoryperiod;
                            //sendAsync(item.Uniqueid);

                            switch (item.Inventoryperiod)
                            {

                                case "Weekly":
                                    // Send email every Monday
                                    if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
                                    {
                                        sendAsync(item.Uniqueid, new CancellationToken());

                                    }
                                    break;
                                case "Monthly":
                                    // Send email on 1st of next month
                                    if (DateTime.Today.Day == 1)
                                    {
                                        sendAsync(item.Uniqueid, new CancellationToken());
                                    }
                                    break;
                                case "Quarterly":
                                    // Send email every 3 months on the 1st day of the month

                                    if ((date == 1 && currentMonth % 3 == 1))
                                    {
                                        sendAsync(item.Uniqueid, new CancellationToken());
                                    }
                                    break;
                                case "Yearly":
                                    // Send email on January 1st of next year
                                    if (DateTime.Today.AddDays(1).Day == 1 && DateTime.Today.Month == 1)
                                    {
                                        sendAsync(item.Uniqueid, new CancellationToken());
                                    }
                                    break;
                                case "DayoftheMonth":
                                    // Send email on January 1st of next year
                                    // Example input: Desired day is 20
                                    int desiredDay = item.Dayofmonth;



                                    // Get the desired date based on the input day
                                    DateTime desiredDate = new DateTime(currentDate.Year, currentDate.Month, desiredDay);

                                    if (currentDate == desiredDate)
                                    {
                                        // Perform your work here
                                        sendAsync(item.Uniqueid, new CancellationToken());
                                    }
                                    break;
                            }
                        }

                        //});
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Failed" + DateTime.Now);
                }
                //_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(60000, stoppingToken);
            }
        }


        private static int GetNewOrderQty(int skuid, int clientid)
        {
            WMSContext db = new();
            var ordercount = (from or in db.Orders
                              join ori in db.Orderitems on or.Orderid equals ori.Orderid
                              where or.Clientid == clientid
                              && ori.Skuid == skuid
                              && or.Orderstatus.ToUpper() == "NEW"
                              select new
                              {
                                  ori.Orderqty
                              }).Sum(a => a.Orderqty);
            return ordercount;
        }
        private static int GetBKOOrderQty(int skuid, int clientid)
        {
            WMSContext db = new();
            var ordercount = (from or in db.Orders
                              join ori in db.Orderitems on or.Orderid equals ori.Orderid
                              where or.Clientid == clientid
                              && ori.Skuid == skuid
                              && or.Orderstatus.ToUpper() == "BKO"
                              select new
                              {
                                  ori.Orderqty
                              }).Sum(a => a.Orderqty);
            return ordercount;
        }

        private async Task sendAsync(int clientid, CancellationToken ct = default)
        {


            var displayName = _config["EMailSettings:DisplayName"];

            var fromEmail = _config["EMailSettings:From"];
            var apiKey = _config["EMailSettings:ApiKey"];
            WMSContext db = new();
            var clientname =  db.Whclients.Where(y => y.Uniqueid == clientid).Select( x => x.Clientname).FirstOrDefault();
            var result2 = (from sk in db.Skus
                           join cl in db.Whclients on sk.Clientid equals cl.Uniqueid
                           join sil in db.Skuinventorylocations on sk.Skuid equals sil.Skuid into slobj
                           from sil in slobj.DefaultIfEmpty()
                           join c in db.Whlocations on sil.Locationid equals c.Uniqueid
                           where (sk.Clientid == clientid

                                        && sk.Status == "Active")
                           group new { sil, sk, cl, c } by new { sk.Skuid, sk.Sku1, sk.Description, sk.Itemtype, cl.Clientname, cl.Uniqueid, cl.Csmemail } into g
                           select new
                           {
                               skuid = g.Key.Skuid,
                               sku1 = g.Key.Sku1,
                               description = g.Key.Description,
                               currentQty = (g.Sum(a => a.sil.Availableqty) - g.Sum(a => a.sil.Allocatedqty)),
                               Allocatedqty = g.Sum(a => a.sil.Allocatedqty),
                               Availableqty = g.Sum(a => a.sil.Availableqty),
                               newqty = GetNewOrderQty(g.Key.Skuid, g.Key.Uniqueid),
                               bkoqty = GetBKOOrderQty(g.Key.Skuid, g.Key.Uniqueid),
                               Itemtype = g.Key.Itemtype,
                               clientname = g.Key.Clientname,
                               csemail = g.Key.Csmemail
                           }).OrderBy(a => a.sku1).ToList();
            var result = (from sil in db.Skuinventorylocationlogs
                          join sk in db.Skus on sil.Skuid equals sk.Skuid
                          join cl in db.Whclients on sk.Clientid equals cl.Uniqueid
                          join c in db.Whlocations on sil.Locationid equals c.Uniqueid
                          where (cl.Inventoryreport == true)
                                   && (cl.Inventoryperiod == "Weekly" || cl.Inventoryperiod == "Monthly" || cl.Inventoryperiod == "Quarterly" || cl.Inventoryperiod == "Yearly")
                          select new
                          {
                              sk.Sku1,
                              sk.Description,
                              Qty = sil.Transqty,
                              date = sil.Entryddate.ToString("MM/dd/yyyy"),
                              c.Location,
                              sil.Transtype,
                              cl.Clientname
                          }).ToList();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Sku Inventory Location Logs");

            // Add header row
            worksheet.Cells[1, 1].Value = "SKU";
            worksheet.Cells[1, 2].Value = "Description";
            worksheet.Cells[1, 3].Value = "OnHand Qty";
            worksheet.Cells[1, 4].Value = "SKU Type";
            worksheet.Cells[1, 5].Value = "BKO Qty";
            //worksheet.Cells[1, 6].Value = "newqty";
            //worksheet.Cells[1, 7].Value = "Client Name";
            worksheet.Cells[1, 6].Value = "Allocated Qty";
            worksheet.Cells[1, 7].Value = "Available Qty";
            //worksheet.Cells[1, 10].Value = "newqty";


            // Add data rows
            int row = 2;
            
            foreach (var item in result2)
            {
                worksheet.Cells[row, 1].Value = item.sku1;
                worksheet.Cells[row, 2].Value = item.description;
                worksheet.Cells[row, 3].Value = item.currentQty;
                worksheet.Cells[row, 4].Value = item.Itemtype;
                worksheet.Cells[row, 5].Value = item.bkoqty;
                //worksheet.Cells[row, 6].Value = item.newqty;
               
                worksheet.Cells[row, 6].Value = item.Allocatedqty;
                worksheet.Cells[row, 7].Value = item.Availableqty;
                //worksheet.Cells[row, 10].Value = item.newqty;
                row++;
            }

            // Save the file
            package.Save();
            bool istrorf = false;
            using (var stream = new MemoryStream())
            {
                package.SaveAs(stream); // Save the Excel package to the stream

                // Reset the stream position to the beginning
                stream.Position = 0;
                string subject = "";
                // Create email message
                 // Replace this with your DateTime object
                
                subject = clientname +  " - Inventory Notifications";
                
                var message = new SendGridMessage();

                message.SetFrom(new EmailAddress(fromEmail, displayName));


                var toEmails = db.Whclients
                                        .Where(a => a.Uniqueid == clientid)
                                        .Select(a => a.Csmemail).FirstOrDefault();
                if (toEmails != null)
                {
                    List<string> ToEmail = toEmails.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    foreach (string mailAddress in ToEmail.Where(x => !string.IsNullOrWhiteSpace(x)))
                        message.AddTo(new EmailAddress(mailAddress));
                }
                string content = "Attached is the Inventory report as of ["+ DateTime.Now.ToShortDateString() + "].\r\n\r\nThank You,\r\nGLC Team";
                message.SetSubject(subject);
                message.AddContent(MimeType.Text, content);

                // Attach the Excel file
                message.AddAttachment($"InventoryList_{DateTime.Now:yyyyMMddHHmmss}.xlsx", Convert.ToBase64String(stream.ToArray()));


                var client = new SendGridClient(apiKey);
                var temp = await client.SendEmailAsync(message, ct);
            }

            _logger.LogInformation("Email sent successfully." + DateTime.Now);
        }

        public class InventoryReportModel1
        {
            public int clientid { get; set; }
            public int skuid { get; set; }
            public int locationid { get; set; }
            public string lotcode { get; set; }
            public string description { get; set; }
            public string type { get; set; }

        }
        public class InventoryConsolidatedModel
        {
            public int skuid { get; set; }
            public string sku1 { get; set; }
            public string description { get; set; }
            public int currentqty { get; set; }
            public int allocatedqty { get; set; }
            public int availableqty { get; set; }
            public int newqty { get; set; }
            public int bkoqty { get; set; }
            public string itemtype { get; set; }
            public string clientname { get; set; }
        }
    }
}
