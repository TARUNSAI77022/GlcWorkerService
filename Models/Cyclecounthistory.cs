using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Cyclecounthistory
    {
        public int Uniqueid { get; set; }
        public int Cyclecountid { get; set; }
        public int Skuid { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int? Modifieduserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int Onhandqty { get; set; }
        public int Cyclecountqty { get; set; }
        public int Locationid { get; set; }
        public int Palletid { get; set; }
        public string? Lotcode { get; set; }

        public virtual Cyclecount Cyclecount { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Sku Sku { get; set; } = null!;
    }
}
