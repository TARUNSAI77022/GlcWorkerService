using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Fileupload
    {
        public int Uniqueid { get; set; }
        public string Filename { get; set; } = null!;
        public DateTime Entrydate { get; set; }
        public int Userid { get; set; }
        public int Statuscode { get; set; }
        public int Transactionid { get; set; }
        public int? Orderid { get; set; }
        public int? Manifestid { get; set; }
        public string? Purpose { get; set; }
    }
}
