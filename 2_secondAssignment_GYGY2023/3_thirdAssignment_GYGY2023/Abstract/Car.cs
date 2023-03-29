using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Abstract
{
    public class Car : Vehicle
    {
        public override void Drive() 
        { 
            Console.WriteLine($"{Brand} şirketinin {Year} yılında üretilmiş {Model} model aracıyla sürüş yapılıyor");
        }
    }
}
