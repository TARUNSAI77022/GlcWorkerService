using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Clientcartonsize
    {
        public int Uniqueid { get; set; }
        public int Clientid { get; set; }
        public string Length { get; set; } = null!;
        public string Width { get; set; } = null!;
        public string Height { get; set; } = null!;
        public int Entryuserid { get; set; }
        public DateTime Entrydate { get; set; }
        public string? Cartontype { get; set; }
        public double? Lbs { get; set; }

        public virtual Whclient Client { get; set; } = null!;
        public virtual Whuser Entryuser { get; set; } = null!;
    }
}
