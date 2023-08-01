using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skuinventorylocationlog
    {
        public int Uniqueid { get; set; }
        public int Skuid { get; set; }
        public int Locationid { get; set; }
        public int Transqty { get; set; }
        public string Transtype { get; set; } = null!;
        public DateTime Entryddate { get; set; }
        public string? Recpo { get; set; }
        public int? Reasonid { get; set; }
        public string Lotcode { get; set; } = null!;
        public int? Palletid { get; set; }
        public int Entryuserid { get; set; }
        public string? Filename { get; set; }
        public string? Comments { get; set; }
        public DateTime? Lotexp { get; set; }
        public int? Siluniqueid { get; set; }

        public virtual Whlocation Location { get; set; } = null!;
        public virtual AllStatus? Reason { get; set; }
        public virtual Skuinventorylocation? Silunique { get; set; }
        public virtual Sku Sku { get; set; } = null!;
    }
}
