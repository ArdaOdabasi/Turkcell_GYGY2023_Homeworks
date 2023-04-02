using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _9_ninthAssignment_GYGY2023
{
    public class CarRentalReservation : ReservationBase, IReservable
    {
        public string CarModel { get; set; }

        public void MakeReservation()
        {
            Console.WriteLine("Car rental reservation completed successfully!");
        }
    }
}
