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
            bool exit = false;
            long maxValue = Convert.ToInt64(1E15);
            while (userDirection != "no")
            {
                Console.WriteLine("Prime Factorization Program: please enter an integer.  ");
                long.TryParse(Console.ReadLine().ToString(), out long userInput);

                if (userInput > maxValue || userInput == 0 )
                {
                    Console.WriteLine("Woah there turbo...let's try something a little less insane.");
                }
                else if (userInput <= maxValue && userInput > 1)
                {
                    Console.WriteLine("Ok let's do this!");

                    Factors.FactorOutput(Factors.Factorize(userInput));
                    Console.WriteLine("\r\n" + "Perform another factorization? yes/no");
                    userDirection = Console.ReadLine().ToString();

                    while (exit != true)
                    {
                        if (userDirection == "yes" || userDirection == "no")
                        {
                            exit = true;
                        }
                        else
                        {
                            exit = false;
                            Console.WriteLine("\r\nI don't understand!  Did you mean 'yes' or 'no'?");
                            userDirection = Console.ReadLine().ToString();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hmmm.  Something was weird about that...try again maybe.");
                }
                
            }

            Console.WriteLine("\r\n" + "Goodbye!");
            Console.ReadKey();
            
            

        }
    }
}
