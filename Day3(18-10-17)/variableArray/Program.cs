﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[]{1,3,5,7,9};
            arr[1] = new int[]{2,4,6,8};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0})", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j==(arr[i].Length-1)? "":" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("press any key to exit");
            Console.ReadKey();

        }
    }
}
