using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Interface
{
    public class Bicycle : IDrivable
    {
        public void Start()
        {
            Console.WriteLine("Bisiklet çalıştı");
        }

        public void Accelerate()
        {
            Console.WriteLine("Bisiklet hızlandı");
        }

        public void Brake()
        {
            Console.WriteLine("Bisiklet durdu");
        }
    }
}
