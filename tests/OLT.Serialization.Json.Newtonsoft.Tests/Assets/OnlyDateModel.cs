using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OLT.Serialization.Json.Newtonsoft.Tests
{
    public class OnlyDateModel
    {
        [JsonConverter(typeof(OltOnlyDateConverter))]
        public DateTime BirthDate { get; set; }
    }
}
