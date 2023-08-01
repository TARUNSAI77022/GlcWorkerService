using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class State
    {
        public int Id { get; set; }
        public string State1 { get; set; } = null!;
        public string? Statename { get; set; }
        public string? Country { get; set; }
    }
}
