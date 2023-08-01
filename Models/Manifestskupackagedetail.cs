using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Manifestskupackagedetail
    {
        public int Uniqueid { get; set; }
        public int? Packageid { get; set; }
        public int? Skuid { get; set; }
        public int? Quantity { get; set; }

        public virtual Manifestpackage? Package { get; set; }
    }
}
