using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Services.Calculators
{
    class ISRCalculator : TransactionCalculator
    {
        private const double FIRST_LIMIT = 399923.01;
        private const double SECOND_LIMIT = 599884.01;
        private const double THIRD_LIMIT = 833171.01;

        private const double FIRST_RATE = 29994.00;
        private const double SECOND_RATE = 76652.00;

        private const double FIRST_FACTOR = 0.15;
        private const double SECOND_FACTOR = 0.2;
        private const double THIRD_FACTOR = 0.25;

        public double calculate(double salary)
        {
            double ISR = 0;
            double baseSalary = salary * 12;
            if( baseSalary > FIRST_LIMIT )
            {
                if(baseSalary < SECOND_LIMIT)
                {
                    ISR = (baseSalary - FIRST_LIMIT) * FIRST_FACTOR / 12;
                }
                else if( baseSalary < THIRD_LIMIT)
                {
                    ISR = (FIRST_RATE + (SECOND_FACTOR * (baseSalary - SECOND_LIMIT))) / 12;
                }
                else
                {
                    ISR = (SECOND_RATE + (THIRD_FACTOR * (baseSalary - THIRD_LIMIT))) / 12;
                }
            }

            return ISR;
        }
    }
}
