using EntityLab_3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a float value: ");
            float userInput = float.Parse(Console.ReadLine());

            Console.WriteLine(Helper.ReturnFloat(userInput));
            Console.ReadLine();

        }
    }
}
