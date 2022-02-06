using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public enum GradeType
{
    A = 1,
    B = 2,
    C = 3,
    D = 4,
    E = 5,
    F = 6
}

public class Enrollment
{
    [Key, Required]
    public int EnrollmentID { get; set; }

    [ForeignKey(nameof(Course)), Required]
    public int CourseID { get; set; }
    public virtual Course Course { get; set; }

    [ForeignKey(nameof(Student)), Required]
    public int StudentID { get; set; }
    public virtual Student Student { get; set; }

    public GradeType? Grade { get; set; }
}

