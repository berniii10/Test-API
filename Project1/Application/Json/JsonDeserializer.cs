using Newtonsoft.Json;
using Project1.Application.TmbDataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Json
{
    static public class JsonDeserializer
    {
        static public TmbData Deserialize(string myJsonResponse)
        {
            return JsonConvert.DeserializeObject<TmbData>(myJsonResponse);
        }
    }
}
