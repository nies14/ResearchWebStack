using Auk.CsharpBootstrapper.Extensions;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchWebStack.BusinessLayer
{
    public class CustomProcess
    {
        public static void addRegistry(string keyName,string keyValue)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\"+keyName);

            //storing the values  
            key.SetValue(keyName,keyValue);
            key.Close();
        }
        public static void updateRegistry(string keyName, string keyValue)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\"+keyName);

            //if it does exist, retrieve the stored values  
            if (key != null)
            {
                key.SetValue(keyName,keyValue);
                key.Close();
            }
        }
        public static void deleteKey(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + keyName);
 
            if (key != null)
            {
                key.DeleteValue(keyName);
            }
        }
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
        public static string startProcess(string path,bool isHidden=false,bool isAdmin=false)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = path;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = isHidden;
            if (isAdmin)
            {
                start.Verb = "runAs";
            }

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
        public static void redirectProcessOutput(string path, string output)
        {
            //process.StartInfo.FileName = @"C:\Users\ASUS\Desktop\ResearchWebStack\Hello\bin\Debug\Hello.exe";
            //process.StartInfo.Arguments = "/K dir > C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Test\\a.txt";
            //string output = process.StandardOutput.ReadToEnd();
            //File.WriteAllText(@"C:\Users\ASUS\Desktop\ResearchWebStack\Test\a.txt", output);
            try
            {
                File.WriteAllText(path, output);
            }
            catch(Exception ex)
            {
                ex.PathErrorLogAndThrow(path: "Path");
            }
        }
    }
}
