using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyTinyCollege.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Number)]
        public int CourseID { get; set; }//PK - Note -with No identity Property
        [StringLength(50, MinimumLength =3)]
        public string Title { get; set; }
        [Range(0,5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        //Navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual Department Department { get; set; }

        public string CourseIdTitle
        {
            get
            {
                return CourseID + ": " + Title;
            }
        }

    }
}