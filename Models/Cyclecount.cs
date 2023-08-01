using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Cyclecount
    {
        public Cyclecount()
        {
            Cyclecounthistories = new HashSet<Cyclecounthistory>();
            Cyclecounttrackings = new HashSet<Cyclecounttracking>();
        }

        public int Cyclecountid { get; set; }
        public string Ccdescription { get; set; } = null!;
        public string Ccno { get; set; } = null!;
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public int? Modifieduserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public DateOnly? Ccstartdate { get; set; }
        public DateOnly? Cccompletedate { get; set; }
        public string Status { get; set; } = null!;
        public string Cctype { get; set; } = null!;
        public string Ccby { get; set; } = null!;
        public int Clientid { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser? Modifieduser { get; set; }
        public virtual ICollection<Cyclecounthistory> Cyclecounthistories { get; set; }
        public virtual ICollection<Cyclecounttracking> Cyclecounttrackings { get; set; }
    }
}
