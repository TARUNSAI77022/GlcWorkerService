using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Skushippingbox
    {
        public Skushippingbox()
        {
            Skupackages = new HashSet<Skupackage>();
        }

        public int Uniqueid { get; set; }
        public string Shippingbox { get; set; } = null!;
        public bool? Isactive { get; set; }
        public DateTime Entrydate { get; set; }

        public virtual ICollection<Skupackage> Skupackages { get; set; }
    }
}
