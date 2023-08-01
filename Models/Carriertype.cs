using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Carriertype
    {
        public int Carriertypeid { get; set; }
        public string Carriertypename { get; set; } = null!;
        public bool? Isactive { get; set; }
        public int Carrierid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
    }
}
