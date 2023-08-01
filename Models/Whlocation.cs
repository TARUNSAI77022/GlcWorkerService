using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whlocation
    {
        public Whlocation()
        {
            Orderitems = new HashSet<Orderitem>();
            Orderitemshistories = new HashSet<Orderitemshistory>();
            RoreceivinghistoryLocations = new HashSet<Roreceivinghistory>();
            RoreceivinghistoryPallets = new HashSet<Roreceivinghistory>();
            SkuinventorylocationLocations = new HashSet<Skuinventorylocation>();
            SkuinventorylocationPallets = new HashSet<Skuinventorylocation>();
            Skuinventorylocationlogs = new HashSet<Skuinventorylocationlog>();
        }

        public int Uniqueid { get; set; }
        public string Location { get; set; } = null!;
        public int Whid { get; set; }
        public string Aisle { get; set; } = null!;
        public string Rack { get; set; } = null!;
        public string Row { get; set; } = null!;
        public string Shelf { get; set; } = null!;
        public int Bin { get; set; }
        public string Locationtype { get; set; } = null!;
        public string Inventorystored { get; set; } = null!;
        public bool? Pickseq { get; set; }
        public int Fillfactor { get; set; }
        public bool? Picklocation { get; set; }
        public int Locweight { get; set; }
        public string Locweightunits { get; set; } = null!;
        public int? Locunits { get; set; }
        public int Locwidth { get; set; }
        public int Locheight { get; set; }
        public int Loclength { get; set; }
        public int Locmaxskus { get; set; }
        public bool Isliftassist { get; set; }
        public bool Isrowrestricted { get; set; }
        public bool Isscraploc { get; set; }
        public bool Isreturnloc { get; set; }
        public string Barcode { get; set; } = null!;
        public string? Qrcode { get; set; }
        public string Removalstrategy { get; set; } = null!;
        public string Putawaystrategy { get; set; } = null!;
        public bool Isbinlocation { get; set; }
        public bool? Isactive { get; set; }
        public int? Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public string? Velocityrank { get; set; }

        public virtual Whuser? Entryuser { get; set; }
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Warehouse Wh { get; set; } = null!;
        public virtual ICollection<Orderitem> Orderitems { get; set; }
        public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; }
        public virtual ICollection<Roreceivinghistory> RoreceivinghistoryLocations { get; set; }
        public virtual ICollection<Roreceivinghistory> RoreceivinghistoryPallets { get; set; }
        public virtual ICollection<Skuinventorylocation> SkuinventorylocationLocations { get; set; }
        public virtual ICollection<Skuinventorylocation> SkuinventorylocationPallets { get; set; }
        public virtual ICollection<Skuinventorylocationlog> Skuinventorylocationlogs { get; set; }
    }
}
