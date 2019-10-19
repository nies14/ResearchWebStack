using ResearchWebStack.CommandLine;
using ResearchWebStack.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ResearchWebStock.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in both code and config file together.
    public class TestService : ITestService
    {
        private static TestRunRepository content = new TestRunRepository();
        public string UnitTestResults()
        {
            return content.UnitTestResults();
        }
        public string GetFailedUniTestResults()
        {
            return content.GetFailedUniTestResults();
        }
        public string GetNonPassingTest()
        {
            return content.GetNonPassingTest();
        }
        public string GetInfo(string testName, string filterType)
        {
            return content.GetInfo(testName, filterType);
        }
        public void CreateCommandLineProcess(string processName, string processPath, string arguments, bool isRunAsync, bool isHidden, bool isAdmin)
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
        public void CreateFiveCommandLine()
        {
            CreateCommandLineProcess("test 1", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 2", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 3", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 4", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            CreateCommandLineProcess("test 5", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false);
            //Task taskDivisionInfo = Task.Run(() => CustomProcess.startProcess(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", "runNodejs -n ghg -p C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Hello\\bin\\Debug\\Hello.exe"));
        }
        public void CreateFiveCommandLineAsyns(string testName, string filterType)
        {
            Task test1 = Task.Run(() => this.CreateCommandLineProcess("test 1", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test2 = Task.Run(() => this.CreateCommandLineProcess("test 2", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test3 = Task.Run(() => this.CreateCommandLineProcess("test 3", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test4 = Task.Run(() => this.CreateCommandLineProcess("test 4", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            Task test5 = Task.Run(() => this.CreateCommandLineProcess("test 5", @"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", @"runNodejs - n ghg - p C:\Users\ASUS\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe", false, true, false));
            //Task taskDivisionInfo = Task.Run(() => CustomProcess.startProcess(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.CommandLine\bin\Debug\ResearchWebStack.CommandLine.exe", "runNodejs -n ghg -p C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Hello\\bin\\Debug\\Hello.exe"));
        }
    }
}
