using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Ordersshipment
    {
        public int Reqshipviaid { get; set; }
        public string Shipcustomername { get; set; } = null!;
        public string? Shipcompanyname { get; set; }
        public string Shipaddress1 { get; set; } = null!;
        public string? Shipaddress2 { get; set; }
        public string? Shipaddress3 { get; set; }
        public string Shipcity { get; set; } = null!;
        public string Shipstate { get; set; } = null!;
        public string Shippostalcode { get; set; } = null!;
        public string Shipcountrycode { get; set; } = null!;
        public string? Shipphone { get; set; }
        public string? Shipemail { get; set; }
        public string? Billcustomername { get; set; }
        public string? Billcompanyname { get; set; }
        public string? Billaddress1 { get; set; }
        public string? Billaddress2 { get; set; }
        public string? Billcity { get; set; }
        public string? Billstate { get; set; }
        public string? Billpostalcode { get; set; }
        public string? Billphone { get; set; }
        public string? Billemail { get; set; }
        public int Uniqueid { get; set; }
        public int Orderid { get; set; }
        public string? _3rdpartyaccno { get; set; }
        public string? Billcountrycode { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Carrierservice Reqshipvia { get; set; } = null!;
    }
}
