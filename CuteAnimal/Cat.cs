using System;

namespace CuteAnimal
{
    public class Cat
    {
        // Name of Cat
        private readonly string name;

        // Get energy of cat
        private int energy;

        // Get Hunger status of cat
        private Feed feedStatus;

        // Get mood status of cat
        private Mood moodStatus;

        private Random random;

        private Cat()
        {
            random = new Random();
        }

        public Cat(string name, int energy, Feed feedStatus, Mood moodStatus) 
            : this()
        {
            this.name = name;
            this.energy = energy;
            this.feedStatus = feedStatus;
            this.moodStatus = moodStatus;
        }

        public Cat(string name) : this()
        {
            this.name = name;
        }

        /// <summary>
        /// Get the cats name
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// Get the cats energy
        /// </summary>
        public int Energy { get => energy; }



      

        /// <summary>
        /// Eating cat action
        /// </summary>
        public void Eat()
        {
            if(energy < 40)
            {
                feedStatus = Feed.Hungry;
            }
        }

        public void Sleep()
        {
            if(energy < 10)
            {
                moodStatus = Mood.Grumpy;
                Console.WriteLine("Sleep");

            }
        }

        public void Meow()
        {
            
        }

        public void Play()
        {
            if(energy < 70)
            {
                
            }
        }

    }
}