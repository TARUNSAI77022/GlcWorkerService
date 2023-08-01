using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Rotracking
    {
        public int Uniqueid { get; set; }
        public int Pouniqueid { get; set; }
        public string? Supplierasn { get; set; }
        public string Containertype { get; set; } = null!;
        public int Noofstaffused { get; set; }
        public int Totaltimehours { get; set; }
        public int Totaltimeminutes { get; set; }
        public int? Noofcases { get; set; }
        public int? Noofpallets { get; set; }
        public int? Nooflabels { get; set; }
        public string Receivedby { get; set; } = null!;
        public string Stockedby { get; set; } = null!;
        public DateTime Taskdate { get; set; }
        public string? Comments { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual Roreceiving Pounique { get; set; } = null!;
    }
}
