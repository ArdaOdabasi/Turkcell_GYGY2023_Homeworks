using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Services.Abstract
{
    public interface ITeacherService : IService<Teacher>
    {
        List<Teacher> GetByName(string teacherFirstName, string teacherLastName);
    }
}
