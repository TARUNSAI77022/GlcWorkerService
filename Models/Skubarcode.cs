using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skubarcode
    {
        public int Uniqueid { get; set; }
        public string Packagetype { get; set; } = null!;
        public string Barcode { get; set; } = null!;
        public int Skuid { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Sku Sku { get; set; } = null!;
    }
}
