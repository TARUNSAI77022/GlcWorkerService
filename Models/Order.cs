using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Order
    {
        public Order()
        {
            Manifests = new HashSet<Manifest>();
            Orderitems = new HashSet<Orderitem>();
            Orderitemshistories = new HashSet<Orderitemshistory>();
            Ordershipaddresslogs = new HashSet<Ordershipaddresslog>();
            Ordersjobitems = new HashSet<Ordersjobitem>();
            Ordersshipments = new HashSet<Ordersshipment>();
        }

        public int Clientid { get; set; }
        public int Whid { get; set; }
        public DateTime Orderdate { get; set; }
        public DateTime Createddate { get; set; }
        public int Entryuserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public decimal Ordertotal { get; set; }
        public decimal Ordertax { get; set; }
        public decimal Orderskucost { get; set; }
        public decimal Orderdiscount { get; set; }
        public bool Ispriority { get; set; }
        public int Saleschannelid { get; set; }
        public string Custorderid { get; set; } = null!;
        public string? Vendororderid { get; set; }
        public DateTime? Expectedshipdate { get; set; }
        public bool Ishold { get; set; }
        public string Orderstatus { get; set; } = null!;
        public decimal Ordershipcost { get; set; }
        public int Orderid { get; set; }
        public string? Storeid { get; set; }
        public int? Masterskuid { get; set; }
        public int? Kitqty { get; set; }
        public int? Kitcompletedqty { get; set; }
        public DateTime? Ordercompleteddate { get; set; }
        public string? Originalorderid { get; set; }
        public string? Comments { get; set; }
        public DateTime? Preferredshipdate { get; set; }
        public int? Modifieduserid { get; set; }
        public bool Isgiftorder { get; set; }
        public bool? Completeshipment { get; set; }
        public string? Giftmessage { get; set; }
        public string? Customerpo { get; set; }
        public int? Jobid { get; set; }
        public int? Toteid { get; set; }
        public bool? Ispartialkit { get; set; }
        public int? Batchid { get; set; }
        public string Ordertype { get; set; } = null!;
        public bool Iskitorder { get; set; }
        public string? Apprefid { get; set; }
        public string? Carrierlabelref { get; set; }
        public string? Internalcomments { get; set; }
        public bool? Isorderconfirmationsent { get; set; }
        public string? Batchjobid { get; set; }
        public DateTime? Batchjobdate { get; set; }

        public virtual Batching? Batch { get; set; }
        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Sku? Mastersku { get; set; }
        public virtual Whuser? Modifieduser { get; set; }
        public virtual Warehouse Wh { get; set; } = null!;
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<Orderitem> Orderitems { get; set; }
        public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; }
        public virtual ICollection<Ordershipaddresslog> Ordershipaddresslogs { get; set; }
        public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; }
        public virtual ICollection<Ordersshipment> Ordersshipments { get; set; }
    }
}
