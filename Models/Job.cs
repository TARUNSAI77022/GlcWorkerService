using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Job
    {
        public int Uniqueid { get; set; }
        public int Cartid { get; set; }
        public int? Entryuserid { get; set; }
        public DateTime? Entrydate { get; set; }
        public int? Modifieduserid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string? Status { get; set; }

        public virtual CartInfo Cart { get; set; } = null!;
    }
}
