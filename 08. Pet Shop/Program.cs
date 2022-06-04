using System;
namespace PetShop
{
    class Program
    {
        static void Main()
        {
            //Input
            int foodForDogs = int.Parse(Console.ReadLine());
            int foodForCats = int.Parse(Console.ReadLine());
            //Action
            double priceForDogs = foodForDogs * 2.50;
            double priceForCats = foodForCats * 4.00;
            double totalPrice = priceForCats + priceForDogs;
            //Output
            Console.WriteLine($"{totalPrice} lv.");
        }

    }
}
