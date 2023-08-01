using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Integrationmapping
    {
        public int Uniqueid { get; set; }
        public string Customtype { get; set; } = null!;
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public int Channelid { get; set; }

        public virtual Integrationchannel Channel { get; set; } = null!;
    }
}
