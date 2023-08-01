using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skukitmapping
    {
        public int Kitskuid { get; set; }
        public int Componentskuid { get; set; }
        public short Quantity { get; set; }
        public short Iteminclude { get; set; }
        public int Uniqueid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual Sku Componentsku { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Sku Kitsku { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
    }
}
