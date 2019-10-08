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
        public static string addRegistry(string keyName,string keyValue)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + keyName);

                //storing the values  
                key.SetValue(keyName, keyValue);
                key.Close();
                return "Regitry key created successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string updateRegistry(string keyName, string keyValue)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + keyName);

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    key.SetValue(keyName, keyValue);
                    key.Close();
                    return "Regitry key updated successfully";
                }
                else
                {
                    return "Regitry key not found";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string deleteKey(string keyName)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + keyName);

                if (key != null)
                {
                    key.DeleteValue(keyName);
                    return "Regitry key deleted successfully";
                }
                else
                {
                    return "Regitry key not found";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string runScript(string command, bool isHidden = false, bool isAdmin = false)
        {
            string result = "";
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "CMD.exe";
                start.Arguments = command;
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.CreateNoWindow = true;
                if (isAdmin)
                {
                    start.Verb = "runAs";
                }

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                        Console.Write(result);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        public static string startProcess(string path,bool isHidden=false,bool isAdmin=false)
        {
            string result = "";
            try
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
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                        Console.Write(result);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
        public static string redirectProcessOutput(string path, string output)
        {
            //process.StartInfo.FileName = @"C:\Users\ASUS\Desktop\ResearchWebStack\Hello\bin\Debug\Hello.exe";
            //process.StartInfo.Arguments = "/K dir > C:\\Users\\ASUS\\Desktop\\ResearchWebStack\\Test\\a.txt";
            //string output = process.StandardOutput.ReadToEnd();
            //File.WriteAllText(@"C:\Users\ASUS\Desktop\ResearchWebStack\Test\a.txt", output);
            try
            {
                File.WriteAllText(path, output);
                return "File Writing Successfull";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
