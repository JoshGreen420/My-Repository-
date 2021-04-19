using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                double cost = 0.0;
                Console.Write("Enter How Far You Are Wanting To Go: ");
                double distance = Convert.ToDouble(Console.ReadLine());
                Console.Write("How Many Passengers Are There?: ");
                int passengers = Convert.ToInt32(Console.ReadLine());
                while (true) {
                    if (distance == 1)
                    {
                       cost = 3.0;                 
                        break;
                    }
                    else if (distance > 1)
                    {
                        cost = 3 + (distance * 2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }                   
                }
                if (passengers >= 5)
                {
                    cost = cost * 1.5;
                }
                else if (passengers <= 4)
                {                  
                }
                else
                {
                    Console.WriteLine("Invalid Input \n");
                }
                Console.Write("Your Total Comes To: £" + cost+"\n");
                Console.Write("Do You Want To Use This Program Again?(y/n): ");
                string answer = Convert.ToString(Console.ReadLine());
                if (answer == "y")
                {
                    continue;
                }
                else if (answer == "n")
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Input\n");
                }
            }
            Console.ReadKey();
        }
    }
}
