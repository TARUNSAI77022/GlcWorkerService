using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Roreceivingdetail
    {
        public Roreceivingdetail()
        {
            OrderskuSerials = new HashSet<OrderskuSerial>();
            Roreceivinghistories = new HashSet<Roreceivinghistory>();
        }

        public int Skuid { get; set; }
        public DateTime? Receiveddate { get; set; }
        public string? Ponumber { get; set; }
        public DateTime? Podate { get; set; }
        public short? Poloaded { get; set; }
        public int? Badqty { get; set; }
        public int Poquantity { get; set; }
        public string? Iteminternalid { get; set; }
        public short? Recexists { get; set; }
        public string? Removeline { get; set; }
        public string? Trcvid { get; set; }
        public int? Rcvcnt { get; set; }
        public int? Penqty { get; set; }
        public int? Prevrcdqty { get; set; }
        public DateTime? Expecteddate { get; set; }
        public string? Pofilename { get; set; }
        public int Qcdone { get; set; }
        public int Qcqty { get; set; }
        public int Qcid { get; set; }
        public int Uniqueid { get; set; }
        public int Pouid { get; set; }
        public int? Varianceid { get; set; }
        public int Varianceqty { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }

        public virtual Roreceiving Pou { get; set; } = null!;
        public virtual ICollection<OrderskuSerial> OrderskuSerials { get; set; }
        public virtual ICollection<Roreceivinghistory> Roreceivinghistories { get; set; }
    }
}
