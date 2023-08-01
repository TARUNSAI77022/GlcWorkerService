using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Gridfilter
    {
        public int Uniqueid { get; set; }
        public int Userid { get; set; }
        public string Page { get; set; } = null!;
        public int Key { get; set; }

        public virtual Whuser User { get; set; } = null!;
    }
}
