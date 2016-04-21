using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTinyCollege.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public string Email { get; set; }

        //Fullname is a calculated property hat returns a value created by concatenating
        // two other properties. Therefore it only has a get accessor, and because of this
        //no fullname column will be generated
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

    }
}