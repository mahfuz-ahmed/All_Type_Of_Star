using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class RightTriangleStar
    {
        public void Star()
        {

            Console.WriteLine("Right Triangle Star");
            Console.WriteLine();

            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    Console.Write("*");
                }                      
                Console.WriteLine();
            }


            Console.WriteLine("Right Triangle Star");
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
