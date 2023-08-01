using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Manifestprintdatum
    {
        public int Uniqueid { get; set; }
        public int? Manifestid { get; set; }
        public string? Printdata { get; set; }
        public DateTime Entrydate { get; set; }
        public string? Requesttype { get; set; }
        public string? Trackingnumber { get; set; }
        public string? Labelid { get; set; }
    }
}
