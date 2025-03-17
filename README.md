# Student Management System (SMS)

## 📝 Description
Student Management System (SMS) is a comprehensive software solution designed to help educational institutions manage student data efficiently. It provides features for student enrollment, course management, grade tracking, attendance monitoring, and report generation.

## 🔧 Features
- **Student Management**: Add, update, delete, and search for students.
- **Course Management**: Manage courses, subjects, and assigned instructors.
- **Grades Management**: Record and retrieve student grades.
- **Attendance Tracking**: Monitor student attendance and generate reports.
- **User Authentication & Roles**: Support for admins, teachers, and students.
- **Reports & Statistics**: Generate reports on student performance and other metrics.

## 🏰 Tech Stack
- **Backend**: C#, ASP.NET Core, Entity Framework
- **Frontend**: Razor Pages 
- **Database**: SQL Server
- **Other**: Identity Authentication, API

## 🚀 How to Run
1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/student-management-system.git
   ```
2. Open the project in Visual Studio.
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Apply database migrations:
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```
6. Open a browser and navigate to `http://localhost:5000`.

## 📌 TODO List
- [ ] Complete authentication and authorization system.
- [ ] Implement student grade reports.
- [ ] Add API support for external integrations.

## 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

