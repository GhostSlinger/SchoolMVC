using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class Instructor
{
    [Key, Required]
    public int InstructorID { get; set; }
    public virtual OfficeAssignment OfficeAssignment { get; set; }


    [Required, StringLength(50)]
    public string LastName { get; set; }

    [Required, StringLength(50)]
    public string FirstMidName { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime HireDate { get; set; }

    public virtual List<CourseAssignment> CourseAssignments { get; set; }
}

