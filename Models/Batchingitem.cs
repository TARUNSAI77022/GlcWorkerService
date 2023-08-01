using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Batchingitem
    {
        public int Uniqueid { get; set; }
        public int Batchid { get; set; }
        public int Skuid { get; set; }
        public int Qty { get; set; }
        public DateTime Entrydate { get; set; }

        public virtual Batching Batch { get; set; } = null!;
        public virtual Sku Sku { get; set; } = null!;
    }
}
