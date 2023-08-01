using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Cyclecounttracking
    {
        public int Uniqueid { get; set; }
        public int Cyclecountid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Modifieduserid { get; set; }
        public int Noofstaffused { get; set; }
        public int Totaltimeminutes { get; set; }
        public DateTime Taskdate { get; set; }
        public string? Comments { get; set; }
        public string Cyclecountby { get; set; } = null!;

        public virtual Cyclecount Cyclecount { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser? Modifieduser { get; set; }
    }
}
