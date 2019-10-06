using Auk.CsharpBootstrapper.Extensions;
using Auk.CsharpBootstrapper.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.EnableDebugMode();
            try
            {
                throw new Exception(message: "Hello");
                //Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                ex.PathErrorLogAndThrow(path: "Path");
                ex.LogAndThrow(message: "", message2: null, isThrow: true);
            }
        }
    }
}
