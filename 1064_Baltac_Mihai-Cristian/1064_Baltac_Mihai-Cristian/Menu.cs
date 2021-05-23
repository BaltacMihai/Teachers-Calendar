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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm();
            tf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjectForm sj = new SubjectForm();
            sj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomForm rf = new RoomForm();
            rf.ShowDialog();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.T)
            {
                TeacherForm tf = new TeacherForm();
                tf.ShowDialog();
            }
            if (e.Alt && e.KeyCode == Keys.S)
            {
                SubjectForm sj = new SubjectForm();
                sj.ShowDialog();
            }
            if (e.Alt && e.KeyCode == Keys.R)
            {
                RoomForm rf = new RoomForm();
                rf.ShowDialog();
            }
        }
    }
}
