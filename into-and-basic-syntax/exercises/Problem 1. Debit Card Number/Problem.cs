﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive integeres
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            //TODO
            Console.WriteLine($"{a:d4} {b:d4} {c:d4} {d:d4}");
        }
    }
}
