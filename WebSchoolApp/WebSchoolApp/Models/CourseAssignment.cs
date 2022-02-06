using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class CourseAssignment
{
    public int CourseID { get; set; }
    public int InstructorID { get; set; }
}

