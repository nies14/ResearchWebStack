using Auk.CsharpBootstrapper.Extensions;
using Auk.CsharpBootstrapper.Helper;
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

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    //[ServiceContract]
    //public interface IService
    //{
    //    [OperationContract]
    //    [WebGet]
    //    string EchoWithGet(string s);

    //    [OperationContract]
    //    [WebInvoke]
    //    string EchoWithPost(string s);
    //}

    //public class Service : IService
    //{
    //    public string EchoWithGet(string s)
    //    {
    //        return "You said " + s;
    //    }

    //    public string EchoWithPost(string s)
    //    {
    //        return "You said " + s;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ServiceHost host = new ServiceHost(typeof(Service), new Uri("http://localhost:14202"));
    //        host.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(), "Soap");
    //        ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "Web");
    //        endpoint.Behaviors.Add(new WebHttpBehavior());

    //        try
    //        {
    //            host.Open();

    //            using (WebChannelFactory<IService> wcf = new WebChannelFactory<IService>(new Uri("http://localhost:14202/Web")))
    //            {
    //                IService channel = wcf.CreateChannel();

    //                string s;

    //                Console.WriteLine("Calling EchoWithGet by HTTP GET: ");
    //                s = channel.EchoWithGet("Hello, world");
    //                Console.WriteLine("   Output: {0}", s);

    //                Console.WriteLine("");
    //                Console.WriteLine("This can also be accomplished by navigating to");
    //                Console.WriteLine("http://localhost:14202/Web/EchoWithGet?s=Hello, world!");
    //                Console.WriteLine("in a web browser while this sample is running.");

    //                Console.WriteLine("");

    //                Console.WriteLine("Calling EchoWithPost by HTTP POST: ");
    //                s = channel.EchoWithPost("Hello, world");
    //                Console.WriteLine("   Output: {0}", s);
    //                Console.WriteLine("");
    //            }
    //            using (ChannelFactory<IService> scf = new ChannelFactory<IService>(new BasicHttpBinding(), "http://localhost:14202/Soap"))
    //            {
    //                IService channel = scf.CreateChannel();

    //                string s;

    //                Console.WriteLine("Calling EchoWithGet on SOAP endpoint: ");
    //                s = channel.EchoWithGet("Hello, world");
    //                Console.WriteLine("   Output: {0}", s);

    //                Console.WriteLine("");

    //                Console.WriteLine("Calling EchoWithPost on SOAP endpoint: ");
    //                s = channel.EchoWithPost("Hello, world");
    //                Console.WriteLine("   Output: {0}", s);
    //                Console.WriteLine("");
    //            }


    //            Console.WriteLine("Press [Enter] to terminate");
    //            Console.ReadLine();
    //            host.Close();
    //        }
    //        catch (CommunicationException cex)
    //        {
    //            Console.WriteLine("An exception occurred: {0}", cex.Message);
    //            host.Abort();
    //        }
    //    }
    //}

}
