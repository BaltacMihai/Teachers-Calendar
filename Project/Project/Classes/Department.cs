using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Classes
{
    class Department
    {
        public String Name { get; set; }
        public String Descriptiom { get; set; }

        public int NumberOfTeachers { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
