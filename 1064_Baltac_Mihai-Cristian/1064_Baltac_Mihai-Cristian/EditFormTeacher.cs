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
    public partial class EditFormTeacher : Form
    {
      
        Teacher teacher;
        public EditFormTeacher(Teacher t1)
        {
            InitializeComponent();

            teacher = t1;
        }

        private void EditFormTeacher_Load_1(object sender, EventArgs e)
        {
            tbName.Text = teacher.Name;
            tbAdress.Text = teacher.Adress;
            tbPhone.Text = teacher.PhoneNumber.ToString();
            tbEmail.Text = teacher.Email;
            tbSubject.Text = teacher.Subject;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            teacher.Name = tbName.Text;
            teacher.Adress = tbAdress.Text;
            int.TryParse(tbPhone.Text, out int Phone);
            teacher.PhoneNumber = Phone;
            teacher.Email = tbEmail.Text;
            teacher.Subject = tbSubject.Text;

            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

