
using Microsoft.EntityFrameworkCore;
using StudentManagementWebApi.Entities;

namespace StudentManagementWebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentManagementDbContext(serviceProvider.GetRequiredService<DbContextOptions<StudentManagementDbContext>>()))
            {

                context.Courses.AddRange(
                    new Course { Name="Müzik", Price=4000, TimeDuration="10 AY",TeacherId=1},
                    new Course { Name="Kimya", Price=3000, TimeDuration="5 AY",TeacherId=3},
                    new Course { Name="Fizik", Price=4500, TimeDuration="2 AY",TeacherId=2},
                    new Course { Name="Dinamik", Price=2000, TimeDuration="6 AY",TeacherId=4}
                );

                context.Students.AddRange
                (
                    new Student { Name="Emre", SurName="Taş", PhoneNumber="5321234365", Adress="BEŞİKTAŞ", Email="et@mail.com"},
                    new Student { Name="Enes", SurName="Yıldız", PhoneNumber="5327654877", Adress="ORTAKÖY", Email="ey@mail.com"},
                    new Student { Name="Eray", SurName="ATİK", PhoneNumber="5328771237", Adress="NİŞANTAŞI", Email="ea@mail.com"}
                );

                
                context.Teachers.AddRange
                (
                    new Teacher { Name="Ersin", SurName="Keskin", Qulification="Müzik" },
                    new Teacher { Name="Ali", SurName="Özyurt", Qulification="Kimya" },
                    new Teacher { Name="Semih", SurName="Ressam", Qulification="Fizik" },
                    new Teacher { Name="Sinan", SurName="Arı", Qulification="Dinamik" }
                );

                context.StudentCourses.AddRange(
                    new StudentCourse{ StudentId = 1, CourseId = 1},
                    new StudentCourse{ StudentId = 1, CourseId = 3},
                    new StudentCourse{ StudentId = 2, CourseId = 1},
                    new StudentCourse{ StudentId = 2, CourseId = 2},
                    new StudentCourse{ StudentId = 2, CourseId = 3},
                    new StudentCourse{ StudentId = 2, CourseId = 4},
                    new StudentCourse{ StudentId = 3, CourseId = 2},
                    new StudentCourse{ StudentId = 3, CourseId = 4}       
                    );

                context.Users.AddRange(
                    new User { Name = "Songül", Surname = "Oltu", Email = "so@mail.com", Password = "123456", RefreshToken="" },
                    new User { Name = "Esin", Surname = "Kar", Email = "ek@mail.com", Password = "654321", RefreshToken="" }, 
                    new User { Name = "Kadir", Surname = "Baş", Email = "kb@mail.com", Password = "123456789", RefreshToken="" }      
                    );

                context.SaveChanges();
            }
        }
    }
}