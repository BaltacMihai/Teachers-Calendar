using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Classes
{
    [Serializable]
   public class Teacher
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name + " " + Adress + " 0" + PhoneNumber + " " + Email;
        }
    }
}
