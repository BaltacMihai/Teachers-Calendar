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
    public partial class SubjectForm : Form
    {
        AdministrationAplicationContext ctx = new AdministrationAplicationContext();
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                //edit
                Subject subject = subjectBindingSource.Current as Subject;
                subject.Name = tbName.Text;
                subject.Teacher = tbTeacher.Text;
                subject.RoomNumber = int.Parse(tbRoom.Text);
                subject.Classname = tbClassName.Text;
                ctx.Subjects.Update(subject);

            }
            else
            {
                //add
                Subject subject = new Subject();
                subject.Name = tbName.Text;
                subject.Teacher = tbTeacher.Text;
                subject.RoomNumber = int.Parse(tbRoom.Text);
                subject.Classname = tbClassName.Text;

                ctx.Subjects.Add(subject);

            }
            ctx.SaveChanges();
            subjectBindingSource.DataSource = ctx.Subjects.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Do you want to delete ?","Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctx.Subjects.Remove(subjectBindingSource.Current as Subject);
                    ctx.SaveChanges();
                    subjectBindingSource.DataSource = ctx.Subjects.ToList();

                }
            }
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            subjectBindingSource.DataSource = ctx.Subjects.ToList();
        }
    }
}
