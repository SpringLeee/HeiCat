using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuTv.Model
{
    public class LiZhi
    {
        public class DataListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string radioConver { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int liveStatus { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string totalCount { get; set; }
            /// <summary>
            /// 我可以跟在你身后
            /// </summary>
            public string liveName { get; set; }
            /// <summary>
            /// 罗师傅【燃点娱乐】
            /// </summary>
            public string userName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string liveId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string userPortrait { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string liveStartTime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string liveEndTime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tag { get; set; }
        }

        public class Ret
        {
            /// <summary>
            /// 
            /// </summary>
            public List<DataListItem> dataList { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int count { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int pageTotal { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string dataVerTime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int pageNum { get; set; }
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
            public string msg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Ret ret { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string opt { get; set; }
        }

    }
}