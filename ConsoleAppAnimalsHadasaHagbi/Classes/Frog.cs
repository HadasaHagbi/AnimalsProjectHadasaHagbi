using ConsoleAppAnimalsHadasaHagbi.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalsHadasaHagbi.Classes
{
    internal class Frog : Animal, Water, Land
    {
        private readonly int NumberOfLegs = 4;
        private readonly string[] MOODS = { "quack quack quack", "plop into the water" };

        public Frog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {

        }
        public override void sayHello(int mood)
        {
            string moodk = "";
            this.mood = mood;
            if (mood == MOOD_HAPPY)
            {
                moodk = "happy";
            }
            else
            {
                moodk = "scare";
            }
            Console.WriteLine("now i " + this.MOODS[mood - 1] + " because i " + moodk);
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public bool hasGill()
        {
            return true;
        }

        public bool hasLaysEggs()
        {
            return true;
        }



    }
}
