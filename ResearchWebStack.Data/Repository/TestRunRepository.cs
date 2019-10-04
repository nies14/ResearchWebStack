using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ResearchWebStack.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ResearchWebStack.Data.Repository
{
    public class TestRunRepository: ITestRunRepository
    {
        public string UnitTestResults()
        {
            ContentRepository content = new ContentRepository();
            TestRun test = content.DeserializeXml(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.Content\UnitTests.xml");

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
            ContentRepository content = new ContentRepository();
            TestRun test = content.DeserializeXml(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.Content\UnitTests.xml");

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
            ContentRepository content = new ContentRepository();
            TestRun test = content.DeserializeXml(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.Content\UnitTests.xml");

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
            ContentRepository content = new ContentRepository();
            TestRun test = content.DeserializeXml(@"C:\Users\ASUS\Desktop\ResearchWebStack\ResearchWebStack.Content\UnitTests.xml");
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
