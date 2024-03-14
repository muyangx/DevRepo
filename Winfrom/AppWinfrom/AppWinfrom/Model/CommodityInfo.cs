using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppWinfrom.Model
{
    public class CommodityInfo
    {
        public string data { get; set; }

    }

    public class DataModel
    {
        public Data data { get; set; }
    }
    public class Data
    {
        public string P_id { get; set; }
        public string P_title { get; set; }
        public float P_price { get; set; }
        public string P_content { get; set; }
        public string P_pic { get; set; }
        public string P_video { get; set; }
        public string P_description { get; set; }
        public string P_xitong { get; set; }
        public string P_bz { get; set; }
        public string P_fenzhan { get; set; }
        public string P_youhui { get; set; }
        public string P_baozhang { get; set; }
        public string domain { get; set; }
        public Dictionary<int, Obj> P_ggxq { get; set; }

        private List<Obj> p_ggxqList;//字段 ，  属性 区别。
        public List<Obj> P_ggxqList
        {
            get
            {
                if (p_ggxqList == null)
                {
                    p_ggxqList=new List<Obj> ();
                    // p_ggxqList = P_ggxq.Select(i => i.Value).ToList();// 委托 lambada表达式 linq
                    foreach (var item in P_ggxq)
                    {
                        p_ggxqList.Add(item.Value);
                    }
                }
                return p_ggxqList;
            }
        }
        public string kefu { get; set; }
        public string tousu { get; set; }
    }
    public class Obj
    {
        public string gg { get; set; }
        public int premium { get; set; }
        public string xzdz { get; set; }
        public int download_type { get; set; }


    }


}
