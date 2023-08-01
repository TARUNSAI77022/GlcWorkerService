using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Integrationcarriermapping
    {
        public int Uniqueid { get; set; }
        public int Shipviaid { get; set; }
        public int Clientid { get; set; }
        public int Integrationid { get; set; }
        public string Mapping { get; set; } = null!;
        public DateTime Entrydate { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Integrationtype Integration { get; set; } = null!;
        public virtual Carrierservice Shipvia { get; set; } = null!;
    }
}
