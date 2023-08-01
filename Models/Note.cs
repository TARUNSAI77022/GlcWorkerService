using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Note
    {
        public int Uniqueid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Userid { get; set; }
        public string Notes { get; set; } = null!;
        public int Statuscode { get; set; }
        public int Transactionid { get; set; }
        public int? Orderid { get; set; }
    }
}
