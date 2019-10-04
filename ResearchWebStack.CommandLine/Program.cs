using CommandLine;
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
            Parser.Default.ParseArguments<CustomOption>(args)
                   .WithParsed<CustomOption>(o =>
                   {
                       string output = "";
                       if (o.FilePath != "")
                       {
                           output = CustomProcess.startProcess(o.FilePath);
                       }
                       if(o.Script!="")
                       {
                           CustomProcess.runScript("");
                       }
                       if (o.RedirectPath != "" && output != "")
                       {
                           CustomProcess.redirectProcessOutput(o.RedirectPath, output);
                       }
                   });
        }
    }
}
