using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whclient
    {
        public Whclient()
        {
            Batchings = new HashSet<Batching>();
            Billingfields = new HashSet<Billingfield>();
            Carrierservices = new HashSet<Carrierservice>();
            Clientcartonsizes = new HashSet<Clientcartonsize>();
            Clientshipmethods = new HashSet<Clientshipmethod>();
            Clienttags = new HashSet<Clienttag>();
            Cyclecounts = new HashSet<Cyclecount>();
            Integrationcarriermappings = new HashSet<Integrationcarriermapping>();
            Integrationchannels = new HashSet<Integrationchannel>();
            Ordererrorlogs = new HashSet<Ordererrorlog>();
            Orderprocessjobs = new HashSet<Orderprocessjob>();
            Orders = new HashSet<Order>();
            Roreceivings = new HashSet<Roreceiving>();
            Skus = new HashSet<Sku>();
            Whuserclients = new HashSet<Whuserclient>();
        }

        public int Whid { get; set; }
        public string Clientname { get; set; } = null!;
        public bool? Isactive { get; set; }
        public int Uniqueid { get; set; }
        public string Contactname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Postalcode { get; set; } = null!;
        public string Contactphone { get; set; } = null!;
        public string Contactemail { get; set; } = null!;
        public string? Billingattn { get; set; }
        public string? Billingaddress1 { get; set; }
        public string? Billingaddress2 { get; set; }
        public string? Billingcity { get; set; }
        public string? Billingstate { get; set; }
        public string? Billingpostalcode { get; set; }
        public string? Billingphone { get; set; }
        public string? Billingemail { get; set; }
        public string? Clientcode { get; set; }
        public string? Alternatecontactphone { get; set; }
        public string? Alternatebillingphone { get; set; }
        public string? Csmname { get; set; }
        public string? Csmemail { get; set; }
        public string? Supervisorname { get; set; }
        public string? Supervisoremail { get; set; }
        public string? Ordercutofftime { get; set; }
        public string? Packaddresstype { get; set; }
        public string? Packaddress { get; set; }
        public string? Packcity { get; set; }
        public string? Packstate { get; set; }
        public string? Packpostalcode { get; set; }
        public bool Allowbackorders { get; set; }
        public bool Printreturnlabel { get; set; }
        public bool Printcarrierlabel { get; set; }
        public bool Ordernotification { get; set; }
        public string? Ordertomail { get; set; }
        public string? Orderbccmail { get; set; }
        public bool Adjustmentsnotification { get; set; }
        public string? Adjustmentstomail { get; set; }
        public string? Adjustmentsbccmail { get; set; }
        public bool Returnsnotification { get; set; }
        public string? Returnstomail { get; set; }
        public string? Returnsbccmail { get; set; }
        public bool Shippingnotification { get; set; }
        public string? Shippingtomail { get; set; }
        public string? Shippingbccmail { get; set; }
        public bool Ronotification { get; set; }
        public string? Rotomail { get; set; }
        public string? Robccmail { get; set; }
        public bool Reordernotification { get; set; }
        public string? Reordertoemail { get; set; }
        public string? Reorderbccemail { get; set; }
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifiedentrydate { get; set; }
        public string? Clientlogo { get; set; }
        public byte[]? Photo { get; set; }
        public bool Invallocateorderlevel { get; set; }
        public bool Foodalgorithm { get; set; }
        public int B2cmindaystoexpire { get; set; }
        public int B2bmindaystoexpire { get; set; }
        public string? Gs1cmpprefix { get; set; }
        public string? Country { get; set; }
        public string? Billcountry { get; set; }
        public string? Templatename { get; set; }
        public bool? Inventoryreport { get; set; }
        public string? Inventoryperiod { get; set; }
        public int Dayofmonth { get; set; }
        public bool Errornotification { get; set; }
        public string? Errortoemail { get; set; }
        public string? Errorbccemail { get; set; }
        public bool Othernotification { get; set; }
        public string? Othertoemail { get; set; }
        public string? Otherbccemail { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Warehouse Wh { get; set; } = null!;
        public virtual ICollection<Batching> Batchings { get; set; }
        public virtual ICollection<Billingfield> Billingfields { get; set; }
        public virtual ICollection<Carrierservice> Carrierservices { get; set; }
        public virtual ICollection<Clientcartonsize> Clientcartonsizes { get; set; }
        public virtual ICollection<Clientshipmethod> Clientshipmethods { get; set; }
        public virtual ICollection<Clienttag> Clienttags { get; set; }
        public virtual ICollection<Cyclecount> Cyclecounts { get; set; }
        public virtual ICollection<Integrationcarriermapping> Integrationcarriermappings { get; set; }
        public virtual ICollection<Integrationchannel> Integrationchannels { get; set; }
        public virtual ICollection<Ordererrorlog> Ordererrorlogs { get; set; }
        public virtual ICollection<Orderprocessjob> Orderprocessjobs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Roreceiving> Roreceivings { get; set; }
        public virtual ICollection<Sku> Skus { get; set; }
        public virtual ICollection<Whuserclient> Whuserclients { get; set; }
    }
}
