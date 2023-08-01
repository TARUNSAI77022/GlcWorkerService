using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Orderitemshistory
    {
        public int Uniqueid { get; set; }
        public int Skuid { get; set; }
        public int Orderid { get; set; }
        public int Qty { get; set; }
        public int? Qcuserid { get; set; }
        public int Qcqty { get; set; }
        public bool Qcdone { get; set; }
        public DateTime? Qcdate { get; set; }
        public int? Pickeduserid { get; set; }
        public DateTime? Pickeddate { get; set; }
        public int? Manifestid { get; set; }
        public int? Locationid { get; set; }
        public string? Lotcode { get; set; }
        public DateTime? Lotexpdate { get; set; }
        public int? Packageid { get; set; }
        public int? Pickqty { get; set; }
        public int? Orderitemsid { get; set; }
        public int? Siluniqueid { get; set; }
        public bool? Isskip { get; set; }

        public virtual Whlocation? Location { get; set; }
        public virtual Manifest? Manifest { get; set; }
        public virtual Order Order { get; set; } = null!;
        public virtual Orderitem? Orderitems { get; set; }
        public virtual Manifestpackage? Package { get; set; }
        public virtual Whuser? Pickeduser { get; set; }
        public virtual Whuser? Qcuser { get; set; }
        public virtual Skuinventorylocation? Silunique { get; set; }
        public virtual Sku Sku { get; set; } = null!;
    }
}
