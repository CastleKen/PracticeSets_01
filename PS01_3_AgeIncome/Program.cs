using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age, Income;

            if (Age >= 25 && Age <= 35 && Income > 50,000)
            {
                Console.WriteLine("Young Professional");
            }
            else if (Age >= 36 && Age <= 55 && Income > 70,000)
            {
                Console.WriteLine("Middle-Aged Professional")
            }
            else if (Age >= 56 && Income < 30,000)
            {
                Console.WriteLine("Senior Citizen");
            }
            else
            {
                Console.WriteLine("Other")
            }
        }
    }
}
