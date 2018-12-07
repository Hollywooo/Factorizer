using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    class Factors
    {
        int inputInt = new int();
        List<int> factorList = new List<int>();

        public static Factors Factorize(int input)
        {
            Factors factorThis = new Factors();
            factorThis.inputInt = input;

            int currentValue = factorThis.inputInt;
            double value = factorThis.inputInt;            
            int sqrMark = Convert.ToInt32(Math.Round(Math.Sqrt(value), 0, MidpointRounding.AwayFromZero));
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

            if (currentValue > iter)
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
