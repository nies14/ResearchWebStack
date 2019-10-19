using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchWebStack.Data.IRepository
{
    public interface ITestRunRepository
    {
        string UnitTestResults();
        string GetFailedUniTestResults();
        string GetNonPassingTest();
        string GetInfo(string testName, string filterType);
    }
}
