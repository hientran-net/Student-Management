using Data;

namespace Program;

class Program
{
    static void Main()
    {

        using var context = new AppDbContext();
        
        // Seed dữ liệu nếu database trống.
        // DataSeeder.Seed(context);
        
        // Lấy danh sách Sinh Viên từ database 
        var students = context.Students.ToList();
        
        Console.WriteLine("Danh sách sinh viên: ");
        foreach (var item in students)
        {
            Console.WriteLine($"{item.Id} - {item.Name} - {item.PhoneNumber} - {item.Email} - {item.DateOfBirth} ");
        }
    }
}