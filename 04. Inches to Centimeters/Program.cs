using System;
namespace InchesToCentimeters
{
    class Program
    {
        static void Main()
        {
            // Input
            double inch = double.Parse(Console.ReadLine());
            // Act
            double centimetres = inch * 2.54;
            // Output
            Console.WriteLine(centimetres);
        }

    }
}
