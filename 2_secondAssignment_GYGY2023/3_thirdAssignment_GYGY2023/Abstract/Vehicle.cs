using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Abstract
{
    public abstract class Vehicle
    {      
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public abstract void Drive();
    }
}
