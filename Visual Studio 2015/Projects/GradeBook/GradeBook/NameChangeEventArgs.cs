using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class NameChangeEventArgs : EventArgs
    {
        public string existingName { get; set; }

        public string newName { get; set; }
    }
}
