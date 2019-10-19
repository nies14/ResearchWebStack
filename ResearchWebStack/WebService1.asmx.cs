using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ResearchWebStack.BusinessLayer;
using ResearchWebStack.CommandLine;
using ResearchWebStack.Data;
using ResearchWebStack.Data.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;
using Test;

namespace ResearchWebStack
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        TestRunRepository content = new TestRunRepository();
        [WebMethod]
        public string HelloWorld(string test)
        {
            return "Hello World " + test;
        }
        [WebMethod]
        public string UnitTestResults()
        {
            return content.UnitTestResults();
        }
        [WebMethod(MessageName = "UnitTestResults/GetFailedTest")]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string GetFailedUniTestResults()
        {
            return content.GetFailedUniTestResults();
        }
        [WebMethod(MessageName = "UnitTestResults/GetNonPassingPast")]
        public string GetNonPassingTest()
        {
            return content.GetNonPassingTest();
        }
        [WebMethod(MessageName = "UnitTestResults/GetInfo")]
        public string GetInfo(string testName, string filterType)
        {            
            return content.GetInfo(testName, filterType);
        }
        [WebMethod]
        public void CreateCommandLineProcess(string processName, string processPath,string arguments,bool isRunAsync,bool isHidden,bool isAdmin)
        {
            try
            {
                Program.runCommandLineParser(new[] { arguments });
            }
            catch (Exception ex)
            {
                //result = ex.Message;
            }
            //ProcessStartInfo startInfo = new ProcessStartInfo(string.Concat(exePath, "abc.exe"));
            //startInfo.Arguments = "-e dev -l line1 -q 1";
        }
        [WebMethod]
        public void CreateFiveCommandLine()
        {
            CreateCommandLineProcess("test 1", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 2", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 3", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 4", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 5", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            //Task taskDivisionInfo = Task.Run(() => CustomProcess.startProcess(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", "runNodejs -n ghg -p C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Hello\\bin\\Debug\\Hello.exe"));
        }
        [WebMethod]
        public void CreateFiveCommandLineAsyns(string testName, string filterType)
        {
            Task test1 = Task.Run(() => this.CreateCommandLineProcess("test 1", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe",false,true,false));
            Task test2 = Task.Run(() => this.CreateCommandLineProcess("test 2", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test3 = Task.Run(() => this.CreateCommandLineProcess("test 3", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test4 = Task.Run(() => this.CreateCommandLineProcess("test 4", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test5 = Task.Run(() => this.CreateCommandLineProcess("test 5", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            //Task taskDivisionInfo = Task.Run(() => CustomProcess.startProcess(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", "runNodejs -n ghg -p C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Hello\\bin\\Debug\\Hello.exe"));
        }
    }
}
