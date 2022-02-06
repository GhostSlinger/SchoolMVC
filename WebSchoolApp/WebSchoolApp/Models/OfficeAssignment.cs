using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchoolApp.Models;

public class OfficeAssignment
{
    [Required]
    public int InstructorID { get; set; }

    [StringLength(50)]
    public string Location { get; set; }
}

