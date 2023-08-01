using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Ordererrorlog
    {
        public int Id { get; set; }
        public int? Orderid { get; set; }
        public string? Customerorderid { get; set; }
        public int? Clientid { get; set; }
        public int? Ordersource { get; set; }
        public string? Process { get; set; }
        public string? Error { get; set; }
        public DateTime Entrydate { get; set; }

        public virtual Whclient? Client { get; set; }
        public virtual Integrationtype? OrdersourceNavigation { get; set; }
    }
}
