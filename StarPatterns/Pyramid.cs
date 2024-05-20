using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Pyramid
    {
        public void Star()
        {
            Console.WriteLine("Pyramid");
            Console.WriteLine();

            int n = 10;

            int m = n;


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= m - 1; j++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m--;

            //    Console.WriteLine();
            //}

            for (int i = 0; i <= n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                }

                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
