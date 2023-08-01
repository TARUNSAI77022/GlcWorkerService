using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Robilling
    {
        public int Uniqueid { get; set; }
        public int Pouniqueid { get; set; }
        public int Ccuniqueid { get; set; }
        public string Branch { get; set; } = null!;
        public decimal Localcost { get; set; }
        public decimal Localsell { get; set; }
        public string Creditor { get; set; } = null!;
        public string Debitor { get; set; } = null!;
        public int Noofpallets { get; set; }
        public string? Comments { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public int Modifieduserid { get; set; }
        public string Modifieddate { get; set; } = null!;

        public virtual Rochargecode Ccunique { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Roreceiving Pounique { get; set; } = null!;
    }
}
