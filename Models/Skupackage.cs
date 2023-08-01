using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skupackage
    {
        public int Uniqueid { get; set; }
        public string Packagetype { get; set; } = null!;
        public double Quantity { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public bool Isprimaryuom { get; set; }
        public bool Isstatus { get; set; }
        public bool Isitemwithbox { get; set; }
        public int Skuid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public int Modifieduserid { get; set; }
        public int Shippingboxid { get; set; }
        public string? Parentpackagetype { get; set; }
        public int? Ti { get; set; }
        public int? Hi { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Skushippingbox Shippingbox { get; set; } = null!;
        public virtual Sku Sku { get; set; } = null!;
    }
}
