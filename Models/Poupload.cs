using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Poupload
    {
        public int Receivingid { get; set; }
        public string? Ponumber { get; set; }
        public string? Sku { get; set; }
        public int? Skuid { get; set; }
        public DateTime? Receiveddate { get; set; }
        public int? Receivedquantity { get; set; }
        public string? Receivedby { get; set; }
        public DateTime? Podate { get; set; }
        public short? Poloaded { get; set; }
        public int? Badqty { get; set; }
        public int? Poquantity { get; set; }
        public string? Damagecode { get; set; }
        public DateTime? Expecteddate { get; set; }
        public short? Recexists { get; set; }
        public int? Totalreceivedqty { get; set; }
        public string? Pofilename { get; set; }
        public string? Errormsg { get; set; }
        public string? Recmoved { get; set; }
    }
}
