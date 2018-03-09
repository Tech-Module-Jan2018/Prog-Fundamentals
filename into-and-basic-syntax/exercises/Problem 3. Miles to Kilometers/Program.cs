using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we receive miles as a double
            double miles = double.Parse(Console.ReadLine());
            //One mile has 1.60934 kilometers
            double mileToKm = 1.60934;
            //TODO
            Console.WriteLine($"{miles*mileToKm:f2}");
        }
    }
}
