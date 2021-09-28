using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 2 instances of class cat
            Cat cat01 = new Cat("Sam");
            Cat cat02 = new Cat("Boris");

            // Write a title
            Console.WriteLine("\tList of Cats:\n");

            // Write down the name and the energy percentage of each cat object
            Console.WriteLine($"Cat: {cat01.Name} has {cat01.Energy}% of "+
                $"energy.");
            Console.WriteLine($"Cat: {cat02.Name} has {cat02.Energy}% of "+
                $"energy.");

            Console.WriteLine("=============================");

            
            // Print out a specific action if condition is met according to the
            // status of the energy and mood.

            cat01.Eat();
            cat02.Eat();

            cat01.Sleep();
            cat02.Sleep();

            cat01.Meow();
            cat02.Meow();

            cat01.Play();
            cat02.Play();
            
            
                
            
            
            

        }
    }
}
