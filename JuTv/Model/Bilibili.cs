using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuTv.Model
{
    public class Bilibili
    {
        public class Owner
        {
            /// <summary>
            /// 
            /// </summary>
            public string face { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int mid { get; set; }
            /// <summary>
            /// 小米公司
            /// </summary>
            public string name { get; set; }
        }

        public class Cover
        {
            /// <summary>
            /// 
            /// </summary>
            public string src { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int height { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int width { get; set; }
        }

        public class DataItem
        {
            /// <summary>
            /// 
            /// </summary>
            public Owner owner { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Cover cover { get; set; }
            /// <summary>
            /// 小米Max 2超耐久直播第二季-第9天
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int room_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int online { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string playurl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string accept_quality { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int broadcast_type { get; set; }
            /// <summary>
            /// 生活娱乐
            /// </summary>
            public string area { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int area_id { get; set; }
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
            public List<DataItem> data { get; set; }
        }
    }
}