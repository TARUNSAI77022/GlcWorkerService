using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Carrierservice
    {
        public Carrierservice()
        {
            Batchings = new HashSet<Batching>();
            Integrationcarriermappings = new HashSet<Integrationcarriermapping>();
            Manifestpackages = new HashSet<Manifestpackage>();
            Manifests = new HashSet<Manifest>();
            Ordersshipments = new HashSet<Ordersshipment>();
        }

        public int Shipviaid { get; set; }
        public string Shipvianame { get; set; } = null!;
        public bool? Isactive { get; set; }
        public short? Shippriority { get; set; }
        public int Clientid { get; set; }
        public string? Accountno { get; set; }
        public bool Isthirdparty { get; set; }
        public int Carrierid { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual Whclient Client { get; set; } = null!;
        public virtual ICollection<Batching> Batchings { get; set; }
        public virtual ICollection<Integrationcarriermapping> Integrationcarriermappings { get; set; }
        public virtual ICollection<Manifestpackage> Manifestpackages { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<Ordersshipment> Ordersshipments { get; set; }
    }
}
