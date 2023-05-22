using ConsoleAppAnimalsHadasaHagbi.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalsHadasaHagbi.Classes
{
    internal class Cat:Animal,Land
    {
        private readonly int NumberOfLegs = 4;
        private readonly string[] MOODS = { "make a purr, purr sound", "make a hiss sound" };

        public Cat(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
        }
        //cats greet the people

        public override void sayHello()
        {
            Console.WriteLine("I usually greet people by miau");
        }
        public override void sayHello(int mood)
        {
            string moodk = "";
            this.mood = mood;
            if (mood == 1)
            {
                moodk = "happy";
            }
            else
            {
                moodk = "scare";
            }
            Console.WriteLine("now i " + this.MOODS[mood-1] + " because i " + moodk);
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}
