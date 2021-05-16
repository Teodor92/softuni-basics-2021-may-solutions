using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double area = squareSide * squareSide;
                Console.WriteLine($"{area:F3}");
            }
            else if (figureType == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double seocndSide = double.Parse(Console.ReadLine());
                double area = firstSide * seocndSide;
                Console.WriteLine($"{area:F3}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = radius * radius * Math.PI;
                Console.WriteLine($"{area:F3}");
            }
            else if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = side * height / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
