using CommandLine;
using ResearchWebStack.Data.Repository;
using System;

namespace ResearchWebStack.Base
{
    [Verb("registry", HelpText = "run Registry command")]
    public class Registry
    {
        [Option('a', "add")]
        public string Add { get; set; }
        [Option('u', "addOrUpdate", Required = false)]
        public string AddOrUpdate { get; set; }
        [Option('d', "delete")]
        public string Delete { get; set; }
        [Option('s', "set")]
        public string Set { get; set; }
        [Option('v', "value")]
        public string Value { get; set; }
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
}
