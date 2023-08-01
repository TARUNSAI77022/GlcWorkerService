using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WorkerService1.NewFolder
{
    public class ResponseClass
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; } = null!;
        public IList Data { get; set; } = null!;

        public int b24 { get; set; }
        public int a24 { get; set; }
        public int sTotal { get; set; }
        public string percentage { get; set; }
        public List<PieChart> skupiecharts { get; set; } = null!;
        public List<string> labels { get; set; } = null!;
    }

    public class Result
    {
        public int responsecode { get; set; }
        public string responsemessage { get; set; } = null!;
        public int Data { get; set; }
        public string sData { get; set; }
        public string name { get; set; }
    }

    public class ResponseResult
    {
        public List<Result> ResponseDatas { get; set; }
    }
    public class PieChart
    {
        public int value { get; set; }
        public string name { get; set; }
    }
}
