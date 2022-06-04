using System;
namespace HelloSoftUni
{
    class Program
    {
        static void Main()
        {
            // Input
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            //Act
            int hours = numberOfProjects * 3;
            //Output
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {numberOfProjects} project/s.");
        }

    }
}
