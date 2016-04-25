using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTinyCollege.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText ="No Grade")]
        public Grade? Grade { get; set; }

        public virtual Student student { get; set; }//Many enrollments to 1 student
        public virtual Course course { get; set; }

    }
}