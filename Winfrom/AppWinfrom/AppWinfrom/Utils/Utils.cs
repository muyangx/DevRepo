using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace AppWinfrom.Utils
{

    public class Utils
    {
 /*       public string GetMotherboardSerialNumber()
        {
            string serialNumber = "";
            RegistryKey key = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS");
            if (key != null)
            {
                object value = key.GetValue("SystemSerialNumber");
                if (value != null)
                {
                    serialNumber = value.ToString();
                }
            }
            return serialNumber;
        }*/

        public static bool IsPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^(?:(?:\+|00)86)?1(?:(?:3[\d])|(?:4[5-79])|(?:5[0-35-9])|(?:6[5-7])|(?:7[0-8])|(?:8[\d])|(?:9[189]))\d{8}$");
            return regex.IsMatch(phoneNumber);
        }

        public static string GetMotherboardSerialNumber() {
                string BiosSerialNumber = "";
                try
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_BIOS");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                    BiosSerialNumber = mo.GetPropertyValue("SerialNumber").ToString().Trim();

                        break;
                    }
                }
                catch
                {

                }
                return BiosSerialNumber;
            }
    }
        
    }
        
