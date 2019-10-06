using CommandLine;
using ResearchWebStack.Base;
using ResearchWebStack.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchWebStack.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<RunNodeJs, CustomOption, GetFailedTest, GetNonPassingTest, cmd,Registry>(args)
        .MapResult(
          (RunNodeJs o) =>
          {
              string output = "";
              if (o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath) + " node";
              }
              if (o.FileName == "cmd" && o.Script != "")
              {
                  CustomProcess.runScript("");
              }
              if (o.RedirectPath != "" && output != "")
              {
                  CustomProcess.redirectProcessOutput(o.RedirectPath, output);
              }
              return 1;
          },
          (CustomOption o) =>
          {
              string output = "";

              if (o.Script != "")
              {
                  //"/K ipconfig"
                  CustomProcess.runScript(o.Script);
              }
              else if (o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath) + " customs";
              }
              if (o.RedirectPath != "" && output != "")
              {
                  CustomProcess.redirectProcessOutput(o.RedirectPath, output);
              }
              return 1;
          }, (GetFailedTest o) =>
          {
              o.GetResults();
              return 1;
          },
          (GetNonPassingTest o) =>
          {
              o.GetResults();
              return 1;
          },
          (cmd o) =>
          {
              string output = "";
              //if (o.FilePath != null && o.FilePath != "")
              //{
              //    output = CustomProcess.startProcess(o.FilePath) + " customs";
              //}
              if ((o.FileName == "cmd" || o.FileName == "ps") && o.Script != "")
              {
                  //"/K ipconfig"
                  output = CustomProcess.runScript(o.Script);
              }
              else if (o.FilePath != null && o.FilePath != "")
              {
                  output = CustomProcess.startProcess(o.FilePath);
              }
              if (o.RedirectPath != "" && output != "")
              {
                  CustomProcess.redirectProcessOutput(o.RedirectPath, output);
              }
              return 1;
          },
          (Registry o) =>
          {
              if((o.Add!=null && o.Add!="")||(o.Set!=null && o.Set!=""))
              {
                  CustomProcess.addRegistry(o.Add, o.Value);
              }
              else if(o.AddOrUpdate!=null && o.AddOrUpdate!="")
              {
                  CustomProcess.updateRegistry(o.Add, o.Value);
              }
              else if (o.Delete != null && o.Delete != "")
              {
                  CustomProcess.updateRegistry(o.Add, o.Value);
              }
              return 1;
            },
          errs => 1);
        }
    }
}
