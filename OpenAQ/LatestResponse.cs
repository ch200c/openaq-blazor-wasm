using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace openaq_blazor_wasm
{
    namespace OpenAQ
    {
        public class LatestResponse
        {
            public object Meta { get; set; }
            public LatestResult[] Results { get; set; }
        }
    }
}
