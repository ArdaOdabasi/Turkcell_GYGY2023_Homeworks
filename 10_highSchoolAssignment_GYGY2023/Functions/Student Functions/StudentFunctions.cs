using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Student_Functions
{
    public static class StudentFunctions
    {
        public static Student CreateStudent()
        {
            Student student = new Student();

            Console.Write($"\nÖğrencinin Adını Giriniz: ");
            do
            {
                student.FirstName = Console.ReadLine();
                if (!student.FirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.FirstName))
                {
                    Console.Write("\nLütfen Geçerli Bir Ad Giriniz: ");
                }
            } while (!student.FirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.FirstName));
        
            Console.Write($"\nÖğrencinin Soyadını Giriniz: ");
            do
            {
                student.LastName = Console.ReadLine();
                if (!student.LastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.LastName))
                {
                    Console.Write("\nLütfen Geçerli Bir Soyad Giriniz: ");
                }
            } while (!student.LastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.LastName));

            Console.Write($"\nÖğrencinin Cinsiyetini Giriniz: ");
            do
            {
                student.Gender = Console.ReadLine();
                if (!student.Gender.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.Gender))
                {
                    Console.Write("\nLütfen Geçerli Bir Cinsiyet Giriniz: ");
                }
            } while (!student.Gender.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.Gender));

            Console.Write($"\nÖğrencinin Adresini Giriniz: ");
            do
            {
                student.Address = Console.ReadLine();
                if (!student.Address.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.Address))
                {
                    Console.Write("\nLütfen Geçerli Bir Adres Giriniz: ");
                }
            } while (!student.Address.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(student.Address));

            Console.Write($"\nÖğrencinin Telefon Numarasını Giriniz: ");
            do
            {
                student.PhoneNumber = Console.ReadLine();
                if (!student.PhoneNumber.All(c => Char.IsNumber(c)) || string.IsNullOrEmpty(student.PhoneNumber))
                {
                    Console.Write("\nLütfen Geçerli Bir Telefon Numarası Giriniz: ");
                }
            } while (!student.PhoneNumber.All(c => Char.IsNumber(c)) || string.IsNullOrEmpty(student.PhoneNumber));

            return student;
        }

        public static void ShowStudent(Student student)
        {
            if (student != null)
            {
                if (student.Classroom != null)
                {
                    Console.WriteLine($"\nÖğrenci Id: {student.Id}\nÖğrenci Adı: {student.FirstName}\nÖğrenci Soyadı: {student.LastName}\nÖğrencinin Cinsiyeti: {student.Gender}\nÖğrencinin Adresi: {student.Address}\nÖğrencinin Telefon Numarası: {student.PhoneNumber}\nÖğrencinin Sınıfının Adı: {student.Classroom.Name}");
                }

                else
                {
                    Console.WriteLine($"\nÖğrenci Id: {student.Id}\nÖğrenci Adı: {student.FirstName}\nÖğrenci Soyadı: {student.LastName}\nÖğrencinin Cinsiyeti: {student.Gender}\nÖğrencinin Adresi: {student.Address}\nÖğrencinin Telefon Numarası: {student.PhoneNumber}\nÖğrencinin Sınıfının Adı: Atama Yapılmadı");
                }
            }
        }

        public static void ShowStudents(List<Student> students)
        {
            if (students != null)
            {
                foreach (var student in students)
                {
                    if (student.Classroom != null)
                    {
                        Console.WriteLine($"\nÖğrenci Id: {student.Id}\nÖğrenci Adı: {student.FirstName}\nÖğrenci Soyadı: {student.LastName}\nÖğrencinin Cinsiyeti: {student.Gender}\nÖğrencinin Adresi: {student.Address}\nÖğrencinin Telefon Numarası: {student.PhoneNumber}\nÖğrencinin Sınıfının Adı: {student.Classroom.Name}");
                    }

                    else
                    {
                        Console.WriteLine($"\nÖğrenci Id: {student.Id}\nÖğrenci Adı: {student.FirstName}\nÖğrenci Soyadı: {student.LastName}\nÖğrencinin Cinsiyeti: {student.Gender}\nÖğrencinin Adresi: {student.Address}\nÖğrencinin Telefon Numarası: {student.PhoneNumber}\nÖğrencinin Sınıfının Adı: Atama Yapılmadı");
                    }
                }
            }
        }      
    }
}
