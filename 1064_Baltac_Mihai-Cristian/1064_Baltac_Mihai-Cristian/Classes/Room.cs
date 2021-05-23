using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064_Baltac_Mihai_Cristian.Classes
{
    public class Room
    {
        public int Number { get; set; }
        public String Type { get; set; }
        public String Date { get; set; }
        public String Hour { get; set; }
        public Teacher teacher { get; set; }

        public Subject subject { get; set; }
    }
}
