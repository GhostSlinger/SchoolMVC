using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class Course
{
    [Key, Required]
    public int CourseID { get; set; }

    [StringLength(50), MinLength(3)]
    public string Title { get; set; }

    [Range(0,5)]
    public int Credits { get; set; }

    [ForeignKey(nameof(Department)), Required]
    public int DepartmentID { get; set; }

    public virtual Department Department { get; set; }

    public virtual List<Enrollment> Enrollments { get; set; }

    //[InverseProperty(nameof(CourseAssignment.Course))]
    public virtual List<CourseAssignment> CourseAssignments { get; set;}
}

