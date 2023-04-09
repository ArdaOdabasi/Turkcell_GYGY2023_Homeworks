using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Services.Concrete
{
    public class ClassroomManager : IClassroomService
    {
        private List<Classroom> _classrooms;

        public ClassroomManager()
        {
            _classrooms = new List<Classroom>();
        }

        public void Add(Classroom classroom)
        {
            classroom.Id = GetTotalNumberOfEntity() + 1; // Oluşturulan sınıf nesnelerine 1`den itibaren 1`er 1`er artacak şekilde otomatik olarak id değerini atama işlemini gerçekleştirdim
            _classrooms.Add(classroom);
        }

        public void Delete(int classroomId)
        {
            Classroom classroom = _classrooms.FirstOrDefault(c => c.Id == classroomId);

            if (classroom == null)
            {
                Console.WriteLine("Id`si Verilen Sınıf Bulunamadığı İçin Silme İşlemi Başarısız Olmuştur!");
                return;
            }

            _classrooms.Remove(classroom);
        }

        public void Update(Classroom classroom)
        {
            Classroom existingClassroom = _classrooms.FirstOrDefault(c => c.Id == classroom.Id);

            if (existingClassroom == null)
            {
                Console.WriteLine("Id`si Verilen Sınıf Bulunamadığı İçin Güncelleme İşlemi Başarısız Olmuştur!");
            }

            else
            {
                existingClassroom.Id = classroom.Id;
                existingClassroom.Name = classroom.Name;
                existingClassroom.Students = classroom.Students.ToList();
                existingClassroom.ResponsibleTeacher = classroom.ResponsibleTeacher;
            }
        }

        public List<Classroom> GetAll()
        {
            if (_classrooms.Count == 0)
            {
                Console.WriteLine("\nHiçbir Sınıf Oluşturulmamıştır!");
            }

            return _classrooms;
        }

        public Classroom GetById(int classroomId)
        {
            Classroom classroom = _classrooms.FirstOrDefault(s => s.Id == classroomId);

            if (classroom == null)
            {
                Console.WriteLine("\nId'si Verilen Sınıf Bulunamadı!");
            }

            return classroom;
        }

        public List<Classroom> GetByName(string classroomName)
        {
            var filteredClassrooms = _classrooms.Where(t => t.Name == classroomName).ToList();

            if (filteredClassrooms.Count == 0)
            {
                Console.WriteLine("\nAdı Verilen Sınıf Bulunamadı!");
            }

            return filteredClassrooms;
        }

        public int GetTotalNumberOfEntity()
        {
            return _classrooms.Count();
        }

        public void AssignResponsibleTeacher(Teacher teacher, Classroom classroom)
        {
            if (classroom.ResponsibleTeacher != null || teacher.Classroom != null)
            {
                Console.WriteLine("\nÖğretmen Atama İşlemi İçin Seçilen Sorumlu Öğretmenin Sorumlusu Olduğu Bir Sınıfı Olmamalıdır Ve Seçilen Sınıfın Sorumlu Bir Öğretmeni Olmamalıdır!");
            }

            else
            {
                classroom.ResponsibleTeacher = teacher;
                teacher.Classroom = classroom;
                Console.WriteLine("\nÖğretmen Atama İşlemini Başarılı Bir Şekilde Gerçekleştirdiniz!");
                Console.WriteLine("\nSınıf Listesinden Veya Öğretmen Bilgilerinden Kaydettiğiniz Bilgileri Görüntüleyebilirsiniz.");
            }          
        }

        public void AssignStudent(Student student, Classroom classroom)
        {
            if (student.Classroom != null)
            {
                Console.WriteLine("\nÖğrenci Atama İşlemi İçin Seçilen Öğrencinin Bir Sınıfı Olmamalıdır!");
            }

            else
            {
                classroom.Students.Add(student);
                student.Classroom = classroom;
                Console.WriteLine("\nÖğrenci Atama İşlemini Başarılı Bir Şekilde Gerçekleştirdiniz!");
                Console.WriteLine("\nSınıf Listesinden Veya Öğrenci Bilgilerinden Kaydettiğiniz Bilgileri Görüntüleyebilirsiniz.");
            }
        }
    }
}
