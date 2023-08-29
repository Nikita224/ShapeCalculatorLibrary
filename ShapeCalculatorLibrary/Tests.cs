using System;

namespace ShapeCalculatorLibrary
{
    public static class Tests
    {
        public static void RunTests()
        {
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);

            double circleArea = circle.CalculateArea();
            Console.WriteLine($"Circle Area: {circleArea}");

            double triangleArea = triangle.CalculateArea();
            Console.WriteLine($"Triangle Area: {triangleArea}");
        }
    }
}