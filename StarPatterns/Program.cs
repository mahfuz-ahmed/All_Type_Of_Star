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
        
        Hollow_Squre_Pattern hollow_Squre = new Hollow_Squre_Pattern();
        hollow_Squre.Star();

        Pyramid pyramid = new Pyramid();
        pyramid.Star();

        Hollow_Pyramid_Star hollow_Pyramid_ = new Hollow_Pyramid_Star();
        hollow_Pyramid_.Star();

        Inverted_Pyramid_Star inverted_Pyramid_Star = new Inverted_Pyramid_Star();
        inverted_Pyramid_Star.Star();

        Left_Arrow_Star left_Arrow_Star = new Left_Arrow_Star();
        left_Arrow_Star.Star();

        Half_Diamond half_Diamond = new Half_Diamond();
        half_Diamond.Star();

        Plus_Star plus_Star = new Plus_Star();
        plus_Star.Star();

        X_Star x_Star = new X_Star();
        x_Star.Star();

        Console.ReadKey();
    }
}