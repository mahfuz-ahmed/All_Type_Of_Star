

namespace StarPatterns
{
    internal class SquareStarPattern
    {
        int value = 9;
        public void SquareStar()
        {
            Console.WriteLine("Square Star Pattern");
            Console.WriteLine();
            //Created Row
            for (int i = 1; i <= value; i++)
            {
                //Created Column
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void SquareNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Square Number Pattern");
            //Created Row
            for (int i = 1; i <= value; i++)
            {
                //Created Column
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }
}
