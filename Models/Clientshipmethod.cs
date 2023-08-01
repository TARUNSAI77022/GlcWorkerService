using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Clientshipmethod
    {
        public int Uniqueid { get; set; }
        public int Carrierid { get; set; }
        public string Accounttype { get; set; } = null!;
        public bool Usemai { get; set; }
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Postalcode { get; set; } = null!;
        public bool Useclientlogoonlabel { get; set; }
        public string Carrierref1 { get; set; } = null!;
        public string Carrierref2 { get; set; } = null!;
        public string? Carrierref3 { get; set; }
        public string? Carrierref4 { get; set; }
        public string? Carrierref5 { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public int Clientid { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }
        public string? Accountnumber { get; set; }
        public string? Accountname { get; set; }
        public string? Ordertype { get; set; }
        public int? Integrationchannelid { get; set; }
        public bool? Defaultaccount { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Integrationchannel? Integrationchannel { get; set; }
        public virtual Whuser Modifieduser { get; set; } = null!;
    }
}
