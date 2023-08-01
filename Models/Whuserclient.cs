using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whuserclient
    {
        public int Uniqueid { get; set; }
        public int Userid { get; set; }
        public int Clientid { get; set; }
        public bool? Isactive { get; set; }
        public int Createduserid { get; set; }
        public DateTime Createddate { get; set; }
        public int Modifieduserid { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Createduser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Whuser User { get; set; } = null!;
    }
}
