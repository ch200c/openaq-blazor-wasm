using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace openaq_blazor_wasm
{
    namespace OpenAQ
    {
        public class Measurement
        {
            public string Parameter { get; set; }
            public double Value { get; set; }
            public DateTime LastUpdated { get; set; }
            public string Unit { get; set; }
            public string SourceName { get; set; }
            public AveragingPeriod AveragingPeriod { get; set; }
        }
    }
}
