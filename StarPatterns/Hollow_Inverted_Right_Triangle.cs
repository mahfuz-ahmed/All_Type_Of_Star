using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Hollow_Inverted_Right_Triangle
    {
        public void Start()
        {
            Console.WriteLine("Hollow_Inverted_Right_Triangle");
            Console.WriteLine();
            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    //if (j == i || i==1 ) // Must Clear to index start
                    if (j == n || j == i || i == 1)
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
