using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Services.Calculators
{
    class AFPCalculator : TransactionCalculator
    {
        private const double FACTOR = 0.0287;

        public double calculate(double salary)
        {
            return salary * FACTOR;
        }
    }
}
