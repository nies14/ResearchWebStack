using Auk.CsharpBootstrapper.Extensions;
using Auk.CsharpBootstrapper.Helper;
using ResearchWebStock.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //remove the below reason if u want to invoke the service contractor from here
            //#region Service Contractor
            using (System.ServiceModel.ServiceHost host = new
               System.ServiceModel.ServiceHost(typeof(TestService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
            //#endregion


            //Console.WriteLine("Hello World!");
            //LogHelper.EnableDebugMode();
            //try
            //{
            //    throw new Exception(message: "Hello");
            //    //Console.WriteLine("Hello World!");
            //}
            //catch (Exception ex)
            //{
            //    LogHelper.
            //    ex.PathErrorLogAndThrow(path: "Path");
            //    ex.LogAndThrow(message: "", message2: null, isThrow: true);
            //}

            //var secs = 3;
            //log.Fatal("Start log FATAL...");
            //Console.WriteLine("Start log FATAL...");
            //Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            //log.Error("Start log ERROR...");
            //Console.WriteLine("Start log ERROR...");
            //Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            //log.Warn("Start log WARN...");
            //Console.WriteLine("Start log WARN...");
            //Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            //log.Info("Start log INFO...");
            //Console.WriteLine("Start log INFO...");
            //Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            //log.Debug("Start log DEBUG...");
            //Console.WriteLine("Start log DEBUG...");
            //Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            //Console.WriteLine("Press any key to close the application");
            //Console.ReadKey();
        }

    }

}
