using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ninthAssignment_GYGY2023
{
    public class ReservationBase
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Customer Customer { get; set; }
        public double TotalFee { get; set; }
        public bool RentalTransactionApproval { get; set; }
    }
}
