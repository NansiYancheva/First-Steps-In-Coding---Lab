using System;
namespace YardGreening
{
    class Program
    {
        static void Main()
        {
            // Input
            double squareMetres = double.Parse(Console.ReadLine());

            //Action
            double Price = squareMetres * 7.61;
            double discount = 0.18 * Price;
            double finalPrice = Price - discount;
            //Output
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }

    }
}
