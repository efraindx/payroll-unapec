using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class SFSCalculator : TransactionCalculator
    {
        private const double FACTOR = 0.0304;

        public double calculate(double salary)
        {
            return salary * FACTOR;
        }
    }
}
