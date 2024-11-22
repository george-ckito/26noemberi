using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26noemberi
{
    internal class Cat
    {
        private int grams;
        public string name { get; set; }
        public string breed { get; set; }
        public uint age { get; set; }
        public string sex { get; set; }

        public Cat() { }
        public Cat(string name, string breed, uint age, string sex)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.sex = sex;
        }
        public void Meow(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Meow");
            }
        }

        public void Eat(int grams)
        {
            Console.WriteLine($"{name} eating");
            for(int i = 0; i < Math.Floor((double) grams / 10); i++)
            {
                Console.WriteLine("eating");
            }
            this.grams = grams; // ?
            Console.WriteLine($"{name} finish eating");

        }

    }
}
