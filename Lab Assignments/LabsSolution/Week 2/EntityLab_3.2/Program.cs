using EntityLab_3._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number string value: ");
            string userInput = Console.ReadLine();

            Console.WriteLine(StringExtensions.StringToFloat(userInput));
            Console.ReadLine();

        }
    }
}
