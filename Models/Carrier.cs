using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Carrier
    {
        public Carrier()
        {
            Carrierservices = new HashSet<Carrierservice>();
            Carriertypes = new HashSet<Carriertype>();
            Clientshipmethods = new HashSet<Clientshipmethod>();
            Manifests = new HashSet<Manifest>();
        }

        public int Carrierid { get; set; }
        public string Carriername { get; set; } = null!;
        public bool? Isactive { get; set; }
        public string? Urltrackprefix { get; set; }
        public string? Urltrackpostfix { get; set; }
        public int? Intgrationtypeid { get; set; }

        public virtual Integrationtype? Intgrationtype { get; set; }
        public virtual ICollection<Carrierservice> Carrierservices { get; set; }
        public virtual ICollection<Carriertype> Carriertypes { get; set; }
        public virtual ICollection<Clientshipmethod> Clientshipmethods { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
    }
}
