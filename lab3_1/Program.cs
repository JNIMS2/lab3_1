using System;

namespace lab3_1
{
    class Program
    { static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to know about another student? (enter \"yes\" or \"no\"):");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    return true;
                }

                else if (response == "no")
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Please enter \"yes\" or \"no\".");
                }

            }
        }

        static void Main(string[] args)
        {
            //create 3 arrays and fill them with student info. name, fav food, previous title
            string[] name = { "John Applesauce", "Jacob Banana", "Jingleheimer Celery", "Schmidt Didgeridoo" };
            string[] favFood = { "Pizza", "Tacos", "Ramen", "Burgers" };//clearly these r college students
            string[] title = { "Server", "Customer Service Representative", "Gym teacher", "Self-employed" };
            do
            {
                Console.WriteLine("Welcome to our DevBuild class! Which student would you like to learn more about?");
                Console.Write("Enter a number 1-4: ");
                string input = (Console.ReadLine());
                int slot = int.Parse(input) - 1;
                if (slot == 0 || slot == 1|| slot == 2|| slot == 3)//i feel like there is a better way to do this. Antonio--any notes r good.
                                                                     //i couldn't figure out what equation i needed to do if it is in the array's length...
                {
                    Console.WriteLine($"\nYou chose {name[slot]}! What would you like to know about them? (enter \"favorite food\" or \"previous title\"):");

                    string input2 = (Console.ReadLine()).ToLower();
                    if (input2 == "favorite food")
                    {
                        Console.WriteLine($"\n { name[slot]}'s favorite food is {favFood[slot]}.");
                    }
                    else if (input2 == "previous title")
                    {
                        Console.WriteLine($"\n {name[slot]}'s previous role was {title[slot]}.");
                    }
                    else { Console.WriteLine("Please enter \"favorite food\" or \"previous title\"."); }
                }
                else
                {
                    Console.WriteLine(" That student does not exist. Please try again.(enter a number 1-4");
                }
            } while (Continue());
         
        }
    }
        
}
