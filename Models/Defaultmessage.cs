using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Defaultmessage
    {
        public int Uniqueid { get; set; }
        public string Title { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool? Status { get; set; }
    }
}
