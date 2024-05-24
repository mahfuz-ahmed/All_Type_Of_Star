using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Left_Arrow_Star
    {
        public void Star()
        {
            Console.WriteLine("Left_Arrow_Star");
            Console.WriteLine();

            int n = 5;

            for (int i = 1; i <=n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Right_Arrow_Star");
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <=n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(' ');
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        }
    }
}
