using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Inverted_Pyramid_Star
    {
        public void Star()
        {
            Console.WriteLine();
            Console.WriteLine("Inverted Pyramid Star");
            Console.WriteLine();

            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n; k >=i; k--)
                {
                    Console.Write("*");
                }
                for(int l = n; l >=i; l--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Hollow_Inverted_Pyramid_Star");
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n; k >= i; k--)
                {
                    if (i == 1 || k == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                       Console.Write(" ");
                    }
                }
                for (int l = n; l >= i; l--)
                {

                    if (i == 1|| l == i)
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
