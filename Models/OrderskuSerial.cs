using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class OrderskuSerial
    {
        public int Uniqueid { get; set; }
        public int? Orderid { get; set; }
        public int Skuid { get; set; }
        public string Serialno { get; set; } = null!;
        public DateTime Receiveddate { get; set; }
        public DateTime? Allocateddate { get; set; }
        public int? Rodetailedid { get; set; }

        public virtual Roreceivingdetail? Rodetailed { get; set; }
    }
}
