using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class Course
{
    public int CourseID { get; set; }

    [StringLength(50), MinLength(3)]
    public string Title { get; set; }

    [Range(0,5)]
    public int Credits { get; set; }
    public int DepartmentID { get; set; }
}

