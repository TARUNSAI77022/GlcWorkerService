using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skulotcode
    {
        public int Uniqueid { get; set; }
        public string Ponumber { get; set; } = null!;
        public string Lotcode { get; set; } = null!;
        public DateTime Lotcodeexpdate { get; set; }
        public DateTime Entrydate { get; set; }
        public int Quantity { get; set; }
        public int Skuid { get; set; }
        public int Availqty { get; set; }
        public int Penqty { get; set; }
        public DateTime Podate { get; set; }
        public int Clientid { get; set; }
        public int Poqty { get; set; }
        public int Pouniqueid { get; set; }
        public bool? Islotcodeactive { get; set; }
    }
}
