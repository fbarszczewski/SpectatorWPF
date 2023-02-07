using System.Collections.Generic;
using System.Management;
using System.Net.Http.Headers;
using System.Windows.Documents;

namespace SpectatorWPF.Model
{
    public static class Wmi
    {




        public static string GetValue(string fromNamespace, string fromClass, string  property )
        {
            var propertyValue = "";
            try
            {
                foreach (var queryObj in new ManagementObjectSearcher(fromNamespace, $"SELECT {property} FROM {fromClass}").Get())
                    propertyValue = queryObj[property].ToString();

            }
            catch (ManagementException e)
            {
                propertyValue = e.Message;
            }

            return propertyValue;
        }
        public static List<string> GetValues(string fromNamespace, string fromClass, string[] properties)
        {
            List<string> returnValues = new List<string>();



            try
            {
                foreach (var queryObj in new ManagementObjectSearcher(fromNamespace, $"SELECT {string.Join(", ", properties)} FROM {fromClass}").Get())
                {
                    foreach (var property in properties)
                            returnValues.Add(queryObj[property].ToString()!);
                }
            }
            catch (ManagementException e)
            {
                returnValues.Add(e.Message);
            }


            return returnValues;
        }


    }
}
