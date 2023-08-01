using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Clienttag
    {
        public int Uniqueid { get; set; }
        public int? Clientid { get; set; }
        public string? Tagtype { get; set; }
        public string? Tagname { get; set; }
        public bool? Status { get; set; }

        public virtual Whclient? Client { get; set; }
    }
}
