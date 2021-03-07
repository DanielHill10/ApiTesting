using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesting.Models
{
    public class JourneyCalculator
    {
        public string PostCodeOne { get; set; }
        public string PostCodeTwo { get; set; }
        public string DistanceValue { get; set; }
        public string Test { get; set; }

        public void Calculate()
        {
            Test = PostCodeOne + PostCodeTwo;
        }
    }
}
