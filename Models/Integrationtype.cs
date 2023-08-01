using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Integrationtype
    {
        public Integrationtype()
        {
            Carriers = new HashSet<Carrier>();
            Integrationcarriermappings = new HashSet<Integrationcarriermapping>();
            Integrationchannels = new HashSet<Integrationchannel>();
            Integrationproperties = new HashSet<Integrationproperty>();
            Ordererrorlogs = new HashSet<Ordererrorlog>();
            Properties = new HashSet<Property>();
        }

        public int Uniqueid { get; set; }
        public string Integrationname { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateTime Entrydate { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<Carrier> Carriers { get; set; }
        public virtual ICollection<Integrationcarriermapping> Integrationcarriermappings { get; set; }
        public virtual ICollection<Integrationchannel> Integrationchannels { get; set; }
        public virtual ICollection<Integrationproperty> Integrationproperties { get; set; }
        public virtual ICollection<Ordererrorlog> Ordererrorlogs { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
