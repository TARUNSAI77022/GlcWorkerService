using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Batching
    {
        public Batching()
        {
            Batchingitems = new HashSet<Batchingitem>();
            Orders = new HashSet<Order>();
        }

        public int Uniqueid { get; set; }
        public int Linecount { get; set; }
        public int Clientid { get; set; }
        public DateTime Entrydate { get; set; }
        public int? Shipviaid { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Carrierservice? Shipvia { get; set; }
        public virtual ICollection<Batchingitem> Batchingitems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
