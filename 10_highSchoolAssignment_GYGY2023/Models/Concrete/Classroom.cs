using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Models.Concrete
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher ResponsibleTeacher { get; set; }
        public List<Student> Students { get; set; }

        public Classroom()
        {
            Students = new List<Student>();
        }
    }
}
