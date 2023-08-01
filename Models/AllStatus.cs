using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class AllStatus
    {
        public AllStatus()
        {
            Skuinventorylocationlogs = new HashSet<Skuinventorylocationlog>();
        }

        public int Uniqueid { get; set; }
        public string StatusName { get; set; } = null!;
        public bool? IsActive { get; set; }
        public int StatusSequence { get; set; }
        public string StatusFor { get; set; } = null!;
        public int? StatusCode { get; set; }
        public string? Email { get; set; }
        public string? Values { get; set; }
        public string? Statustype { get; set; }

        public virtual ICollection<Skuinventorylocationlog> Skuinventorylocationlogs { get; set; }
    }
}
