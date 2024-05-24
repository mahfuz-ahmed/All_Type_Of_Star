using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StarPatterns
{
    public class X_Star
    {
        public void Star()
        {
            Console.WriteLine("X_Star");
            Console.WriteLine();

            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {
                       Console.Write("*");
                    }
                    else
                    {
                       Console.Write(" ");
                    }
                }
                for (int j = n;j>= i; j--)
                {
                    Console.Write(' ');
                }

                for (int j = n; j >= i; j--)
                {
                    if(j == i)
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

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    if (j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
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
