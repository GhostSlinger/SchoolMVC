using Microsoft.EntityFrameworkCore;

namespace WebSchoolApp.Data;

public class WebSchoolAppContext : DbContext
{
    // ORM creates the dependency injection here, the instance of this
    public WebSchoolAppContext(DbContextOptions<WebSchoolAppContext> options) : base(options)
    { }

    public DbSet<Student> Students { get; set; }

    public DbSet<Enrollment> Enrollments { get; set; }

    public DbSet<Course> Courses { get; set; }

    public DbSet<Department> Departments { get; set; }

    public DbSet<Instructor> Instructors { get; set; }

    public DbSet<CourseAssignment> CourseAssignments { get; set; }

    public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
}

