﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());

            double sum=0;

            for (int n = 1; n <= num; n++)
            {
                sum += 1.0 / n;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

