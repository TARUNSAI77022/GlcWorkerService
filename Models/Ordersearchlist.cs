using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Ordersearchlist
    {
        public int Uniqueid { get; set; }
        public string Searchtitle { get; set; } = null!;
        public int Clientid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public string[]? Orderstatus { get; set; }
        public string? Ordertype { get; set; }
        public string? Ordertypetxt { get; set; }
        public string? Shiptotype { get; set; }
        public string? Shiptotext { get; set; }
        public string[]? Skulist { get; set; }
        public int Userid { get; set; }
        public DateTime Entrydate { get; set; }
        public string? Orderprocesstype { get; set; }
        public string[]? Manifeststatus { get; set; }
        public string Searchby { get; set; } = null!;
        public string? Trackingnum { get; set; }
        public string? Manifestid { get; set; }
        public int[]? Carrierid { get; set; }
        public int? Whid { get; set; }
    }
}
