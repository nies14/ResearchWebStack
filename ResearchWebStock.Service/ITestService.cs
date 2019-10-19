using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ResearchWebStock.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestService" in both code and config file together.
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        [WebGet]
        string UnitTestResults();

        [OperationContract(Name = "GetFailedTests")]
        [WebGet]
        [WebInvoke]
        string GetFailedUniTestResults();

        [OperationContract(Name = "GetNonPassingTest")]
        [WebGet]
        string GetNonPassingTest();

        [OperationContract(Name = "GetInfo")]
        [WebGet]
        string GetInfo(string testName, string filterType);

        [OperationContract(Name = "CreateCommandLineProcess")]
        [WebGet]
        void CreateCommandLineProcess(string processName, string processPath, string arguments, bool isRunAsync, bool isHidden, bool isAdmin);
        [OperationContract(Name = "CreateFiveCommandLine")]
        [WebGet]
        void CreateFiveCommandLine();
        [OperationContract]
        [WebGet]
        void CreateFiveCommandLineAsyns(string testName, string filterType);
    }
}
