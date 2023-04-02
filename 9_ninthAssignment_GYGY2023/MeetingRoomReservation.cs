using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ninthAssignment_GYGY2023
{
    public class MeetingRoomReservation : ReservationBase, IReservable
    {
        public MeetingRoom MeetingRoomType { get; set; }
        public HallLayout HallLayoutType { get; set; }
        public int TotalNumberOfPeople { get; set; }
        public void MakeReservation()
        {
            Console.WriteLine("Meeting room reservation completed successfully!");
        }
    }

    public enum MeetingRoom
    {
        SmallHall,
        BigHall
    }

    public enum HallLayout
    {
        ULayout,
        CinemaLayout
    }
}
