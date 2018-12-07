using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string userDirection = "yes";
            while (userDirection != "no")
            {
                Console.WriteLine("Prime Factorization Program: please enter an integer.  ");
                int.TryParse(Console.ReadLine().ToString(), out int userInput);

                Factors.FactorOutput(Factors.Factorize(userInput));
                Console.ReadKey();
                Console.WriteLine("\r\n" + "Perform another factorization? yes/no" + "\r\n");
                userDirection = Console.ReadLine().ToString();
            }

            Console.WriteLine("\r\n" + "Goodbye!");
            Console.ReadKey();
            
            

        }
    }
}
