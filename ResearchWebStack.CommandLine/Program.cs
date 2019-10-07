using Auk.CsharpBootstrapper.Helper;
using CommandLine;
using ResearchWebStack.Base;
using ResearchWebStack.BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ResearchWebStack.CommandLine
{
    class Program
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void runCommandLineParser(string[] args)
        {
            //ResearchWebStack.CommandLine.exe runNodeJs -n test -p C:\Users\BS-183\Desktop\ResearchWebStack\Hello\bin\Debug\Hello.exe
            string output = "";
            Parser.Default.ParseArguments<RunNodeJs, RunPython, GetFailedTest, GetNonPassingTest, Cmd,Ps, Registry>(args)
        .MapResult(
          (RunNodeJs o) =>
          {
              if (o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath) + " for verb runNodeJs";
                  log.Info(output);
                  //LogHelper.QInfo(output);
              }
              if (o.FileName == "cmd" && o.Script != "")
              {
                  output = CustomProcess.runScript("");
                  log.Info(output);
              }
              if (o.RedirectPath != "" && output != "")
              {
                  output = CustomProcess.redirectProcessOutput(o.RedirectPath, output);
                  log.Info(output);
              }
              return 1;
          },
          (RunPython o) =>
          {

              if (o.Script != "")
              {
                  //"/K ipconfig"
                  output = CustomProcess.runScript(o.Script);
                  log.Info(output);
              }
              else if (o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath) + " for verb runPythonJs";
                  log.Info(output);
                  //LogHelper.QInfo(output);
              }
              if (o.RedirectPath != "" && output != "")
              {
                  output = CustomProcess.redirectProcessOutput(o.RedirectPath, output);
                  log.Info(output);
              }
              return 1;
          }, (GetFailedTest o) =>
          {
              output = o.GetResults();
              log.Info(output);
              return 1;
          },
          (GetNonPassingTest o) =>
          {
              output = o.GetResults();
              log.Info(output);
              return 1;
          },
          (Cmd o) =>
          {
              //if (o.FilePath != null && o.FilePath != "")
              //{
              //    output = CustomProcess.startProcess(o.FilePath) + " customs";
              //}
              if ((o.FileName == "cmd" || o.FileName == "ps") && o.Script != "")
              {
                  //"/K ipconfig"
                  output = CustomProcess.runScript(o.Script) + " for verb cmd";
                  log.Info(output);
              }
              else if (o.FilePath != null && o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath);
                  log.Info(output);
              }
              if (o.RedirectPath != "" && output != "")
              {
                  output = CustomProcess.redirectProcessOutput(o.RedirectPath, output);
                  log.Info(output);
              }
              return 1;
          },
          (Ps o) =>
          {
              //if (o.FilePath != null && o.FilePath != "")
              //{
              //    output = CustomProcess.startProcess(o.FilePath) + " customs";
              //}
              if ((o.FileName == "cmd" || o.FileName == "ps") && o.Script != "")
              {
                  //"/K ipconfig"
                  output = CustomProcess.runScript(o.Script);
                  log.Info(output);
              }
              else if (o.FilePath != null && o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath);
                  log.Info(output);
              }
              if (o.RedirectPath != "" && output != "")
              {
                  output  = CustomProcess.redirectProcessOutput(o.RedirectPath, output);
                  log.Info(output);
              }
              return 1;
          },
          (Registry o) =>
          {
              if ((o.Add != null && o.Add != "") || (o.Set != null && o.Set != ""))
              {
                  output = CustomProcess.addRegistry(o.Add, o.Value);
                  log.Info(output);
              }
              else if (o.AddOrUpdate != null && o.AddOrUpdate != "")
              {
                  output = CustomProcess.updateRegistry(o.Add, o.Value);
                  log.Info(output);
              }
              else if (o.Delete != null && o.Delete != "")
              {
                  output = CustomProcess.updateRegistry(o.Add, o.Value);
                  log.Info(output);
              }
              return 1;
          },
          errs => 1);
        }
        static void Main(string[] args)
        {
            runCommandLineParser(args);            
        }
    }
}
 