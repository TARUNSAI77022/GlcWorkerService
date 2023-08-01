using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skuautofill
    {
        public int Uniqueid { get; set; }
        public int Saleschannelid { get; set; }
        public string Channel { get; set; } = null!;
        public DateTime ActivefromDate { get; set; }
        public DateTime ActivetoDate { get; set; }
        public int Quantity { get; set; }
        public int Skuid { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifiedentrydate { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Saleschannel Saleschannel { get; set; } = null!;
        public virtual Sku Sku { get; set; } = null!;
    }
}
