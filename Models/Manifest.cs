using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Manifest
    {
        public Manifest()
        {
            Manifestpackages = new HashSet<Manifestpackage>();
            Orderitems = new HashSet<Orderitem>();
            Orderitemshistories = new HashSet<Orderitemshistory>();
            Ordershipaddresslogs = new HashSet<Ordershipaddresslog>();
            Ordersjobitems = new HashSet<Ordersjobitem>();
        }

        public int Manifestid { get; set; }
        public string Manifeststatus { get; set; } = null!;
        public string? Comments { get; set; }
        public int? Postuserid { get; set; }
        public DateTime? Postdate { get; set; }
        public DateTime Createdate { get; set; }
        public int Createuserid { get; set; }
        public DateTime? Canceldate { get; set; }
        public int? Canceluserid { get; set; }
        public int? Manifestsequence { get; set; }
        public int Orderid { get; set; }
        public DateTime? Shipdate { get; set; }
        public int? Carrierid { get; set; }
        public int? Carrierserviceid { get; set; }
        public string? Carrieracct { get; set; }
        public string? Otherfreight { get; set; }
        public string? Servicelevel { get; set; }
        public int? Unitssent { get; set; }
        public int? Packagessent { get; set; }
        public int? Palletssent { get; set; }
        public int? Cartonssent { get; set; }

        public virtual Carrier? Carrier { get; set; }
        public virtual Carrierservice? Carrierservice { get; set; }
        public virtual Order Order { get; set; } = null!;
        public virtual ICollection<Manifestpackage> Manifestpackages { get; set; }
        public virtual ICollection<Orderitem> Orderitems { get; set; }
        public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; }
        public virtual ICollection<Ordershipaddresslog> Ordershipaddresslogs { get; set; }
        public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; }
    }
}
