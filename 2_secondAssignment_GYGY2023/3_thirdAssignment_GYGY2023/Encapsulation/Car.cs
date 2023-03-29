using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_thirdAssignment_GYGY2023.Encapsulation
{
    public class Car
    {
        private string Model { get; set; }
        private int Year { get; set; }
        private double Speed { get; set; }

        public Car(string Model, int Year, double Speed)
        {
            this.Model = Model;
            this.Year = Year;
            this.Speed = Speed;
        }

        public void Accelerate(double Acceleration)
        {
            Speed += Acceleration;
        }

        public void Brake(double Deceleration)
        {
            if (Speed - Deceleration < 0)
            {
                Speed = 0;
            }
            else
            {
                Speed -= Deceleration;
            }
        }

        public void PrintDetails()
        { 
            Console.WriteLine($"Araç {Year} yılında üretilmiş {Model} model bir araçtır ve {Speed} hıza sahiptir.");
        }
    }
}
