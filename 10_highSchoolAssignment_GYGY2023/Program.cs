using _10_highSchoolAssignment_GYGY2023.Classroom_Functions;
using _10_highSchoolAssignment_GYGY2023.Models.Concrete;
using _10_highSchoolAssignment_GYGY2023.Services.Concrete;
using _10_highSchoolAssignment_GYGY2023.Student_Functions;
using _10_highSchoolAssignment_GYGY2023.Teacher_Functions;
using System.Runtime.CompilerServices;

ClassroomManager classroomManager = new();
StudentManager studentManager = new();
TeacherManager teacherManager = new();

int secim = 0;
do
{
    Console.Clear();
    Console.WriteLine("\n----- Turkcell Gelecegi Yazanlar 2023 .NET Sınıfı Lise Yazılımı -----\n");
    Console.WriteLine("\n1-) Sınıf İşlemleri");
    Console.WriteLine("\n2-) Öğrenci İşlemleri");
    Console.WriteLine("\n3-) Öğretmen İşlemleri");
    Console.WriteLine("\n4-) Çıkış");
    Console.Write("\nLütfen 1 İle 4 Arasında Bir Seçim Yapınız: ");
    while (!int.TryParse(Console.ReadLine(), out secim) || secim <= 0)
    {
        Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
    }

    switch (secim)
    {
        case 1:
            int altSecim1 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n----- Sınıf İşlemleri -----");
                Console.WriteLine("\n1-) Sınıf Oluşturma");
                Console.WriteLine("\n2-) Tüm Sınıfları Listeleme");
                Console.WriteLine("\n3-) ID Numarasına Göre Sınıf Bilgilerini Görüntüleme");
                Console.WriteLine("\n4-) Sınıf Adına Göre Sınıf Bilgilerini Görüntüleme");
                Console.WriteLine("\n5-) Sınıfa Sorumlu Öğretmen Atama");
                Console.WriteLine("\n6-) Sınıfa Öğrenci Atama");
                Console.WriteLine("\n7-) Geri");
                Console.Write("\nSeçiminizi Giriniz (1-7): ");
                while (!int.TryParse(Console.ReadLine(), out altSecim1) || altSecim1 <= 0)
                {
                    Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
                }
                ClassroomMenu(altSecim1);
            } while (altSecim1 != 7);
            break;
        case 2:
            int altSecim2 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n----- Öğrenci İşlemleri -----");
                Console.WriteLine("\n1-) Öğrenci Oluşturma");
                Console.WriteLine("\n2-) Tüm Öğrencileri Listeleme");
                Console.WriteLine("\n3-) ID Numarasına Göre Öğrenci Bilgilerini Görüntüleme");
                Console.WriteLine("\n4-) İsim-Soyisim Bilgisine Göre Öğrenci Bilgilerini Görüntüleme");
                Console.WriteLine("\n5-) Ödev Gönderme");
                Console.WriteLine("\n6-) Geri");
                Console.Write("\nSeçiminizi Giriniz (1-6): ");
                while (!int.TryParse(Console.ReadLine(), out altSecim2) || altSecim2 <= 0)
                {
                    Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
                }
                StudentMenu(altSecim2);
            } while (altSecim2 != 6);
            break;
        case 3:
            int altSecim3 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n----- Öğretmen İşlemleri -----");
                Console.WriteLine("\n1-) Öğretmen Oluşturma");
                Console.WriteLine("\n2-) Tüm Öğretmenleri Listeleme");
                Console.WriteLine("\n3-) ID Numarasına Göre Öğretmen Bilgilerini Görüntüleme");
                Console.WriteLine("\n4-) İsim-Soyisim Bilgisine Göre Öğretmen Bilgilerini Görüntüleme");
                Console.WriteLine("\n5-) Geri");
                Console.Write("\nSeçiminizi Giriniz (1-5): ");
                while (!int.TryParse(Console.ReadLine(), out altSecim3) || altSecim3 <= 0)
                {
                    Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
                }
                TeacherMenu(altSecim3);
            } while (altSecim3 != 5);
            break;
        case 4:
            Console.WriteLine("\n----- Lise Yazılımından Çıkış Yaptınız -----");
            break;
        default:
            Console.WriteLine("\nGeçersiz Seçim, Lütfen Tekrar Deneyin!");
            Thread.Sleep(500);
            break;
    }
} while (secim != 4);

void ClassroomMenu(int secim)
{
    switch (secim)
    {
        case 1:
            var addedClassroom = ClassroomFunctions.CreateClassroom();
            classroomManager.Add(addedClassroom);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 2:
            var allClassrooms = classroomManager.GetAll();
            ClassroomFunctions.ShowClassrooms(allClassrooms);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 3:
            int classroomIdForView;
            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Sınıfın Id Numarasını Giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out classroomIdForView) || classroomIdForView <= 0)
            {
                Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
            }
            var classroomForView = classroomManager.GetById(classroomIdForView);
            ClassroomFunctions.ShowClassroom(classroomForView);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 4:
            string classroomName;
            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Sınıfın Adını Giriniz: ");
            do
            {
                classroomName = Console.ReadLine();
                if (!classroomName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(classroomName))
                {
                    Console.Write("\nLütfen Geçerli Bir Ad Giriniz: ");
                }
            } while (!classroomName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(classroomName));

            var classrooms = classroomManager.GetByName(classroomName);
            ClassroomFunctions.ShowClassrooms(classrooms);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 5:
            int classroomId;
            int teacherId;
            Classroom classroom;
            Teacher teacher;

            Console.Write("\nSorumlu Öğretmen Atamak İstediğiniz Sınıfın Id Numarasını Giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out classroomId) || classroomId <= 0)
            {
                Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
            }

            classroom = classroomManager.GetById(classroomId);

            if (classroom != null)
            {
                Console.Write("\nAtamak İstediğiniz Sorumlu Öğretmenin Id Numarasını Giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out teacherId) || teacherId <= 0)
                {
                    Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
                }

                teacher = teacherManager.GetById(teacherId);

                if (teacher != null)
                {
                    classroomManager.AssignResponsibleTeacher(teacher, classroom);
                }

                else
                {
                    Console.Write("\nId`si Verilen Öğretmen Bulunamadığı İçin İşlem Sonlandırıldı!\n");
                }
            }

            else
            {
                Console.Write("\nId`si Verilen Sınıf Bulunamadığı İçin İşlem Sonlandırıldı!\n");
            }

            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 6:
            int classroomIdForAssign;
            int studentId;
            Classroom classroomForAssign;
            Student student;

            Console.Write("\nÖğrenci Atamak İstediğiniz Sınıfın Id Numarasını Giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out classroomIdForAssign) || classroomIdForAssign <= 0)
            {
                Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
            }

            classroomForAssign = classroomManager.GetById(classroomIdForAssign);

            if (classroomForAssign != null)
            {
                Console.Write($"\nAtamak İstediğiniz Öğrencinin Id Numarasını Giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out studentId) || studentId <= 0)
                {
                    Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
                }

                student = studentManager.GetById(studentId);

                if (student != null)
                {
                    classroomManager.AssignStudent(student, classroomForAssign);
                }

                else
                {
                    Console.Write("\nId`si Verilen Öğrenci Bulunamadığı İçin İşlem Sonlandırıldı!\n");
                }
            }

            else
            {
                Console.Write("\nId`si Verilen Sınıf Bulunamadığı İçin İşlem Sonlandırıldı!\n");
            }

            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 7:
            break;
        default:
            Console.WriteLine("\nGeçersiz Seçim, Lütfen Tekrar Deneyin!");
            Thread.Sleep(500);
            break;
    }
}

void StudentMenu(int secim)
{
    switch (secim)
    {
        case 1:
            var addedStudent = StudentFunctions.CreateStudent();
            studentManager.Add(addedStudent);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 2:
            var allStudents = studentManager.GetAll();
            StudentFunctions.ShowStudents(allStudents);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 3:
            int studentIdForView;
            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Öğrencinin Id Numarasını Giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out studentIdForView) || studentIdForView <= 0)
            {
                Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
            }
            var student = studentManager.GetById(studentIdForView);
            StudentFunctions.ShowStudent(student);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 4:
            string studentFirstName;
            string studentLastName;

            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Öğrencinin Adını Giriniz: ");
            do
            {
                studentFirstName = Console.ReadLine();
                if (!studentFirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(studentFirstName))
                {
                    Console.Write("\nLütfen Geçerli Bir Ad Giriniz: ");
                }
            } while (!studentFirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(studentFirstName));

            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Öğrencinin Soyadını Giriniz: ");
            do
            {
                studentLastName = Console.ReadLine();
                if (!studentLastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(studentLastName))
                {
                    Console.Write("\nLütfen Geçerli Bir Soyad Giriniz: ");
                }
            } while (!studentLastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(studentLastName));

            var students = studentManager.GetByName(studentFirstName, studentLastName);
            StudentFunctions.ShowStudents(students);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 5:
            int studentIdForAssignment;
            Console.Write("\nÖdevini Göndermek İstediğiniz Öğrencinin Id Numarasını Giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out studentIdForAssignment) || studentIdForAssignment <= 0)
            {
                Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
            }

            student = studentManager.GetById(studentIdForAssignment);

            if (student != null)
            {
                studentManager.SendAssignment(studentIdForAssignment);
            }

            else
            {
                Console.Write("\nId`si Verilen Öğrenci Bulunamadığı İçin İşlem Sonlandırıldı!\n");
            }
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 6:
            break;
        default:
            Console.WriteLine("\nGeçersiz Seçim, Lütfen Tekrar Deneyin!");
            Thread.Sleep(500);
            break;
    }
}

void TeacherMenu(int secim)
{
    switch (secim)
    {
        case 1:
            var addedTeacher = TeacherFunctions.CreateTeacher();
            teacherManager.Add(addedTeacher);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
            break;
        case 2:
            var allTeachers = teacherManager.GetAll();
            TeacherFunctions.ShowTeachers(allTeachers);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 3:
            int teacherIdForView;
            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Öğretmenin Id Numarasını Giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out teacherIdForView) || teacherIdForView <= 0)
            {
                Console.Write("\nLütfen Sadece Pozitif Tam Sayı Girin: ");
            }
            var teacher = teacherManager.GetById(teacherIdForView);
            TeacherFunctions.ShowTeacher(teacher);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 4:
            string teacherFirstName;
            string teacherLastName;

            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Öğretmenin Adını Giriniz: ");
            do
            {
                teacherFirstName = Console.ReadLine();
                if (!teacherFirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacherFirstName))
                {
                    Console.Write("\nLütfen Geçerli Bir Ad Giriniz: ");
                }
            } while (!teacherFirstName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacherFirstName));

            Console.Write("\nBilgilerini Görüntülemek İstediğiniz Öğretmenin Soyadını Giriniz: ");
            do
            {
                teacherLastName = Console.ReadLine();
                if (!teacherLastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacherLastName))
                {
                    Console.Write("\nLütfen Geçerli Bir Soyad Giriniz: ");
                }
            } while (!teacherLastName.All(c => Char.IsLetter(c)) || string.IsNullOrEmpty(teacherLastName));

            var teachers = teacherManager.GetByName(teacherFirstName, teacherLastName);
            TeacherFunctions.ShowTeachers(teachers);
            Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basın ");
            Console.ReadKey();
            break;
        case 5:
            break;
        default:
            Console.WriteLine("\nGeçersiz Seçim, Lütfen Tekrar Deneyin!");
            Thread.Sleep(500);
            break;
    }
}