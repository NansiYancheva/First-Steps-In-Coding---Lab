using System;
namespace RectangleArea
{
    class Program
    {
        static void Main()
        {
            //Input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //Action
            int rectangleArea = a * b;
            //Output
            Console.WriteLine(rectangleArea);
        }

    }
}
