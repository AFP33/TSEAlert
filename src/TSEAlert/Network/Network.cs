using System.Net;
using System.IO;
using System;

namespace TSEAlert.Network
{
    public class Network
    {
        public string ResponseResult { get; set; }
        public string ResponseStatus { get; set; }

        public void SendRequest(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse())
                using (Stream stream = webResponse.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    ResponseStatus = webResponse.StatusDescription;

                    if (webResponse.StatusDescription != "OK")
                    {
                        ResponseResult = "";
                        return;
                    }
                    ResponseResult = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
