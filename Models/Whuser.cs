using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whuser
    {
        public Whuser()
        {
            Carriertypes = new HashSet<Carriertype>();
            Clientcartonsizes = new HashSet<Clientcartonsize>();
            ClientshipmethodEntryusers = new HashSet<Clientshipmethod>();
            ClientshipmethodModifiedusers = new HashSet<Clientshipmethod>();
            CyclecountEntryusers = new HashSet<Cyclecount>();
            CyclecountModifiedusers = new HashSet<Cyclecount>();
            Cyclecounthistories = new HashSet<Cyclecounthistory>();
            CyclecounttrackingEntryusers = new HashSet<Cyclecounttracking>();
            CyclecounttrackingModifiedusers = new HashSet<Cyclecounttracking>();
            Gridfilters = new HashSet<Gridfilter>();
            IntegrationchannelEntryusers = new HashSet<Integrationchannel>();
            IntegrationchannelModifiedusers = new HashSet<Integrationchannel>();
            OrderEntryusers = new HashSet<Order>();
            OrderModifiedusers = new HashSet<Order>();
            OrderitemshistoryPickedusers = new HashSet<Orderitemshistory>();
            OrderitemshistoryQcusers = new HashSet<Orderitemshistory>();
            Orderprocessjobs = new HashSet<Orderprocessjob>();
            Ordershipaddresslogs = new HashSet<Ordershipaddresslog>();
            OrdersjobEntryusers = new HashSet<Ordersjob>();
            OrdersjobModifiedusers = new HashSet<Ordersjob>();
            Ordersjobitems = new HashSet<Ordersjobitem>();
            RobillingEntryusers = new HashSet<Robilling>();
            RobillingModifiedusers = new HashSet<Robilling>();
            RoreceivingCompletedusers = new HashSet<Roreceiving>();
            RoreceivingEntryusers = new HashSet<Roreceiving>();
            RoreceivinghistoryEntryusers = new HashSet<Roreceivinghistory>();
            RoreceivinghistoryModifiedusers = new HashSet<Roreceivinghistory>();
            SkuEntryusers = new HashSet<Sku>();
            SkuModifiedusers = new HashSet<Sku>();
            SkuautofillEntryusers = new HashSet<Skuautofill>();
            SkuautofillModifiedusers = new HashSet<Skuautofill>();
            SkubarcodeEntryusers = new HashSet<Skubarcode>();
            SkubarcodeModifiedusers = new HashSet<Skubarcode>();
            SkuinventorylocationEntryusers = new HashSet<Skuinventorylocation>();
            SkuinventorylocationModifiedusers = new HashSet<Skuinventorylocation>();
            SkukitmappingEntryusers = new HashSet<Skukitmapping>();
            SkukitmappingModifiedusers = new HashSet<Skukitmapping>();
            SkupackageEntryusers = new HashSet<Skupackage>();
            SkupackageModifiedusers = new HashSet<Skupackage>();
            Warehouses = new HashSet<Warehouse>();
            WhclientEntryusers = new HashSet<Whclient>();
            WhclientModifiedusers = new HashSet<Whclient>();
            WhlocationEntryusers = new HashSet<Whlocation>();
            WhlocationModifiedusers = new HashSet<Whlocation>();
            WhuserclientCreatedusers = new HashSet<Whuserclient>();
            WhuserclientModifiedusers = new HashSet<Whuserclient>();
            WhuserclientUsers = new HashSet<Whuserclient>();
            WhusermoduleCreatedusers = new HashSet<Whusermodule>();
            WhusermoduleModifiedusers = new HashSet<Whusermodule>();
            WhusermoduleUsers = new HashSet<Whusermodule>();
            Whuserrefreshtokens = new HashSet<Whuserrefreshtoken>();
            WhuserwarehouseCreatedusers = new HashSet<Whuserwarehouse>();
            WhuserwarehouseModifiedusers = new HashSet<Whuserwarehouse>();
            WhuserwarehouseUsers = new HashSet<Whuserwarehouse>();
        }

        public int Uniqueid { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Modifieduserid { get; set; }
        public string? Title { get; set; }
        public string? Empid { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Picture { get; set; }
        public string? Usertype { get; set; }
        public bool Allclientsaccess { get; set; }
        public bool Allmodulesaccess { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Companyname { get; set; }
        public byte[]? Photo { get; set; }
        public string Timezone { get; set; } = null!;
        public string? Refreshtoken { get; set; }
        public DateTime? Refreshtokenexpirytime { get; set; }
        public bool Allwarehousesaccess { get; set; }

        public virtual ICollection<Carriertype> Carriertypes { get; set; }
        public virtual ICollection<Clientcartonsize> Clientcartonsizes { get; set; }
        public virtual ICollection<Clientshipmethod> ClientshipmethodEntryusers { get; set; }
        public virtual ICollection<Clientshipmethod> ClientshipmethodModifiedusers { get; set; }
        public virtual ICollection<Cyclecount> CyclecountEntryusers { get; set; }
        public virtual ICollection<Cyclecount> CyclecountModifiedusers { get; set; }
        public virtual ICollection<Cyclecounthistory> Cyclecounthistories { get; set; }
        public virtual ICollection<Cyclecounttracking> CyclecounttrackingEntryusers { get; set; }
        public virtual ICollection<Cyclecounttracking> CyclecounttrackingModifiedusers { get; set; }
        public virtual ICollection<Gridfilter> Gridfilters { get; set; }
        public virtual ICollection<Integrationchannel> IntegrationchannelEntryusers { get; set; }
        public virtual ICollection<Integrationchannel> IntegrationchannelModifiedusers { get; set; }
        public virtual ICollection<Order> OrderEntryusers { get; set; }
        public virtual ICollection<Order> OrderModifiedusers { get; set; }
        public virtual ICollection<Orderitemshistory> OrderitemshistoryPickedusers { get; set; }
        public virtual ICollection<Orderitemshistory> OrderitemshistoryQcusers { get; set; }
        public virtual ICollection<Orderprocessjob> Orderprocessjobs { get; set; }
        public virtual ICollection<Ordershipaddresslog> Ordershipaddresslogs { get; set; }
        public virtual ICollection<Ordersjob> OrdersjobEntryusers { get; set; }
        public virtual ICollection<Ordersjob> OrdersjobModifiedusers { get; set; }
        public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; }
        public virtual ICollection<Robilling> RobillingEntryusers { get; set; }
        public virtual ICollection<Robilling> RobillingModifiedusers { get; set; }
        public virtual ICollection<Roreceiving> RoreceivingCompletedusers { get; set; }
        public virtual ICollection<Roreceiving> RoreceivingEntryusers { get; set; }
        public virtual ICollection<Roreceivinghistory> RoreceivinghistoryEntryusers { get; set; }
        public virtual ICollection<Roreceivinghistory> RoreceivinghistoryModifiedusers { get; set; }
        public virtual ICollection<Sku> SkuEntryusers { get; set; }
        public virtual ICollection<Sku> SkuModifiedusers { get; set; }
        public virtual ICollection<Skuautofill> SkuautofillEntryusers { get; set; }
        public virtual ICollection<Skuautofill> SkuautofillModifiedusers { get; set; }
        public virtual ICollection<Skubarcode> SkubarcodeEntryusers { get; set; }
        public virtual ICollection<Skubarcode> SkubarcodeModifiedusers { get; set; }
        public virtual ICollection<Skuinventorylocation> SkuinventorylocationEntryusers { get; set; }
        public virtual ICollection<Skuinventorylocation> SkuinventorylocationModifiedusers { get; set; }
        public virtual ICollection<Skukitmapping> SkukitmappingEntryusers { get; set; }
        public virtual ICollection<Skukitmapping> SkukitmappingModifiedusers { get; set; }
        public virtual ICollection<Skupackage> SkupackageEntryusers { get; set; }
        public virtual ICollection<Skupackage> SkupackageModifiedusers { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Whclient> WhclientEntryusers { get; set; }
        public virtual ICollection<Whclient> WhclientModifiedusers { get; set; }
        public virtual ICollection<Whlocation> WhlocationEntryusers { get; set; }
        public virtual ICollection<Whlocation> WhlocationModifiedusers { get; set; }
        public virtual ICollection<Whuserclient> WhuserclientCreatedusers { get; set; }
        public virtual ICollection<Whuserclient> WhuserclientModifiedusers { get; set; }
        public virtual ICollection<Whuserclient> WhuserclientUsers { get; set; }
        public virtual ICollection<Whusermodule> WhusermoduleCreatedusers { get; set; }
        public virtual ICollection<Whusermodule> WhusermoduleModifiedusers { get; set; }
        public virtual ICollection<Whusermodule> WhusermoduleUsers { get; set; }
        public virtual ICollection<Whuserrefreshtoken> Whuserrefreshtokens { get; set; }
        public virtual ICollection<Whuserwarehouse> WhuserwarehouseCreatedusers { get; set; }
        public virtual ICollection<Whuserwarehouse> WhuserwarehouseModifiedusers { get; set; }
        public virtual ICollection<Whuserwarehouse> WhuserwarehouseUsers { get; set; }
    }
}
