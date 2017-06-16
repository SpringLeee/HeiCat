using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuTv.Model
{
    public class HuoMao
    {
        public class ListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string channel { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string uid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string img { get; set; }
            /// <summary>
            /// ESL One官方
            /// </summary>
            public string username { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int is_live { get; set; }
            /// <summary>
            /// 6.67万
            /// </summary>
            public string views { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string headimg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gname { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int screenType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int type { get; set; }
        }

        public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public int allCount { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ListItem> list { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int allPage { get; set; }
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
            public int status { get; set; }
            /// <summary>
            /// 处理成功
            /// </summary>
            public string message { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Data data { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int timeStamp { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string is_square { get; set; }
        }


        public class HuoMaoItem
        {
            public class StreamListItem
            {
                /// <summary>
                /// 
                /// </summary>
                public string TD { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string HD { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string SD { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string BD { get; set; }
            }

            public class Data
            {
                /// <summary>
                /// 
                /// </summary>
                public string is_tuijian { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string stream { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string content { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string is_sub { get; set; }
                /// <summary>
                /// 【老武】
                /// </summary>
                public string username { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int uid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string stream_key { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string is_gf { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int gid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tj_pic { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_live { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string room_number { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string id { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string is_entertainment { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int views { get; set; }
                /// <summary>
                /// 『老武』NANO-OP
                /// </summary>
                public string channel { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string headimg { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int desrc_count { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string gname { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int cdn_key { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int cdn_count { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<StreamListItem> streamList { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string defaultBitRate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_desrc { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int manager { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int experience { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_activity { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string activity_url { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string activity_img { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int specialRoom { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int isBeginGuess { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int activeExist { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<string> activeList { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_jingcai { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string spjc_url { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string spjc_title { get; set; }
            }

            public class Root
            {
                /// <summary>
                /// 
                /// </summary>
                public string code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int status { get; set; }
                /// <summary>
                /// 处理成功
                /// </summary>
                public string message { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Data data { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int timeStamp { get; set; }
            }
        }
    }
}