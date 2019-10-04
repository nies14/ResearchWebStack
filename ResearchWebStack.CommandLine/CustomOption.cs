using CommandLine;
using ResearchWebStack.Data.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchWebStack.CommandLine
{
    [Verb("registry", HelpText = "run Registry command")]
    public class Registry
    {
        [Option('n', "name", Required = false)]
        public string FileName { get; set; }
        [Option('p', "path")]
        public string FilePath { get; set; }
        [Option('s', "script")]
        public string Script { get; set; }
        [Option('r', "redirect")]
        public string RedirectPath { get; set; }
    }

    [Verb("cmd", HelpText = "run cmd command")]
    public class cmd : CustomOption
    {
        //[Option('n',"name", Required = false)]
        //public string FileName { get; set; }
        //[Option('p', "path")]
        //public string FilePath { get; set; }
        //[Option('s', "script")]
        //public string Script { get; set; }
        //[Option('r', "redirect")]
        //public string RedirectPath { get; set; }
    }
    [Verb("runPython", HelpText = "run Python file")]
    public class RunPython : CustomOption
    {
        //[Option('n',"name", Required = false)]
        //public string FileName { get; set; }
        //[Option('p', "path")]
        //public string FilePath { get; set; }
        //[Option('s', "script")]
        //public string Script { get; set; }
        //[Option('r', "redirect")]
        //public string RedirectPath { get; set; }
    }
    [Verb("runNodeJs", HelpText = "run Node Js file")]
    public class RunNodeJs: CustomOption
    {
        //[Option('n',"name", Required = false)]
        //public string FileName { get; set; }
        //[Option('p', "path")]
        //public string FilePath { get; set; }
        //[Option('s', "script")]
        //public string Script { get; set; }
        //[Option('r', "redirect")]
        //public string RedirectPath { get; set; }
    }
    [Verb("custom", HelpText = "run custom Js file")]
    public class CustomOption
    {
        [Option('n', "name", Required = false)]
        public string FileName { get; set; }
        [Option('p', "path", Required = false)]
        public string FilePath { get; set; }
        [Option('s', "script", Required = false)]
        public string Script { get; set; }
        [Option('r', "redirect", Required = false)]
        public string RedirectPath { get; set; }
    }
    [Verb("getFailedTest", HelpText = "Get Failed Test")]
    public class GetFailedTest
    {
        public void GetResults()
        {
            TestRunRepository test = new TestRunRepository();
            Console.WriteLine(test.GetFailedUniTestResults());
        }
    }
    [Verb("getNonPassingTest", HelpText = "Get Failed Test")]
    public class GetNonPassingTest
    {
        public void GetResults()
        {
            TestRunRepository test = new TestRunRepository();
            Console.WriteLine(test.GetNonPassingPast());
        }
    }
    public class CustomProcess
    {
        public static string runScript(string command)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "CMD.exe";
            start.Arguments = command;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            using (Process process = Process.Start(start))
            {
                string result = "";
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    Console.Write(result);
                }
                return result;
            }
            
        }
        public static string startProcess(string path)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = path;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            using (Process process = Process.Start(start))
            {
                string result = "";
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    Console.Write(result);
                }
                return result;
            }
        }
        public static void redirectProcessOutput(string path,string output)
        {
            //process.StartInfo.FileName = @"C:\Users\ASUS\Desktop\ResearchWebStack\Hello\bin\Debug\Hello.exe";
            //process.StartInfo.Arguments = "/K dir > C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Test\\a.txt";
            //string output = process.StandardOutput.ReadToEnd();
            //File.WriteAllText(@"C:\Users\ASUS\Desktop\ResearchWebStack\Test\a.txt", output);
            File.WriteAllText(path, output);
        }
    }
}
