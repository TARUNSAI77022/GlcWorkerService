using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Integrationdetail
    {
        public int Uniqueid { get; set; }
        public int Integrationpropertyid { get; set; }
        public string Propertyvalue { get; set; } = null!;
        public int Channelid { get; set; }

        public virtual Integrationchannel Channel { get; set; } = null!;
        public virtual Integrationproperty Integrationproperty { get; set; } = null!;
    }
}
