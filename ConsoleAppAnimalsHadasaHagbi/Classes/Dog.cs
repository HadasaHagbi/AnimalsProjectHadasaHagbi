using ConsoleAppAnimalsHadasaHagbi.interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalsHadasaHagbi.Classes
{
    public class Dog : Animal, Land
    {
        private readonly int NumberOfLegs = 4;
        private readonly string[] MOODS = { "bark loudly", "whooping sound" };
        public Dog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
        }
        //dogs greet the people
        public override void sayHello()
        {
            Console.WriteLine("I usually greet people by wagging my tail");
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
            Console.WriteLine("now i " + this.MOODS[mood-1]+" because i "+moodk);
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}
