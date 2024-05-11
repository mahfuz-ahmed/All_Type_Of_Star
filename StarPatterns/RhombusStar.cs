using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns
{
    public class RhombusStar
    {
        public void Star()
        {
            Console.WriteLine("RhombusStar Pattern");
            Console.WriteLine();

            int n = 7;

            for (int i = 1; i <= n; i++) {

                for (int k = n-1; k >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j =1; j<=n; j++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }

            Console.WriteLine("RhombusStar Mirror Pattern") ;
            Console.WriteLine();

            for (int i = 1;i <= n; i++)
            {
                for (int j = 2;j <= i; j++)
                {
                    Console.Write(' ');
                }
                for(int k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }       
                Console.WriteLine() ;
            }

            //for (int i = 1; i <= 5; i++)
            //{
            //    if(i == 1)
            //    {
            //        for (int j = 1;j<=10; j++)
            //        {
            //            if(j == 1|| j==2 || j == 3){
            //                Console.Write(" ");
            //            }
            //            else
            //            {
            //                Console.Write("*");
            //            }
            //        }    
            //    }
            //    if (i == 2)
            //    {
            //        for (int j = 1; j <= 10; j++)
            //        {
            //            if (j == 1 || j == 2)
            //            {
            //                Console.Write(" ");
            //            }
            //            else if (j == 10)
            //            {
            //                Console.Write(" ");
            //            }
            //            else
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //    }
            //    if(i== 3)
            //    {
            //        for (int j = 1; j <= 10; j++)
            //        {
            //            if (j == 1)
            //            {
            //                Console.Write(" ");
            //            }
            //            else if (j == 10 || j == 9)
            //            {
            //                Console.Write(" ");
            //            }
            //            else
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //    }
            //    if (i==4)
            //    {
                    
            //        for (int j = 1; j <= 10; j++)
            //        {
            //            if (j == 10 || j == 9 || j == 8)
            //            {
            //                Console.Write(" ");
            //            }
            //            else { Console.Write("*"); }                     
            //        }
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
