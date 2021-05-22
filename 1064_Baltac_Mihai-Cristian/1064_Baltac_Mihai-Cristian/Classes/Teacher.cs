using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064_Baltac_Mihai_Cristian.Classes
{
    [Serializable]
  public  class Teacher
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; }
        public override string ToString()
        {
            return Name + " " + Adress + " " + PhoneNumber + " " + Email + " " + Subject;
        }
    }
}

