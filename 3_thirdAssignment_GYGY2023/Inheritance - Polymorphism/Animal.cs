using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Inheritance___Polymorphism
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string Name)
        {
            this.Name = Name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} bir ses çıkarır");
        }
    }
}
