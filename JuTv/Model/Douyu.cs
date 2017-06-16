using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuTv.Model
{
    public class Douyu
    {
        public class DataItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string room_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string room_src { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string vertical_src { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int isVertical { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int cate_id { get; set; }
            /// <summary>
            /// 今日名家：书法刘培孝老师
            /// </summary>
            public string room_name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string show_status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string subject { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string show_time { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string owner_uid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string specific_catalog { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string specific_status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string vod_quality { get; set; }
            /// <summary>
            /// 齐鲁风书画院
            /// </summary>
            public string nickname { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int online { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string game_url { get; set; }
            /// <summary>
            /// 鱼教
            /// </summary>
            public string game_name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int child_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatar { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatar_mid { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatar_small { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string jumpUrl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string fans { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int ranktype { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int is_noble_rec { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string anchor_city { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int error { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<DataItem> data { get; set; }
        }
    }
}