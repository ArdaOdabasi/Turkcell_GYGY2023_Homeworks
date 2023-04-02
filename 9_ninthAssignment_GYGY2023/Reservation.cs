using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ninthAssignment_GYGY2023
{
    public static class Reservation
    {
        public static IReservable ReservationFactory(string StartDate, string EndDate, Customer Customer, double TotalFee, bool RentalTransactionApproval, string? CarModel = null, string? RoomType = null, MeetingRoom? MeetingRoomType = null, HallLayout? HallLayoutType = null, int? TotalNumberOfPeople = null)
        {
            if (CarModel != null)
            {
                return new CarRentalReservation() { StartDate = StartDate, EndDate = EndDate, Customer = Customer, TotalFee = TotalFee, RentalTransactionApproval = RentalTransactionApproval, CarModel = CarModel };
            }
            else if (RoomType != null)
            {
                return new HotelRoomReservation() { StartDate = StartDate, EndDate = EndDate, Customer = Customer, TotalFee = TotalFee, RentalTransactionApproval = RentalTransactionApproval, RoomType = RoomType };
            }
            else if (MeetingRoomType.HasValue && HallLayoutType.HasValue && TotalNumberOfPeople.HasValue)
            {
                return new MeetingRoomReservation() { StartDate = StartDate, EndDate = EndDate, Customer = Customer, TotalFee = TotalFee, RentalTransactionApproval = RentalTransactionApproval, MeetingRoomType = MeetingRoomType.Value, HallLayoutType = HallLayoutType.Value, TotalNumberOfPeople = TotalNumberOfPeople.Value };
            }
            else
            {
                throw new ArgumentException("Geçersiz Parametre Girişi!");
            }
        }
    }
}
