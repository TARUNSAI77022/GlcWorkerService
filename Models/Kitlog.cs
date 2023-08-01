using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Kitlog
    {
        public int Orderid { get; set; }
        public int Noofkitscomplete { get; set; }
        public int Noofpeoples { get; set; }
        public int Noofhours { get; set; }
        public DateTime Entrydate { get; set; }
        public int Kid { get; set; }
    }
}
