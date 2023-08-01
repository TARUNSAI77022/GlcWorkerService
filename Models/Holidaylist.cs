using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Holidaylist
    {
        public int Uniqueid { get; set; }
        public string? Holidayname { get; set; }
        public DateTime? Holidaydate { get; set; }
    }
}
