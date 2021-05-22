using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064_Baltac_Mihai_Cristian.Classes
{
    [Serializable]
  public class Subject
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Teacher { get; set; }

        public String Classname { get; set; }
        public int RoomNumber { get; set; }
    }
}
