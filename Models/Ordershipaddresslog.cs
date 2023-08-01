using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Ordershipaddresslog
    {
        public int Uniqueid { get; set; }
        public int Orderid { get; set; }
        public int Manifestid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }
        public string? Companyname { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }

        public virtual Whuser Entryuser { get; set; } = null!;
        public virtual Manifest Manifest { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
