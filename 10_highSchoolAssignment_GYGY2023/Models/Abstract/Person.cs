using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Models.Abstract
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }       
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Classroom Classroom { get; set; }
    }
}
