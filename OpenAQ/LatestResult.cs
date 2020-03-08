using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace openaq_blazor_wasm
{
    namespace OpenAQ
    {
        public class LatestResult
        {
            public string Location { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public double Distance { get; set; }
            public Measurement[] Measurements { get; set; }
        }
    }
}
