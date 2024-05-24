using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Plus_Star
    {
        public void Star()
        {
            Console.WriteLine("Plus_Star");
            Console.WriteLine();

            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    if (i == n)
                    {
                        Console.Write('+');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == 1)
                    {
                        Console.Write("+");
                    }

                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = n; j >= i; j--)
                {

                    if (j == n)
                    {
                        Console.Write("+");
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
