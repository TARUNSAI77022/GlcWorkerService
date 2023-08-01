using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whusermodule
    {
        public int Uniqueid { get; set; }
        public int Userid { get; set; }
        public int Moduleid { get; set; }
        public bool? Isactive { get; set; }
        public DateOnly Createddate { get; set; }
        public int Createduserid { get; set; }
        public DateOnly? Modifieddate { get; set; }
        public int Modifieduserid { get; set; }
        public bool? Accesslevel { get; set; }

        public virtual Whuser Createduser { get; set; } = null!;
        public virtual Whuser Modifieduser { get; set; } = null!;
        public virtual Whmodule Module { get; set; } = null!;
        public virtual Whuser User { get; set; } = null!;
    }
}
