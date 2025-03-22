using Models;

namespace Data;

public class DataSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Students.Any())
        {
            context.Students.AddRange(new List<Student>
            {
                new Student { Name = "Nguyen Van A", DateOfBirth = DateTime.Now, Email = "a@gmail.com", PhoneNumber = "0123456789" },
                new Student { Name = "Tran Thi B", DateOfBirth = DateTime.Now, Email = "b@gmail.com", PhoneNumber = "0987654321" }
            });
        }
        
        if (!context.Courses.Any())
        {
            context.Courses.AddRange(new List<Course>
            {
                new Course { Name = "Math", Credits = 3 },
                new Course { Name = "Physics", Credits = 4 }
            });
        }

        context.SaveChanges();
    }
}