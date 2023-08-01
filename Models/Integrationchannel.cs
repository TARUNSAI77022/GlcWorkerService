using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Integrationchannel
    {
        public Integrationchannel()
        {
            Clientshipmethods = new HashSet<Clientshipmethod>();
            Integrationdetails = new HashSet<Integrationdetail>();
            Integrationmappings = new HashSet<Integrationmapping>();
        }

        public int Uniqueid { get; set; }
        public int Clientid { get; set; }
        public int Integrationtypeid { get; set; }
        public string StoreTitle { get; set; } = null!;
        public bool PullOrder { get; set; }
        public bool PullInventory { get; set; }
        public bool PullRodata { get; set; }
        public bool PushTracking { get; set; }
        public bool PushInventory { get; set; }
        public bool PushRodata { get; set; }
        public bool PushReturns { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public int Modifieduserid { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Integrationtype Integrationtype { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual ICollection<Clientshipmethod> Clientshipmethods { get; set; }
        public virtual ICollection<Integrationdetail> Integrationdetails { get; set; }
        public virtual ICollection<Integrationmapping> Integrationmappings { get; set; }
    }
}
