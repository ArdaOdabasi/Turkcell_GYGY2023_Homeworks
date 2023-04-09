using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Services.Abstract
{
    public interface IClassroomService : IService<Classroom>
    {
        List<Classroom> GetByName(string classroomName);
        void AssignResponsibleTeacher(Teacher teacher, Classroom classroom);
        void AssignStudent(Student student, Classroom classroom);
    }
}
