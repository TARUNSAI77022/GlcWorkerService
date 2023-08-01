using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skuinventorylocation
    {
        public Skuinventorylocation()
        {
            Orderitemshistories = new HashSet<Orderitemshistory>();
            Skuinventorylocationlogs = new HashSet<Skuinventorylocationlog>();
        }

        public int Uniqueid { get; set; }
        public int Skuid { get; set; }
        public int Locationid { get; set; }
        public int Recqty { get; set; }
        public int Availableqty { get; set; }
        public int Allocatedqty { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime Modifieddate { get; set; }
        public int Modifieduserid { get; set; }
        public string? Recpo { get; set; }
        public string Lotcode { get; set; } = null!;
        public int Palletid { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Lotexp { get; set; }
        public int? Pouniqueid { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whlocation Location { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Whlocation Pallet { get; set; } = null!;
        public virtual Sku Sku { get; set; } = null!;
        public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; }
        public virtual ICollection<Skuinventorylocationlog> Skuinventorylocationlogs { get; set; }
    }
}
