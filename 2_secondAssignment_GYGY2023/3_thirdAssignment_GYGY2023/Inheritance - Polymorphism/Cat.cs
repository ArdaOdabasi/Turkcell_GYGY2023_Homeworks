using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_thirdAssignment_GYGY2023.Inheritance___Polymorphism
{
    public class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} 'miyav' diye bir ses çıkarır");
        }
    }
}
