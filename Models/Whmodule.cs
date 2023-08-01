using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Whmodule
    {
        public Whmodule()
        {
            InverseParent = new HashSet<Whmodule>();
            Whusermodules = new HashSet<Whusermodule>();
        }

        public string Modulename { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateOnly Createddate { get; set; }
        public int Uniqueid { get; set; }
        public int? Parentid { get; set; }

        public virtual Whmodule? Parent { get; set; }
        public virtual ICollection<Whmodule> InverseParent { get; set; }
        public virtual ICollection<Whusermodule> Whusermodules { get; set; }
    }
}
