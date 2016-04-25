using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTinyCollege.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        [Required]
        [StringLength(65)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Fullname is a calculated property hat returns a value created by concatenating
        // two other properties. Therefore it only has a get accessor, and because of this
        //no fullname column will be generated
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

    }
}