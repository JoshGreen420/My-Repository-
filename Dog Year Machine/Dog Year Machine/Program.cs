using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Year_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstYear = 15;
            int secondYear = 10;
            int thirdYear = 7;
            int dogAge = 0;
            Console.WriteLine("/////////////////////////");
            Console.WriteLine("///THE DOG AGE MACHINE///");
            Console.WriteLine("/////////////////////////");

            Console.Write("HOW OLD IS DOG?: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            if (year == 1)
            {
                dogAge = firstYear;
                Console.WriteLine("DOG IS " + dogAge);
            }
            else if (year == 2)
            {
                dogAge = firstYear + secondYear;
                Console.WriteLine("DOG IS " + dogAge);
            }
            else if (year == 3)
            {
                dogAge = firstYear + secondYear + thirdYear;
                Console.WriteLine("DOG IS " + dogAge);
            }
            else
            {
                dogAge = firstYear + secondYear + (thirdYear * (year - 2));
                Console.WriteLine("DOG IS " + dogAge);
            }
            Console.ReadKey();
        }
    }
}
