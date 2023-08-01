using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Orderprocessjob
    {
        public int Uniqueid { get; set; }
        public int Clientid { get; set; }
        public string[] Executetime { get; set; } = null!;
        public bool? Isactive { get; set; }
        public int? Sourceid { get; set; }
        public int[]? Skuid { get; set; }
        public DateTime Entrydate { get; set; }
        public int Entryuserid { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
    }
}
