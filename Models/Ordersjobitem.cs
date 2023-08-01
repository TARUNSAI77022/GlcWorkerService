using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Ordersjobitem
    {
        public int Uniqueid { get; set; }
        public int Jobid { get; set; }
        public int Orderid { get; set; }
        public int Manifestid { get; set; }
        public int Userid { get; set; }
        public int? Cartid { get; set; }
        public string? Totenumber { get; set; }
        public bool Cartstatus { get; set; }

        public virtual CartInfo? Cart { get; set; }
        public virtual Ordersjob Job { get; set; } = null!;
        public virtual Manifest Manifest { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual Whuser User { get; set; } = null!;
    }
}
