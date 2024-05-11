using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class Hollow_RhombuStar
    {
        
        public void Star()
        {
            Console.WriteLine("Hollow RhombusStar");
            Console.WriteLine();

            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n-1; j>=i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k<=n ; k++)
                {
                    if (k == 1 || k==n || i== 1 || i == n )
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

            Console.WriteLine("Hollow Mirrored RhombusStar");
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k< i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=n; j++)
                {
                    if(j==1|| j== n || i==1 || i == n)
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
