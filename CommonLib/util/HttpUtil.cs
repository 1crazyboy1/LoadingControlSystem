using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace CommonLib.util
{
    public class HttpUtil
    {
        public string post(string url, string apijson)
        {
                string result = "";
                Console.WriteLine("Start Create:" + DateTime.Now.ToString());
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                Console.WriteLine("End Create:" + DateTime.Now.ToString());
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                {
                    byte[] data = Encoding.UTF8.GetBytes("p=" + apijson);
                    req.ContentLength = data.Length;
                    Console.WriteLine("Start Request:"+DateTime.Now.ToString());
                    using (Stream reqStream = req.GetRequestStream())
                    {
                        reqStream.Write(data, 0, data.Length);
                        reqStream.Close();
                    }
                    Console.WriteLine("End Request:" + DateTime.Now.ToString());

                    Console.WriteLine("Stare Response:" + DateTime.Now.ToString());
                    HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                    Stream stream = resp.GetResponseStream();
                    //获取响应内容  
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        result = reader.ReadToEnd();
                    }
                    Console.WriteLine("End Response:" + DateTime.Now.ToString());
                    return result;
                }
              
        }
    }
}
