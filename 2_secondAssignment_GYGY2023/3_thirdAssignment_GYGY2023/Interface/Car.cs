using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Interface
{
    public class Car : IDrivable
    {
        public void Start()
        {
            Console.WriteLine("Araba çalıştı");
        }

        public void Accelerate()
        {
            Console.WriteLine("Araba hızlandı");
        }

        public void Brake()
        {
            Console.WriteLine("Araba durdu");
        }
    }
}
