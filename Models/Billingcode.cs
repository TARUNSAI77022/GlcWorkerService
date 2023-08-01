using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Billingcode
    {
        public int Uniqueid { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? Status { get; set; }
        public string? Type { get; set; }
        public DateTime Createddate { get; set; }
    }
}
