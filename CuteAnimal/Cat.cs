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
            Console.WriteLine(random.Next(Energy));
            Console.WriteLine(random.Next((int)moodStatus));
            Console.WriteLine(random.Next((int)feedStatus));
        }

        /// <summary>
        /// Eating cat action
        /// </summary>
        public void Eat()
        {
            if(Energy < 40)
            {
                Energy += 20;

                Console.WriteLine($"Cat {Name} is eating.");
            }
        }

        /// <summary>
        /// Sleeping cat action
        /// </summary>
        public void Sleep()
        {
            if(Energy < 10)
            {
                Console.WriteLine($"Cat {Name} is sleeping.");
                Energy += 40;
            }
        }

        /// <summary>
        /// Cat meow action
        /// </summary>
        public void Meow()
        {
            moodStatus = Mood.Happy;
            Console.WriteLine($"Cat {Name} says 'Meow'.");
        }

        /// <summary>
        /// Cat play action
        /// </summary>
        public void Play()
        {
            if(Energy > 70 && Energy <= 90)
            {
                moodStatus = Mood.HyperActive;
                feedStatus = Feed.Satisfied;

                Console.WriteLine($"Cat {Name} is playing with plastic ball.");
            }
        }
    }
}