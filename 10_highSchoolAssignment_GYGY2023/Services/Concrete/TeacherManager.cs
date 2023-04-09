using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Services.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private List<Teacher> _teachers;

        public TeacherManager()
        {
            _teachers = new List<Teacher>();
        }

        public void Add(Teacher teacher)
        {
            teacher.Id = GetTotalNumberOfEntity() + 1; // Oluşturulan öğretmen nesnelerine 1`den itibaren 1`er 1`er artacak şekilde otomatik olarak id değerini atama işlemini gerçekleştirdim
            _teachers.Add(teacher);
        }

        public void Delete(int teacherId)
        {
            Teacher teacher = _teachers.FirstOrDefault(s => s.Id == teacherId);

            if (teacher == null)
            {
                Console.WriteLine("Id`si Verilen Öğretmen Bulunamadığı İçin Silme İşlemi Başarısız Olmuştur!");
                return;
            }

            _teachers.Remove(teacher);
        }

        public void Update(Teacher teacher)
        {
            Teacher existingTeacher = _teachers.FirstOrDefault(s => s.Id == teacher.Id);

            if (existingTeacher == null)
            {
                Console.WriteLine("Id`si Verilen Öğretmen Bulunamadığı İçin Güncelleme İşlemi Başarısız Olmuştur!");
            }

            else
            {
                existingTeacher.Id = teacher.Id;
                existingTeacher.FirstName = teacher.FirstName;
                existingTeacher.LastName = teacher.LastName;
                existingTeacher.Gender = teacher.Gender;
                existingTeacher.Address = teacher.Address;
                existingTeacher.PhoneNumber = teacher.PhoneNumber;
                existingTeacher.Classroom = teacher.Classroom;
            }
        }

        public List<Teacher> GetAll()
        {
            if (_teachers.Count == 0)
            {
                Console.WriteLine("\nHiçbir Öğretmen Oluşturulmamıştır!");
            }

            return _teachers;
        }

        public Teacher GetById(int teacherId)
        {
            Teacher teacher = _teachers.FirstOrDefault(s => s.Id == teacherId);

            if (teacher == null)
            {
                Console.WriteLine("\nId'si Verilen Öğretmen Bulunamadı!");
            }

            return teacher;
        }

        public List<Teacher> GetByName(string teacherFirstName, string teacherLastName)
        {
            var filteredTeachers = _teachers.Where(t => t.FirstName == teacherFirstName && t.LastName == teacherLastName).ToList();

            if (filteredTeachers.Count == 0)
            {
                Console.WriteLine("\nAdı Ve Soyadı Verilen Öğretmen Bulunamadı!");
            }

            return filteredTeachers;
        }

        public int GetTotalNumberOfEntity()
        {                    
            return _teachers.Count();
        }
    }
}
