using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive the product name -> a string
            string name = Console.ReadLine();
            /* In the next lines, we receive volume, energy and sugar content,
             as and integer*/
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            //TODO
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{volume/100.0*energyContent}kcal, {volume / 100.0 * sugarContent}g sugars");
        }
    }
}
