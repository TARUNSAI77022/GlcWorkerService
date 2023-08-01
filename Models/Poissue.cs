using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Poissue
    {
        public int Poissueid { get; set; }
        public string? Ponumber { get; set; }
        public DateTime? Podate { get; set; }
        public int? Skuid { get; set; }
        public string? Sku { get; set; }
        public string? Description { get; set; }
        public int? Rcdqty { get; set; }
        public string? Skuissue { get; set; }
        public string? Comments { get; set; }
    }
}
