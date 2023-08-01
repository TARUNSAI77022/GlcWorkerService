using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService1.Models;
using WorkerService1.NewFolder;

namespace WorkerService1.Controllers
{
    public class MailController : Controller
    {
        ResponseClass _responceResult = new();
        public ResponseClass GetInventoryHistoryList(ILogger _logger)
        {
            try
            {
                using (WMSContext db = new WMSContext())
                {
                    var result = (from sil in db.Skuinventorylocationlogs
                                  join sk in db.Skus on sil.Skuid equals sk.Skuid
                                  join cl in db.Whclients on sk.Clientid equals cl.Uniqueid
                                  join c in db.Whlocations on sil.Locationid equals c.Uniqueid
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
                    _responceResult.Data = result;
                    _responceResult.responsecode = 200;
                    _responceResult.responsemessage = "Success!";
                    _logger.LogInformation("Get Inventory History List");
                }
            }
            catch (Exception e)
            {
                _responceResult.responsecode = 500;
                _responceResult.responsemessage = "Error: Server Error, Try Again!";
                _logger.LogError("Get Inventory History List - " + e.ToString());
            }
            return _responceResult;
        }
    }
}
