﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Hollow_Right_Triangle
    {
        public void Star()
        {
            Console.WriteLine("Hollow_Right_Triangle_Star");
            Console.WriteLine();

            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i==n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
               Console.WriteLine();
            }

            Console.WriteLine("Hollow_Mirrored_Right_Triangle_Star");
            Console.WriteLine();

            for (int i = 1; i <=n; i++)
            {
                for (int j = n; j >=i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1;k <=i; k++)
                {
                    if(k == 1 || k == i || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
