using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Teacher_Functions
{
    public static class TeacherFunctions
    {
        public static Teacher CreateTeacher()
        {
            Teacher teacher = new Teacher();

            Console.Write($"\nÖğretmenin Adını Giriniz: ");
            do
            {
                teacher.FirstName = Console.ReadLine();
                if (!teacher.FirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.FirstName))
                {
                    Console.Write("\nLütfen Geçerli Bir Ad Giriniz: ");
                }
            } while (!teacher.FirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.FirstName));

            Console.Write($"\nÖğretmenin Soyadını Giriniz: ");
            do
            {
                teacher.LastName = Console.ReadLine();
                if (!teacher.LastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.LastName))
                {
                    Console.Write("\nLütfen Geçerli Bir Soyad Giriniz: ");
                }
            } while (!teacher.LastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.LastName));

            Console.Write($"\nÖğretmenin Cinsiyetini Giriniz: ");
            do
            {
                teacher.Gender = Console.ReadLine();
                if (!teacher.Gender.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.Gender))
                {
                    Console.Write("\nLütfen Geçerli Bir Cinsiyet Giriniz: ");
                }
            } while (!teacher.Gender.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.Gender));

            Console.Write($"\nÖğretmenin Adresini Giriniz: ");
            do
            {
                teacher.Address = Console.ReadLine();
                if (!teacher.Address.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.Address))
                {
                    Console.Write("\nLütfen Geçerli Bir Adres Giriniz: ");
                }
            } while (!teacher.Address.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacher.Address));

            Console.Write($"\nÖğretmenin Telefon Numarasını Giriniz: ");
            do
            {
                teacher.PhoneNumber = Console.ReadLine();
                if (!teacher.PhoneNumber.All(c => Char.IsNumber(c)) || string.IsNullOrEmpty(teacher.PhoneNumber))
                {
                    Console.Write("\nLütfen Geçerli Bir Telefon Numarası Giriniz: ");
                }
            } while (!teacher.PhoneNumber.All(c => Char.IsNumber(c)) || string.IsNullOrEmpty(teacher.PhoneNumber));

            return teacher;
        }

        public static void ShowTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                if (teacher.Classroom != null)
                {
                    Console.WriteLine($"\nÖğretmen Id: {teacher.Id}\nÖğretmen Adı: {teacher.FirstName}\nÖğretmen Soyadı: {teacher.LastName}\nÖğretmenin Cinsiyeti: {teacher.Gender}\nÖğretmenin Adresi: {teacher.Address}\nÖğretmenin Telefon Numarası: {teacher.PhoneNumber}\nÖğretmenin Sınıfının Adı: {teacher.Classroom.Name}");
                }

                else
                {
                    Console.WriteLine($"\nÖğretmen Id: {teacher.Id}\nÖğretmen Adı: {teacher.FirstName}\nÖğretmen Soyadı: {teacher.LastName}\nÖğretmenin Cinsiyeti: {teacher.Gender}\nÖğretmenin Adresi: {teacher.Address}\nÖğretmenin Telefon Numarası: {teacher.PhoneNumber}\nÖğretmenin Sınıfının Adı: Atama Yapılmadı");
                }
            }
        }

        public static void ShowTeachers(List<Teacher> teachers)
        {
            if (teachers != null)
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Classroom != null)
                    {
                        Console.WriteLine($"\nÖğretmen Id: {teacher.Id}\nÖğretmen Adı: {teacher.FirstName}\nÖğretmen Soyadı: {teacher.LastName}\nÖğretmenin Cinsiyeti: {teacher.Gender}\nÖğretmenin Adresi: {teacher.Address}\nÖğretmenin Telefon Numarası: {teacher.PhoneNumber}\nÖğretmenin Sınıfının Adı: {teacher.Classroom.Name}");
                    }

                    else
                    {
                        Console.WriteLine($"\nÖğretmen Id: {teacher.Id}\nÖğretmen Adı: {teacher.FirstName}\nÖğretmen Soyadı: {teacher.LastName}\nÖğretmenin Cinsiyeti: {teacher.Gender}\nÖğretmenin Adresi: {teacher.Address}\nÖğretmenin Telefon Numarası: {teacher.PhoneNumber}\nÖğretmenin Sınıfının Adı: Atama Yapılmadı");
                    }
                }
            }
        }      
    }
}
