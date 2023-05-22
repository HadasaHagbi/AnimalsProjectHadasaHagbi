using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalsHadasaHagbi.Classes
{
    public abstract class Animal
    {
        internal bool mammals { get; set; }
        internal bool carnivorous { get; set; }
        internal int mood { get; set; }

        public const int MOOD_HAPPY = 1;
        public const int MOOD_SCARE = 2;

        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood = mood;
        }
        public virtual void sayHello()
        {
            return;
        }
        public abstract void sayHello(int mood);

        public bool isMammals()
        {
            return this.mammals;
        }
        public void setMammals(bool mammals)
        {
            this.mammals = mammals;
        }
        public bool isCarnivorous()
        {
            return this.carnivorous;
        }
        public void setCarnivorous(bool carnivorous)
        {
            this.carnivorous = carnivorous;
        }
    }
}
