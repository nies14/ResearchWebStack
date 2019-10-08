using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ResearchWebStack.Data.IRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ResearchWebStack.Data.Repository
{
    public class TestRunRepository : ITestRunRepository
    {
        ContentRepository content = null;
        TestRun test = null;
        public TestRunRepository()
        {
            content = new ContentRepository();
            //test = content.deserializeXml(@"C:\Users\ASUS\Documents\ResearchWebStack\ResearchWebStack.Content\UnitTests.xml");
            string path = AppDomain.CurrentDomain.BaseDirectory.Replace('\\', '/');
            path = path.TrimEnd('/');
            path = path.Substring(0, path.LastIndexOf('/'));
            test = content.deserializeXml(path+"/ResearchWebStack.Content/UnitTests.xml");
        }

        public string UnitTestResults()
        {
            JObject jobject = JObject.FromObject(new
            {
                Test = test.Results
            }, new JsonSerializer()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
            });
            return jobject.ToString();
        }
        public string GetFailedUniTestResults()
        {
            JObject jobject = JObject.FromObject(new
            {
                Test = test.Results.Where(x => x.outcome == "NotExecuted").ToList()
            }, new JsonSerializer()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
            });
            return jobject.ToString();
        }
        public string GetNonPassingPast()
        {
            JObject jobject = JObject.FromObject(new
            {
                Test = test.Results.Where(x => x.outcome != "Passed").ToList()
            }, new JsonSerializer()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
            });
            return jobject.ToString();
        }
        public string GetInfo(string testName, string filterType)
        {
            if (filterType == "Contains")
            {
                JObject jobject = JObject.FromObject(new
                {
                    Test = test.Results.Where(x => x.testName.Contains(testName)).ToList()
                }, new JsonSerializer()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
                });
                return jobject.ToString();
            }
            else if (filterType == "StartsWith")
            {
                JObject jobject = JObject.FromObject(new
                {
                    Test = test.Results.Where(x => x.testName.StartsWith(testName)).ToList()
                }, new JsonSerializer()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
                });
                return jobject.ToString();
            }
            else if (filterType == "EndsWith")
            {
                JObject jobject = JObject.FromObject(new
                {
                    Test = test.Results.Where(x => x.testName.StartsWith(testName)).ToList()
                }, new JsonSerializer()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
                });
                return jobject.ToString();
            }
            else
            {
                JObject jobject = JObject.FromObject(new
                {
                    Test = test.Results.Where(x => x.testName == testName).ToList()
                }, new JsonSerializer()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
                });
                return jobject.ToString();
            }
        }
    }
}
