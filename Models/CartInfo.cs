using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class CartInfo
    {
        public CartInfo()
        {
            Carttotes = new HashSet<Carttote>();
            Jobs = new HashSet<Job>();
            Ordersjobitems = new HashSet<Ordersjobitem>();
        }

        public int Uniqueid { get; set; }
        public int Cartsize { get; set; }
        public string Cartname { get; set; } = null!;
        public int Start { get; set; }
        public int End { get; set; }
        public bool? Isactive { get; set; }
        public int? Entryuserid { get; set; }
        public DateTime? Entrydate { get; set; }
        public int? Modifieduserid { get; set; }
        public DateTime? Modifieddate { get; set; }

        public virtual ICollection<Carttote> Carttotes { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; }
    }
}
