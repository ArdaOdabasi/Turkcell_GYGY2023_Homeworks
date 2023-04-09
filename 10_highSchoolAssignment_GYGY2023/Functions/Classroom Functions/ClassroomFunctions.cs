using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_highSchoolAssignment_GYGY2023.Classroom_Functions
{
    public static class ClassroomFunctions
    {
        public static Classroom CreateClassroom()
        {
            Classroom classroom = new Classroom();

            Console.Write($"\nSınıfın Adını Giriniz: ");
            do
            {
                classroom.Name = Console.ReadLine();
                if (!classroom.Name.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(classroom.Name))
                {
                    Console.Write("\nLütfen Geçerli Bir Ad Giriniz: ");
                }
            } while (!classroom.Name.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(classroom.Name));

            return classroom;
        }

        public static void ShowClassroom(Classroom classroom)
        {
            if (classroom != null)
            {
                if (classroom.ResponsibleTeacher != null)
                {
                    Console.WriteLine($"\nSınıf Id: {classroom.Id}\nSınıf Adı: {classroom.Name}\nSınıfın Sorumlu Öğretmeni: {classroom.ResponsibleTeacher.FirstName} {classroom.ResponsibleTeacher.LastName}");
                    Console.WriteLine($"\n--- {classroom.Name} Sınıfının Sınıf Listesi ---");

                    if (classroom.Students.Count == 0)
                    {
                        Console.WriteLine("Sınıfa Öğrenci Eklenmemiştir.");
                        Console.WriteLine("");
                    }

                    else
                    {
                        foreach (var student in classroom.Students)
                        {
                            Console.WriteLine($"Öğrencinin Adı: {student.FirstName} {student.LastName}");
                        }
                        Console.WriteLine("");
                    }
                }

                else
                {
                    Console.WriteLine($"\nSınıf Id: {classroom.Id}\nSınıf Adı: {classroom.Name}\nSınıfın Sorumlu Öğretmeni: Atama Yapılmadı");
                    Console.WriteLine($"\n--- {classroom.Name} Sınıfının Sınıf Listesi ---");

                    if (classroom.Students.Count == 0)
                    {
                        Console.WriteLine("Sınıfa Öğrenci Eklenmemiştir.");
                        Console.WriteLine("");
                    }

                    else
                    {
                        foreach (var student in classroom.Students)
                        {
                            Console.WriteLine($"\nÖğrencinin Adı: {student.FirstName} {student.LastName}");
                        }
                        Console.WriteLine("");
                    }
                }
            }
        }

        public static void ShowClassrooms(List<Classroom> classrooms)
        {
            if (classrooms != null)
            {
                foreach (var classroom in classrooms)
                {
                    if (classroom.ResponsibleTeacher != null)
                    {
                        Console.WriteLine($"\nSınıf Id: {classroom.Id}\nSınıf Adı: {classroom.Name}\nSınıfın Sorumlu Öğretmeni: {classroom.ResponsibleTeacher.FirstName} {classroom.ResponsibleTeacher.LastName}");
                        Console.WriteLine($"\n--- {classroom.Name} Sınıfının Sınıf Listesi ---");

                        if (classroom.Students.Count == 0)
                        {
                            Console.WriteLine("Sınıfa Öğrenci Eklenmemiştir.");
                            Console.WriteLine("");
                        }

                        else
                        {
                            foreach (var student in classroom.Students)
                            {
                                Console.WriteLine($"Öğrencinin Adı: {student.FirstName} {student.LastName}");
                            }
                            Console.WriteLine("");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"\nSınıf Id: {classroom.Id}\nSınıf Adı: {classroom.Name}\nSınıfın Sorumlu Öğretmeni: Atama Yapılmadı");
                        Console.WriteLine($"\n--- {classroom.Name} Sınıfının Sınıf Listesi ---");

                        if (classroom.Students.Count == 0)
                        {
                            Console.WriteLine("Sınıfa Öğrenci Eklenmemiştir.");
                            Console.WriteLine("");
                        }

                        else
                        {
                            foreach (var student in classroom.Students)
                            {
                                Console.WriteLine($"\nÖğrencinin Adı: {student.FirstName} {student.LastName}");
                            }
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }
}
