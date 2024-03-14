using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppWinfrom.Model
{
    public class PayOver
    {
            public int code { get; set; }
            public string msg { get; set; }
            public Datum[] data { get; set; }
        public class Datum
        {
            public string O_title { get; set; }
            public string O_gg { get; set; }
            public string O_num { get; set; }
            public string O_price { get; set; }
            public string O_no { get; set; }
            public string O_time { get; set; }
            public string O_mobile { get; set; }
            public string O_genkey { get; set; }
            public string O_email { get; set; }
            public string O_paytype { get; set; }
            public string O_state { get; set; }
            public string O_xz { get; set; }
            public string O_content { get; set; }
            public string mobile { get; set; }
            public string email { get; set; }
            public string L_no { get; set; }
            public string fahuo { get; set; }
        }

    }
}
