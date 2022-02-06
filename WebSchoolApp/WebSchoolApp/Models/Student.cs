using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class Student
{
    [Key, Required]
    public int StudentID { get; set; }

    [Required, StringLength(50)]
    public string FirstMidName { get; set; }

    [Required, StringLength(50)]
    public string LastName { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }

    public virtual List<Enrollment> Enrollments { get; set; }
}

