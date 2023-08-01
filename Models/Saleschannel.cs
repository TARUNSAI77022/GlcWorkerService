using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Saleschannel
    {
        public Saleschannel()
        {
            Skuautofills = new HashSet<Skuautofill>();
        }

        public int Saleschannelid { get; set; }
        public string Saleschannel1 { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateTime Entrydate { get; set; }
        public int? Entryuserid { get; set; }
        public int? Saleschannelcode { get; set; }

        public virtual ICollection<Skuautofill> Skuautofills { get; set; }
    }
}
