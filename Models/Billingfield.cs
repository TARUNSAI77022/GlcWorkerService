using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Billingfield
    {
        public int Uniqueid { get; set; }
        public int Clientid { get; set; }
        public string Ordertype { get; set; } = null!;
        public string Billingcode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Cost { get; set; }
        public string Packagetype { get; set; } = null!;
        public bool Status { get; set; }
        public DateTime Createddate { get; set; }
        public string Billingtype { get; set; } = null!;
        public int Entryuserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public int Modifieduserid { get; set; }

        public virtual Whclient Client { get; set; } = null!;
    }
}
