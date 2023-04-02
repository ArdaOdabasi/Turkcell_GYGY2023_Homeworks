using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ninthAssignment_GYGY2023
{
    public class HotelRoomReservation : ReservationBase, IReservable
    {
        public string RoomType { get; set; }

        public void MakeReservation()
        {
            Console.WriteLine("Hotel room reservation completed successfully!");
        }
    }
}
