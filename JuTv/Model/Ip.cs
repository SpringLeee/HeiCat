using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuTv.Model
{
    public class Ip
    {
        public class DataItem
        {
            /// <summary>
            /// 本地局域网
            /// </summary>
            public string location { get; set; }
            /// <summary>
            /// IP地址查询
            /// </summary>
            public string titlecont { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string origip { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string origipquery { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string showlamp { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int showLikeShare { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int shareImage { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ExtendedLocation { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string OriginQuery { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tplt { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string resourceid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string fetchkey { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string appinfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int role_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int disp_type { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public string status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string t { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string set_cache_time { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<DataItem> data { get; set; }
        }

    }
}