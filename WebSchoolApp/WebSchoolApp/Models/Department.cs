using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class Department
{
    [Key, Required]
    public int DepartmentID { get; set; }

    [StringLength(50), MinLength(3)]
    public string Name { get; set; }

    [DataType(DataType.Currency)]
    public decimal Budget { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [ForeignKey(nameof(Instructor)), Required]
    public int InstructorID { get; set; }
    public virtual Instructor Instructor { get; set; }

    public virtual List<Course> Courses { get; set; }
}

