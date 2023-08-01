using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Rochargecode
    {
        public Rochargecode()
        {
            Robillings = new HashSet<Robilling>();
        }

        public int Uniqueid { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateTime Createddate { get; set; }
        public string Expgroup { get; set; } = null!;
        public string Salesgroup { get; set; } = null!;
        public string Group { get; set; } = null!;
        public string Calc { get; set; } = null!;

        public virtual ICollection<Robilling> Robillings { get; set; }
    }
}
