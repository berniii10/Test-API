using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.TmbDataClasses
{
    public class TmbData
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }
        public int totalFeatures { get; set; }
        public int numberMatched { get; set; }
        public int numberReturned { get; set; }
        public DateTime timeStamp { get; set; }
        public Crs crs { get; set; }
    }
}
