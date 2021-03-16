using System;
using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

namespace HW_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "sos";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
            Console.ReadLine();
        }
    }
}
