using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuTv.Model
{
    public class ZhanQi
    {

        public class RoomsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string uid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string nickname { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gender { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatar { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 2017LPL夏季赛16号17:00 OMG VS SNG
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string spic { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string bpic { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string online { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string hotsLevel { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string videoId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string verscr { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string classId { get; set; }
            /// <summary>
            /// 热门竞技
            /// </summary>
            public string className { get; set; }
            /// <summary>
            /// 英雄联盟
            /// </summary>
            public string newGameName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string fatherGameId { get; set; }
            /// <summary>
            /// 英雄联盟
            /// </summary>
            public string fatherGameName { get; set; }
            /// <summary>
            /// 英雄联盟
            /// </summary>
            public string gameName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string line { get; set; }
            /// <summary>
            /// 杭州
            /// </summary>
            public string location { get; set; }
        }

        public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public int cnt { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<RoomsItem> rooms { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string message { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Data data { get; set; }
        }
    }
}