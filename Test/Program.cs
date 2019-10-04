using CommandLine;
using Microsoft.VisualBasic.CompilerServices;
using ResearchWebStack.CommandLine;
using ResearchWebStack.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Test
{
    //class Program
    //{
    //    class SomeOptions
    //    {
    //        [Option('n', "name", Required = true)]
    //        public string Name { get; set; }

    //        [Option('a', "age")]
    //        public int Age { get; set; }
    //    }
    //    static void Main(string[] args)
    //    {
    //        var options = new SomeOptions();

    //        Parser.Default.ParseArguments(args,);

    //        // options.Name will = Jason
    //        // options.Age will = 99
    //    }
    //}
    class Program
    {
        //public class Options
        //{
        //    [Option('n', "name", Required = true)]
        //    public string Name { get; set; }

        //    [Option('a', "age")]
        //    public int Age { get; set; }
        //}

        //public class NodeTestOption
        //{
        //    [Option('n', "name", Required = true)]
        //    public string ProcessName { get; set; }
        //    [Option('p', "path")]
        //    public string FilePath { get; set; }
        //    [Option('r', "redirect")]
        //    public string RedirectPath { get; set; }
        //    public string startProcess()
        //    {
        //        ProcessStartInfo start = new ProcessStartInfo();
        //        start.FileName = FilePath;
        //        start.UseShellExecute = false;
        //        start.RedirectStandardOutput = true;
        //        start.CreateNoWindow = true;

        //        using (Process process = Process.Start(start))
        //        {
        //            string result = "";
        //            using (StreamReader reader = process.StandardOutput)
        //            {
        //                result = reader.ReadToEnd();
        //                Console.Write(result);
        //            }
        //            return result;
        //        }
        //    }
        //    public void redirectProcessOutput(string output)
        //    {
        //        //process.StartInfo.FileName = @"C:\Users\ASUS\Desktop\ResearchWebStack\Hello\bin\Debug\Hello.exe";
        //        //process.StartInfo.Arguments = "/K dir > C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Test\\a.txt";
        //        //string output = process.StandardOutput.ReadToEnd();
        //        File.WriteAllText(@"C:\Users\ASUS\Desktop\ResearchWebStack\Test\a.txt", output);
        //    }
        //    public string Name
        //    {
        //        get
        //        {
        //            return "";
        //        }
        //        set
        //        {
        //            ProcessStartInfo start = new ProcessStartInfo();
        //            start.FileName = @"C:\Users\ASUS\Desktop\ResearchWebStack\Hello\bin\Debug\Hello.exe"; // Specify exe name.
        //            start.UseShellExecute = false;
        //            start.RedirectStandardOutput = true;

        //            using (Process process = Process.Start(start))
        //            {
        //                //
        //                // Read in all the text from the process with the StreamReader.
        //                //
        //                using (StreamReader reader = process.StandardOutput)
        //                {
        //                    string result = reader.ReadToEnd();
        //                    Console.Write(result);
        //                }
        //            }

        //        }
        //    }
        //}


        static void Main(string[] args)
        {
            //Parser.Default.ParseArguments<CustomOption>(args)
            //       .WithParsed<CustomOption>(o =>
            //       {
            //           string output = "";
            //           if (o.FilePath != "")
            //           {
            //               output = CustomProcess.startProcess(o.FilePath);
            //           }
            //           if (o.FileName=="cmd" && o.Script != "")
            //           {
            //               CustomProcess.runScript("");
            //           }
            //           if (o.RedirectPath != "" && output != "")
            //           {
            //               CustomProcess.redirectProcessOutput(o.RedirectPath, output);
            //           }
            //       });
            //    CommandLine.Parser.Default.ParseArguments<RunNodeJs,CustomOption,GetFailedTest, GetNonPassingTest,cmd>(args)
            //.MapResult(
            //  (RunNodeJs o) =>
            //  {
            //      string output = "";
            //      if (o.FilePath != "")
            //      {
            //          output = CustomProcess.startProcess(o.FilePath) + " node";
            //      }
            //      if (o.FileName == "cmd" && o.Script != "")
            //      {
            //          CustomProcess.runScript("");
            //      }
            //      if (o.RedirectPath != "" && output != "")
            //      {
            //          CustomProcess.redirectProcessOutput(o.RedirectPath, output);
            //      }
            //      return 1;
            //  },
            //  (CustomOption o) =>
            //  {
            //      string output = "";

            //      if (o.Script != "")
            //      {
            //          //"/K ipconfig"
            //          CustomProcess.runScript(o.Script);
            //      }
            //      else if (o.FilePath != "")
            //      {
            //          output = CustomProcess.startProcess(o.FilePath) + " customs";
            //      }
            //      if (o.RedirectPath != "" && output != "")
            //      {
            //          CustomProcess.redirectProcessOutput(o.RedirectPath, output);
            //      }
            //      return 1;
            //  }, (GetFailedTest o) =>
            //  {
            //      o.GetResults();
            //      return 1;
            //  },
            //  (GetNonPassingTest o) =>
            //  {
            //      o.GetResults();
            //      return 1;
            //  },
            //  (cmd o) =>
            //  {
            //      string output = "";
            //      //if (o.FilePath != null && o.FilePath != "")
            //      //{
            //      //    output = CustomProcess.startProcess(o.FilePath) + " customs";
            //      //}
            //      if ((o.FileName == "cmd" || o.FileName == "ps") && o.Script != "")
            //      {
            //          //"/K ipconfig"
            //          output = CustomProcess.runScript(o.Script);
            //      }
            //      else if (o.FilePath != null && o.FilePath != "")
            //      {
            //          output = CustomProcess.startProcess(o.FilePath);
            //      }
            //      if (o.RedirectPath != "" && output != "")
            //      {
            //          CustomProcess.redirectProcessOutput(o.RedirectPath, output);
            //      }
            //      return 1;
            //  },


            //  errs => 1);

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Wow6432Node\\Names");
            key.SetValue("Name", "Isabella");
            key.Close();
        }

    }
}
