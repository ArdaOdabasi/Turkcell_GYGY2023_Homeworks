using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Constructor
{
    public class Car : Vehicle
    {
        public Car(string Brand, string Model, int Year) : base(Brand, Model, Year)
        {
        
        }

        public override void Drive() 
        { 
            Console.WriteLine($"{Brand} şirketinin {Year} yılında üretilmiş {Model} model aracıyla sürüş yapılıyor");
        }
    }
}
