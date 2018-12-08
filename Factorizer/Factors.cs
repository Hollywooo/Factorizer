using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    class Factors
    {
        long inputInt = new long();
        List<long> factorList = new List<long>();

        public static Factors Factorize(long input)
        {
            Factors factorThis = new Factors();
            factorThis.inputInt = input;

            long currentValue = factorThis.inputInt;
            double value = factorThis.inputInt;            
            long sqrMark = Convert.ToInt64(Math.Round(Math.Sqrt(value), 0, MidpointRounding.AwayFromZero));
            int iter = 2;

            while (iter <= sqrMark)
            {
                if (currentValue % iter == 0)
                {
                    currentValue = currentValue / iter;
                    factorThis.factorList.Add(iter);
                }

                else
                {
                    iter++;
                }
            }

            if (currentValue >= iter)
            {
                factorThis.factorList.Add(currentValue);
            }
            else { }

            return factorThis;
        }

        public static void FactorOutput(Factors factoredInput)
        {
            Factors solvedFactor = factoredInput;
            string factorListString = null;
            factorListString = "The prime factorization of " + solvedFactor.inputInt + " is: [";

            foreach (var item in solvedFactor.factorList)
            {
                factorListString = factorListString + item.ToString() + ", ";
            }

            factorListString = factorListString + "].";

            Console.WriteLine(factorListString);
        }
    }
}
