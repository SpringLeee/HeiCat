using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace JuTv.Model
{
    public static class HttpHelper
    {
        public static string GetJson(string url)
        {
            WebClient wc = new WebClient();
            byte[] bResponse = wc.DownloadData(url);
            string strResponse = Encoding.ASCII.GetString(bResponse);
            return strResponse;

        }
        public static string GetJsonEncode(string url)
        {
            WebClient wc = new WebClient();
            byte[] bResponse = wc.DownloadData(url);
            string strResponse = Encoding.UTF8.GetString(bResponse);
            return strResponse;

        }


        public static string ToBase64(string str)
        {
            
            byte[] b = System.Text.Encoding.Default.GetBytes(str);
           
            var  a = Convert.ToBase64String(b);
            return a;
        }

        public static string ToStr(string str)
        {
            byte[] c = Convert.FromBase64String(str);
            var  a = System.Text.Encoding.Default.GetString(c);
            return a;
        }

        public static string GetHtml(string url)
        {
            WebRequest myrequest = WebRequest.Create(url);
            WebResponse myresponse = myrequest.GetResponse();
            Stream imgstream = myresponse.GetResponseStream();
            System.Drawing.Image img = System.Drawing.Image.FromStream(imgstream);
            //img.Save(Server.MapPath("test.jpg"),System.Drawing.Imaging.ImageFormat.Jpeg);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var T = ms.ToArray();

            return Convert.ToBase64String(T);

        }

       

        public static string GetMD5(string sDataIn)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToLower();
        }



        public static string GetWebClientIp()
        {
            string userIP = "未获取用户IP";

            try
            {
                if (System.Web.HttpContext.Current == null
            || System.Web.HttpContext.Current.Request == null
            || System.Web.HttpContext.Current.Request.ServerVariables == null)
                    return "";

                string CustomerIP = "";

                //CDN加速后取到的IP   
                CustomerIP = System.Web.HttpContext.Current.Request.Headers["Cdn-Src-Ip"];
                if (!string.IsNullOrEmpty(CustomerIP))
                {
                    return CustomerIP;
                }

                CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];


                if (!String.IsNullOrEmpty(CustomerIP))
                    return CustomerIP;

                if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
                {
                    CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (CustomerIP == null)
                        CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
                else
                {
                    CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

                }

                if (string.Compare(CustomerIP, "unknown", true) == 0)
                    return System.Web.HttpContext.Current.Request.UserHostAddress;
                return CustomerIP;
            }
            catch { }

            return userIP;
        }

    

        public static string Writefeecus(string con)
        {
           
            string path = System.Web.HttpContext.Current.Server.MapPath("~/") + "Content/logs/" + DateTime.Now.ToString("yyyyMMdd") + "/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileStream file = new FileStream(path + DateTime.Now.ToString("yyyyMMdd") + ".txt", FileMode.Append);
            using (StreamWriter sw = new StreamWriter(file,Encoding.UTF8))
            {
                sw.WriteLine(con);
            }

            return file.Name;
        }

    }
}