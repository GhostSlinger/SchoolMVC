using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class CourseAssignment
{
    //[Key, Required]
    //[Column(Order = 1)]
    public int CourseID { get; set; }

    public virtual Course Course { get; set; }


    //[Key, Required]
    //[Column(Order = 2)]
    public int InstructorID { get; set; }

    public virtual Instructor Instructor { get; set; }
}

