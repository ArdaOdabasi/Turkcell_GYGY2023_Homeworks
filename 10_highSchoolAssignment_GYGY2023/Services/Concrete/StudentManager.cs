using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Services.Concrete
{
    public class StudentManager : IStudentService
    {
        private List<Student> _students;

        public StudentManager()
        {
            _students = new List<Student>();
        }

        public void Add(Student student)
        {
            student.Id = GetTotalNumberOfEntity() + 1; // Oluşturulan öğrenci nesnelerine 1`den itibaren 1`er 1`er artacak şekilde otomatik olarak id değerini atama işlemini gerçekleştirdim
            _students.Add(student);
        }

        public void Delete(int studentId)
        {
            Student student = _students.FirstOrDefault(s => s.Id == studentId);

            if (student == null)
            {
                Console.WriteLine("Id`si Verilen Öğrenci Bulunamadığı İçin Silme İşlemi Başarısız Olmuştur!");
                return;
            }

            _students.Remove(student);
        }
        public void Update(Student student)
        {
            Student existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);

            if (existingStudent == null)
            {
                Console.WriteLine("Id`si Verilen Öğrenci Bulunamadığı İçin Güncelleme İşlemi Başarısız Olmuştur!");
            }

            else
            {
                existingStudent.Id = student.Id;
                existingStudent.FirstName = student.FirstName;
                existingStudent.LastName = student.LastName;
                existingStudent.Gender = student.Gender;
                existingStudent.Address = student.Address;
                existingStudent.PhoneNumber = student.PhoneNumber;
                existingStudent.Classroom = student.Classroom;
            }
        }

        public List<Student> GetAll()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("\nHiçbir Öğrenci Oluşturulmamıştır!");
            }

            return _students;
        }

        public Student GetById(int studentId)
        {
            Student student = _students.FirstOrDefault(s => s.Id == studentId);

            if (student == null)
            {
                Console.WriteLine("\nId'si Verilen Öğrenci Bulunamadı!");
            }

            return student;
        }

        public List<Student> GetByName(string studentFirstName, string studentLastName)
        {
            var filteredStudents = _students.Where(t => t.FirstName == studentFirstName && t.LastName == studentLastName).ToList();

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine("\nAdı Ve Soyadı Verilen Öğrenci Bulunamadı!");
            }

            return filteredStudents;
        }

        public int GetTotalNumberOfEntity()
        {
            return _students.Count();
        }
      
        public void SendAssignment(int studentId) => Console.WriteLine($"\nId Numarası {studentId} Olan Öğrencinin Ödevi Başarılı Bir Şekilde Sorumlu Öğretmenine Gönderildi!");
    }
}
