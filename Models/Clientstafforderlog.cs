using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Clientstafforderlog
    {
        public int Csid { get; set; }
        public int? Staffid { get; set; }
        public DateTime? Logdatetime { get; set; }
        public int? Status { get; set; }
        public int? Manifestid { get; set; }
        public int? Clientid { get; set; }
    }
}
