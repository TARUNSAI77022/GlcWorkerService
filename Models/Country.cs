using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Country
    {
        public Country()
        {
            Skus = new HashSet<Sku>();
        }

        public string? Country1 { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Sku> Skus { get; set; }
    }
}
