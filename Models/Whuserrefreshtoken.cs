using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whuserrefreshtoken
    {
        public int Uniqueid { get; set; }
        public string Refreshtoken { get; set; } = null!;
        public int Userid { get; set; }
        public DateTime Refreshtokenexpirytime { get; set; }

        public virtual Whuser User { get; set; } = null!;
    }
}
