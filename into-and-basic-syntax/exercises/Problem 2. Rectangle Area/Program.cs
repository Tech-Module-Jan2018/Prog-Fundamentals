using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive width and height
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            //Here we do the formula and printing it on the console
            Console.WriteLine($"{width*height:f2}");
        }
    }
}
