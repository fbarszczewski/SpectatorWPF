using System.Management;

namespace SpectatorWPF.Model
{
    internal class Wmi
    {
        private  ManagementObjectSearcher _searcher;

        public Wmi()
        {
            _searcher = new ManagementObjectSearcher();
        }


        public string GetValue(string fromNamespace, string fromClass, string  property )
        {
            var propertyValue = "";
            try
            {
                foreach (var queryObj in new ManagementObjectSearcher(fromNamespace, $"SELECT {property} FROM {fromClass}").Get())
                {
                    propertyValue = queryObj[property].ToString();
                }

            }
            catch (ManagementException e)
            {
                propertyValue = e.Message;
            }

            return propertyValue;

        }
        // _searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSWmi_PnPInstanceNames");
    }
}
