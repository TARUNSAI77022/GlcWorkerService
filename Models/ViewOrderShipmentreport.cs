using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class ViewOrderShipmentreport
    {
        public int? Clientid { get; set; }
        public int? Orderid { get; set; }
        public int? Customerid { get; set; }
        public DateTime? Orderdate { get; set; }
        public string? Customername { get; set; }
        public string? Companyname { get; set; }
        public string? Orderstatus { get; set; }
        public string? Trackingnumber { get; set; }
        public DateTime? Shipdate { get; set; }
        public decimal? Cost { get; set; }
        public int? Skuid { get; set; }
        public string? Sku { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
