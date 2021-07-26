using System;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 3 arrays and fill them with student info. name, fav food, previous title
            string[] name = { "John", "Jacob", "Jingleheimer", "Schmidt" };
            string[] favFood = { "Pizza", "Tacos", "Ramen", "Burgers" };//clearly these r college students
            string[] title = { "Server", "Customer Service Representative", "Gym teacher", "Self-employed" };

            Console.WriteLine("Welcome to our DevBuild class! Which student would you like to learn more about?");
            Console.Write("Enter a number 1-4: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input);

        }
    }
}
