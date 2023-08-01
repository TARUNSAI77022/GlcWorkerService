using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Returnitem
    {
        public int Returnitemid { get; set; }
        public int Returnid { get; set; }
        public int Itemid { get; set; }
        public int Orderqty { get; set; }
        public int Returnqty { get; set; }
        public int Returnreasonid { get; set; }
        public string Returnreason { get; set; } = null!;
        public bool Returntostock { get; set; }
        public int? Stockreturnreasonid { get; set; }
        public string? Stockreturnreason { get; set; }
        public bool Requestedexchange { get; set; }
    }
}
