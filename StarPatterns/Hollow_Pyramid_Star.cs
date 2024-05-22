using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Hollow_Pyramid_Star
    {
        public void Star()
        {
            Console.WriteLine();

            Console.WriteLine("Hollow Pyramid Print");
            Console.WriteLine();

            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                   if(k==1 || i == n)
                    {
                       Console.Write("*");
                    }
                    else
                    {
                       Console.Write(" ");
                    }

                }

                for (int k = 2;k <= i; k++)
                {
                    if(k==i || i == n)
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
        }
    }
}
