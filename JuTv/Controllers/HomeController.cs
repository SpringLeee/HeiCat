using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace JuTv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            string url = "https://apis.zhanqi.tv/static/v2.1/live/list/4/1.json?os=1&ver=3.3.4";
            var res = Model.HttpHelper.GetJsonEncode(url);
            var Data = JsonConvert.DeserializeObject<Model.ZhanQi.Root>(res).data.rooms;
            ViewBag.TV = Data;
            ViewBag.Nav = "index";


            string QMurl = "https://www.quanmin.tv/json/play/list.json?0607144417&p=2&rid=(null)&rcat=(null)&uid=-1&screen=2&device=16E8ACC4-97C3-403F-809F-FC798A3C17EA&sw=414.0&sh=736.0&ch=APPStore&refer=list/all&osversion=ios_10.2&appver=3.2.22";
            var QMres = Model.HttpHelper.GetJson(QMurl);
            var QMData = JsonConvert.DeserializeObject<Model.QuanMin.Root>(QMres).data;
            ViewBag.List = QMData;

            if (Request["rid"]==null)
            {
                Random r = new Random();
                var i = r.Next(0, 3);
                ViewBag.Vsrc = "http://dlhls.cdn.zhanqi.tv/zqlive/" + Data[i].videoId + ".m3u8";
            }
            else
            {
                var rid = Request["rid"].ToString();
                ViewBag.Vsrc = "http://dlhls.cdn.zhanqi.tv/zqlive/" + rid + ".m3u8";

            }


            //----------------- 记录日志

            var AddressIP = Model.HttpHelper.GetWebClientIp();

            Spring.QQMailHelper.Send("1028789852","mm2717965346","1028789852@qq.com","Bingo","你好,"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + AddressIP + " 访问了黑猫TV");
            

            return View();
            
        }
        public ActionResult Bilibili()
        {
            List<Model.Bilibili.DataItem> Data = new List<Model.Bilibili.DataItem>();

            for (int i = 1; i < 3; i++)
            {
                string url = "https://api.live.bilibili.com/mobile/rooms?access_key=14db06974ee2eaff933088b839c32eca&actionKey=appkey&appkey=27eb53fc9058f8c3&area_id=0&build=5570&device=phone&mobi_app=iphone&page="+i+"&platform=ios&sign=8bd36245df27313f46a3eec3e30f2fad&sort=hottest&ts=1496366812";
                var res = Model.HttpHelper.GetJson(url);

                var temp = JsonConvert.DeserializeObject<Model.Bilibili.Root>(res).data;
                Data.AddRange(temp);
            }

            List<string> Imgs = new List<string>();
            foreach (var item in Data)
            {
                var res = Model.HttpHelper.GetHtml(item.cover.src);
                Imgs.Add("data:image/jpeg;base64," + res);
            }
            

            ViewBag.TV = Data;
            ViewBag.Imgs = Imgs;
            ViewBag.Nav = "bilibili";

            return View();
        }


       

        public ActionResult QuanMin()
        {
            string url = "https://www.quanmin.tv/json/play/list.json?0607144417&p=2&rid=(null)&rcat=(null)&uid=-1&screen=2&device=16E8ACC4-97C3-403F-809F-FC798A3C17EA&sw=414.0&sh=736.0&ch=APPStore&refer=list/all&osversion=ios_10.2&appver=3.2.22";
            var res = Model.HttpHelper.GetJson(url);
            var Data = JsonConvert.DeserializeObject<Model.QuanMin.Root>(res).data;
            ViewBag.TV = Data;
            ViewBag.Nav = "quanmin";
            return View();
        }

        public ActionResult HuoMao()
        {
            string url = "";
            List<Model.HuoMao.ListItem> Data = new List<Model.HuoMao.ListItem>();
            for (int i = 1; i < 5; i++)
            {
                url = "https://api.huomao.com/channels/channelpage.json?ver=1.5.4&time=1496902800&refer=ios&pf_ver=10.2&page="+i+"&fr=applestore&an=93&token=53e9f134f0025f8829ecc51a659e58a6";
                var res = Model.HttpHelper.GetJson(url);
                var item = JsonConvert.DeserializeObject<Model.HuoMao.Root>(res).data.list;
                Data.AddRange(item);
            }
            ViewBag.TV = Data;
            ViewBag.Nav = "huomao";
            return View();
            
        }

        public ActionResult ZhanQi()
        {
            string url = "https://apis.zhanqi.tv/static/v2.1/live/list/100/1.json?os=1&ver=3.3.4";
            var res = Model.HttpHelper.GetJsonEncode(url);
            var Data = JsonConvert.DeserializeObject<Model.ZhanQi.Root>(res).data.rooms;
            ViewBag.TV = Data;
            ViewBag.Nav = "ZhanQi";
            return View();


        }

        public ActionResult Player(string roomid,string type)
        {

            if (string.IsNullOrEmpty(roomid))
            {
                Response.Redirect("/Home");
            }

            string url = "";
            if (type=="QuanMin")
            {
                url = "http://hls.quanmin.tv/live/"+roomid+"_L4/playlist.m3u8";
            }
            if (type=="Bili")
            {
                url = "http://live.bilibili.com/api/playurl?player=1&cid=" + roomid + "&quality=0";
                XmlDocument xdoc = new XmlDocument();

                xdoc.Load(url);
                url= xdoc.SelectSingleNode("video").SelectSingleNode("durl").SelectSingleNode("url").InnerText;
            }
           
            if (type=="HuoMao")
            {
                url = "http://api.huomao.com/channels/channelDetail?&cid="+roomid+"&time=1497403071&token="+Model.HttpHelper.GetMD5("1497403071"+roomid+"EU*T*)*(#23ssdfd");
                var res = Model.HttpHelper.GetJson(url);
                var item = JsonConvert.DeserializeObject<Model.HuoMao.HuoMaoItem.Root>(res).data;
                url = item.streamList[0].HD;

            }
            if (type=="ZhanQi")
            {
                url = "http://dlhls.cdn.zhanqi.tv/zqlive/"+roomid+".m3u8";
            }
            

            ViewBag.src = url;
            
            return View();
        }

        public ActionResult LiZhiFM()
        {
            string url = "https://appweb.lizhi.fm/smallApp/getLiveList?pageNum=1&t=oM5UI0RtdYnlkoCMBy9-twtjb6E0&s=1c72a98a7a99b3ed7ad8b484933641c5&dataVerTime=1501057595";
            var res = Model.HttpHelper.GetJsonEncode(url);
            var Data = JsonConvert.DeserializeObject<Model.LiZhi.Root>(res).ret.dataList.ToList();
            ViewBag.TV = Data;
            ViewBag.Nav = "LiZhiFM";
            return View();
        }

        

        

        public ActionResult Test1()
        {
           
            return View();
       
        }
      
    }
}