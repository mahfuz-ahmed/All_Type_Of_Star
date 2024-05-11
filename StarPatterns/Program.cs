
using StarPatterns;

public class Program
{
    static void Main(string[] args)
    {
        SquareStarPattern squareStarPattern = new SquareStarPattern();
        squareStarPattern.SquareStar();
        squareStarPattern.SquareNumber();

        RhombusStar rhombusStar = new RhombusStar();
        rhombusStar.Star();
        
        Hollow_RhombuStar hollow_RhombuStar = new Hollow_RhombuStar();
        hollow_RhombuStar.Star();

        RightTriangleStar rightTriangleStar = new RightTriangleStar();
        rightTriangleStar.Star();

        Console.ReadKey();
    }
}