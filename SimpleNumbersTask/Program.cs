﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29};
            SimpleNumbers simpleNumbers = new SimpleNumbers(array);

             foreach(var n in simpleNumbers)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
