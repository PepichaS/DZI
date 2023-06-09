﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Масив
            var numbers = new int[] { 9, -9, 8, -8, 7, -7, 6, -6, 5, -5, 4, -4, 3, -3, 2, -2, 1, -1, 0 };

            // Печат
            Console.WriteLine(string.Join(" ", numbers));

            // Разбъркване
            Sort.Shuffle(numbers);

            // Печат
            Console.WriteLine(string.Join(" ", numbers));

            // Сортиране чрез вмъкване = О(N ^ 2))
            Sort.Insertion(numbers);

            // Печат
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
