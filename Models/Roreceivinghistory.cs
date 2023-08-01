using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Roreceivinghistory
    {
        public int Uniqueid { get; set; }
        public int Rodetailsid { get; set; }
        public int Locationid { get; set; }
        public string Lotcode { get; set; } = null!;
        public int Palletid { get; set; }
        public int Recqty { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public DateTime Expdate { get; set; }
        public int Putawayqty { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whlocation Location { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Whlocation Pallet { get; set; } = null!;
        public virtual Roreceivingdetail Rodetails { get; set; } = null!;
    }
}
