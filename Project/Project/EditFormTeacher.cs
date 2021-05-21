using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class EditFormTeacher : Form
    {
        Teacher teacher;
        public EditFormTeacher(Teacher t1)
        {
            InitializeComponent();

            teacher = t1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            teacher.Name = tbName.Text;
            teacher.Adress = tbAdress.Text;
            int.TryParse(tbPhone.Text, out int Phone);
            teacher.PhoneNumber = Phone;
            teacher.Email = tbEmail.Text;

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFormTeacher_Load(object sender, EventArgs e)
        {
            tbName.Text = teacher.Name;
            tbAdress.Text = teacher.Adress;
            tbPhone.Text = teacher.PhoneNumber.ToString();
            tbEmail.Text = teacher.Email;

        }
    }
}
