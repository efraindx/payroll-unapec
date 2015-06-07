using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class AFPCalculator
    {
        private const double FACTOR = 0.0287;

        public static double getAFP(double salary)
        {
            return salary * FACTOR;
        }
    }
}
