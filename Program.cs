//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Serilog;

//namespace WorkerService1
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Log.Logger = new LoggerConfiguration()
//                .MinimumLevel.Debug()
//                .MinimumLevel.Override("MicroSoft", Serilog.Events.LogEventLevel.Warning)
//                .Enrich.FromLogContext()
//                .WriteTo.File(@"C:\temp\WorkerService1\LogFile.txt")
//                .CreateLogger();
//            try
//            {
//                Log.Information("Worker Service is started");
//                CreateHostBuilder(args).Build().Run();
//                return;
//            }
//            catch (Exception ex)
//            {
//                Log.Fatal(ex, "Worker Service is started");
//                return;
//            }
//            finally
//            {
//                Log.CloseAndFlush();
//            }
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args)
//        {

//            return Host.CreateDefaultBuilder(args)
//                 .UseWindowsService()
//                 .ConfigureServices((hostContext, services) =>
//                 {
//                     services.AddHostedService<EmailSender>();
//                 })
//                 .UseSerilog();
//        }
//    }
//}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmailWorkerService
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}
