using System;
namespace Homework7_2_Kitten
{
    public class Kitten
    {
        public string Name { get; set; }
        public string FurColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age} y.o.\nFur Color: {FurColor}\n" +
                $"Eye Color: {EyeColor}");
        }

        public void Speak(int times)
        {
            Console.WriteLine($"{Name} says: " + String.Concat(Enumerable.Repeat("Meow ", times)));
        }
    }
}

