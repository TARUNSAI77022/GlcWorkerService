using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Orders = new HashSet<Order>();
            Whclients = new HashSet<Whclient>();
            Whlocations = new HashSet<Whlocation>();
            Whuserwarehouses = new HashSet<Whuserwarehouse>();
        }

        public int Uniqueid { get; set; }
        public string Whname { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postalcode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Whclient> Whclients { get; set; }
        public virtual ICollection<Whlocation> Whlocations { get; set; }
        public virtual ICollection<Whuserwarehouse> Whuserwarehouses { get; set; }
    }
}
