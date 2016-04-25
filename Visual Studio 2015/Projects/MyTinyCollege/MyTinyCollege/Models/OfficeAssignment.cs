using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTinyCollege.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        [StringLengthAttribute(50)]
        public string Location { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}