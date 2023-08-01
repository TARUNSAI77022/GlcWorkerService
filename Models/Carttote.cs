using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Carttote
    {
        public int Uniqueid { get; set; }
        public string Totename { get; set; } = null!;
        public int Cartid { get; set; }

        public virtual CartInfo Cart { get; set; } = null!;
    }
}
