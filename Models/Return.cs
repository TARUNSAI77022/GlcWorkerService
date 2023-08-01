using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Return
    {
        public int Returnid { get; set; }
        public string Rmano { get; set; } = null!;
        public int? Orderid { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime Returndate { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postalcode { get; set; }
        public string? Companyname { get; set; }
        public int Userid { get; set; }
        public string? Comments { get; set; }
        public string? Custorderid { get; set; }
    }
}
