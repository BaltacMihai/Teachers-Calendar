using _1064_Baltac_Mihai_Cristian.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1064_Baltac_Mihai_Cristian
{
    public partial class EditFormRoom : Form
    {
        Room room = new Room();
        public EditFormRoom(Room r)
        {
            InitializeComponent();
            room = r;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int.TryParse(tbNumber.Text, out int Number1);
            room.Number = Number1;
	    room.Date = tbDate.Text;
room.Type = tbType.Text;
room.Hour = tbHour.Text;
room.teacher.Name = tbTeacher.Text;
room.subject.Name = tbSubject.Text;

this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFormRoom_Load(object sender, EventArgs e)
        {
            tbNumber.Text = room.Number.ToString();
            tbDate.Text = room.Date;
            tbType.Text = room.Type;
            tbHour.Text = room.Hour;
            tbTeacher.Text = room.teacher.Name;
            tbSubject.Text = room.subject.Name;
        }
    }
}
