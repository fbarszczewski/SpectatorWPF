using System.Collections.Generic;
using System.Management;

namespace SpectatorWPF.Model
{
    public static class Wmi
    {



        /// <summary>
        /// Searches for value in WMI
        /// </summary>
        /// <param name="fromNamespace"> WMI namespace</param>
        /// <param name="fromClass">WMI class</param>
        /// <param name="property">WMI property</param>
        /// <returns>string value for given property</returns>
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
        /// <summary>
        /// Searches for values in WMI
        /// </summary>
        /// <param name="fromNamespace">WMI class</param>
        /// <param name="fromClass">WMI class</param>
        /// <param name="properties">WMI property</param>
        /// <returns>List of string for given properties in properties order</returns>
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
                if (e.Message == "Invalid query ")
                {
                    foreach (var property in properties)
                    {
                        returnValues.Add(GetValue(fromNamespace, fromClass, property));
                    }
                }
                else
                    returnValues.Add(e.Message);
            }

            if (returnValues.Count > 0)
                return returnValues;
            else
            {
                returnValues.Add("");

                return returnValues;
            }
        }


    }
}
