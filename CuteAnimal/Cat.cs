using System;

namespace CuteAnimal
{
    public class Cat
    {
        // Get Hunger status of a cat
        private Feed feedStatus;

        // Get mood status of a cat
        private Mood moodStatus;

        /// <summary>
        /// Variable of type Random
        /// </summary>
        private Random random;

        /// <summary>
        /// Get and set the cats name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get and set the cats energy
        /// The value of the energy is set to private since its the max value
        /// of energy a cat can have
        /// </summary>
        public int Energy { get; private set; } = 100;

        /// <summary>
        /// Private constructor to initialize instance of type Random
        /// </summary>
        private Cat()
        {
            random = new Random();
        }

        /// <summary>
        /// Public constructor that allows us to create an object of type cat
        /// with diferent types of arguments.
        /// </summary>
        /// <param name="name"> Set the name of the cat </param>
        /// <param name="energy"> Set the energy of the cat </param>
        /// <param name="feedStatus"> Set the feedstatus of the cat </param>
        /// <param name="moodStatus"> Set the moodstatus of the cat </param>
        public Cat(string name, int energy, Feed feedStatus, Mood moodStatus) 
            : this()
        {
            Name = name;
            Energy = energy;
            this.feedStatus = feedStatus;
            this.moodStatus = moodStatus;

            random.Next(Energy);
        }

        /// <summary>
        /// Public constructor that allows us to create an object of type cat
        /// that accepts one argument
        /// </summary>
        /// <param name="name"> Receives a name of type string </param>
        public Cat(string name) : this()
        {
            Name = name;
            Energy = random.Next(Energy);
            random.Next((int)moodStatus);
            random.Next((int)feedStatus);
        }

        /// <summary>
        /// Eating cat action
        /// </summary>
        public void Eat()
        {
            if(Energy >= 30 && Energy < 59 || moodStatus == Mood.IgnoringYou)
            {
                Console.WriteLine();
                Console.WriteLine($"Cat: {Name} is eating.");
                Energy += 20;
            }
        }

        /// <summary>
        /// Sleeping cat action
        /// </summary>
        public void Sleep()
        {
            if(Energy >= 1 && Energy < 30 || moodStatus == Mood.Grumpy)
            {
                Console.WriteLine();
                Console.WriteLine($"Cat: {Name} is sleeping.");
                Energy += 40;
            }
        }

        /// <summary>
        /// Cat meow action
        /// </summary>
        public void Meow()
        {
            if (moodStatus == Mood.Happy || Energy > 60 && Energy < 80)
            {
                Console.WriteLine();
                Console.WriteLine($"Cat: {Name} is happily 'Meowing'.");
            }
            
        }

        /// <summary>
        /// Cat play action
        /// </summary>
        public void Play()
        {
            if(Energy >= 80 || Energy <= 100 && moodStatus == Mood.HyperActive)
            {
                Console.WriteLine();
                Console.WriteLine($"Cat: {Name} is playing with plastic ball.\n" +
                    $" Energy = {Energy}%");
                Energy -= 50;
                Console.WriteLine($"{Energy}%");
            }
        }
    }
}