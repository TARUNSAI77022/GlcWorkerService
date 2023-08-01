using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Sku
    {
        public Sku()
        {
            Batchingitems = new HashSet<Batchingitem>();
            Cyclecounthistories = new HashSet<Cyclecounthistory>();
            Orderitems = new HashSet<Orderitem>();
            Orderitemshistories = new HashSet<Orderitemshistory>();
            Orderitemstmps = new HashSet<Orderitemstmp>();
            Orders = new HashSet<Order>();
            Skuautofills = new HashSet<Skuautofill>();
            Skubarcodes = new HashSet<Skubarcode>();
            Skuinventorylocationlogs = new HashSet<Skuinventorylocationlog>();
            Skuinventorylocations = new HashSet<Skuinventorylocation>();
            SkukitmappingComponentskus = new HashSet<Skukitmapping>();
            SkukitmappingKitskus = new HashSet<Skukitmapping>();
            Skupackages = new HashSet<Skupackage>();
        }

        public int Skuid { get; set; }
        public string Sku1 { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public double Weight { get; set; }
        public int Reorderpoint { get; set; }
        public decimal Purchasecost { get; set; }
        public string Itemtype { get; set; } = null!;
        public int? Maxorderqty { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public int? Minorderqty { get; set; }
        public string Uom { get; set; } = null!;
        public bool Islotcode { get; set; }
        public bool Isexpdate { get; set; }
        public bool Isserialno { get; set; }
        public string? Hsncode { get; set; }
        public string? Mpncode { get; set; }
        public string? Gtin { get; set; }
        public int Expdays { get; set; }
        public int Clientid { get; set; }
        public int? Sellcost { get; set; }
        public int? Safetystock { get; set; }
        public string? Imageurl { get; set; }
        public string? Alternateitemcode { get; set; }
        public string? Alternateitemdescription { get; set; }
        public string? Itemcategory { get; set; }
        public string? Subitemcategory { get; set; }
        public string? Storagetype { get; set; }
        public bool Iscyclecount { get; set; }
        public string? Expyears { get; set; }
        public string? Manufacturervendor { get; set; }
        public bool Ishazmat { get; set; }
        public string? Hazmat { get; set; }
        public string? Cyclemonths { get; set; }
        public bool Iskititem { get; set; }
        public bool Isoversize { get; set; }
        public int? Originid { get; set; }
        public byte[]? Photo { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Country? Origin { get; set; }
        public virtual ICollection<Batchingitem> Batchingitems { get; set; }
        public virtual ICollection<Cyclecounthistory> Cyclecounthistories { get; set; }
        public virtual ICollection<Orderitem> Orderitems { get; set; }
        public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; }
        public virtual ICollection<Orderitemstmp> Orderitemstmps { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Skuautofill> Skuautofills { get; set; }
        public virtual ICollection<Skubarcode> Skubarcodes { get; set; }
        public virtual ICollection<Skuinventorylocationlog> Skuinventorylocationlogs { get; set; }
        public virtual ICollection<Skuinventorylocation> Skuinventorylocations { get; set; }
        public virtual ICollection<Skukitmapping> SkukitmappingComponentskus { get; set; }
        public virtual ICollection<Skukitmapping> SkukitmappingKitskus { get; set; }
        public virtual ICollection<Skupackage> Skupackages { get; set; }
    }
}
