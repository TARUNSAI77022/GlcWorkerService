using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Ordersjob
    {
        public Ordersjob()
        {
            Ordersjobitems = new HashSet<Ordersjobitem>();
        }

        public int Uniqueid { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Nooforders { get; set; }
        public string Jobname { get; set; } = null!;
        public bool? Isactive { get; set; }
        public int? Modifieduserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Completeddate { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser? Modifieduser { get; set; }
        public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; }
    }
}
