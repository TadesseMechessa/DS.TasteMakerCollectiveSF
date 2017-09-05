using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull
{
    class TasteMakerDA
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public string BookingStatusType { get; set; }
            public int MonetaryValue { get; set; }
            public int Count { get; set; }
            public float ConversionRate { get; set; }
        }

    }
}
