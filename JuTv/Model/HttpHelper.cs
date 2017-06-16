using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
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

    }
}