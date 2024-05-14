﻿
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

        Hollow_Right_Triangle hollow_Right_Triangle = new Hollow_Right_Triangle();
        hollow_Right_Triangle.Star();

        Hollow_Inverted_Right_Triangle hollow_Inverted_Right_Triangle = new Hollow_Inverted_Right_Triangle();
        hollow_Inverted_Right_Triangle.Start();

        Console.ReadKey();
    }
}