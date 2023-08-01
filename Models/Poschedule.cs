using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Poschedule
    {
        public int Id { get; set; }
        public string Ponumber { get; set; } = null!;
        public int Customerid { get; set; }
        public string Customername { get; set; } = null!;
        public int Warehouseid { get; set; }
        public int Carrierid { get; set; }
        public int Carriertypeid { get; set; }
        public DateOnly Createddate { get; set; }
        public DateOnly Schdate { get; set; }
        public TimeOnly Schtime { get; set; }
        public string Status { get; set; } = null!;
        public string? Waittime { get; set; }
        public string? Comments { get; set; }
        public int? Noofpallets { get; set; }
        public int? Noofboxes { get; set; }
        public int Createduserid { get; set; }
        public bool Isrescheduled { get; set; }
        public DateOnly? Lastmodifieddate { get; set; }
        public TimeOnly? Lastmodifiedtime { get; set; }
        public TimeOnly Createddatetime { get; set; }
        public int? Noofpacketsused { get; set; }
        public TimeOnly? Starttime { get; set; }
        public TimeOnly? Endtime { get; set; }
    }
}
