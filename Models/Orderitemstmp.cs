using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Orderitemstmp
    {
        public int Uniqueid { get; set; }
        public string? Sku { get; set; }
        public int? Skuid { get; set; }
        public int? Entryunserid { get; set; }
        public DateTime? Entrydate { get; set; }
        public int Orderqty { get; set; }
        public decimal? Skucost { get; set; }
        public string Customerorderid { get; set; } = null!;
        public decimal? Promoskucost { get; set; }
        public string? Ordersubid { get; set; }
        public string? Skulineno { get; set; }
        public int Clientid { get; set; }
        public int? Noupdate { get; set; }

        public virtual Sku? SkuNavigation { get; set; }
    }
}
