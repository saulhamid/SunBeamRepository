using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SunBeam.Common.Utility
{
  public class  GetClientInfo
    {
     

        public string ClientPCIPAddress { get; set; }
        public string ClientBrowserInfo { get; set; }
        public string ClientMacAddress { get; set; }
        public string ClientPCUserName { get; set; }

       
        public  void ClientUserInfo()
        {
           

            //Get IP          
            IPAddress[] IPS = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in IPS) if (ip.AddressFamily == AddressFamily.InterNetwork) ClientPCIPAddress = ip.ToString();

            HttpBrowserCapabilities browser = HttpContext.Current.Request.Browser;
            ClientBrowserInfo = browser.Browser + " " + browser.Version;

            //Get All Aics: MAC
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            ClientMacAddress = nics[0].GetPhysicalAddress().ToString();

            ClientPCUserName = ClientPCIPAddress + "~" + GetHostName(ClientPCIPAddress);
        }

        public  string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }
    }
}
