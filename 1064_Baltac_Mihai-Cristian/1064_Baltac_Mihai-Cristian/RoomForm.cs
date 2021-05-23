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
    public partial class RoomForm : Form
    {
        List<Room> rooms = new List<Room>();

        #region Utility functions

        private void ClearForm()
        {
            tbNumber.Clear();
            tbType.Clear();
            // dtpDate
            tbHour.Clear();
            tbTeacher.Clear();
            tbSubject.Clear();
        }

        #endregion



        public RoomForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = true;

            int Number = -1;

            try
            {
               Number = int.Parse(tbNumber.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }

            string Type = tbType.Text;

            string Date = dtpDate.Value.ToString();

            string Hour = tbHour.Text;

            Teacher teacher = new Teacher();
            teacher.Name = tbTeacher.Text;

            Subject subject = new Subject();
            subject.Name = tbSubject.Text;



            if (valid)
            {
                //create the object
                Teacher t1 = new Teacher();
                Room r = new Room();
                r.Number = Number;
                r.Type = Type;
                r.Date = Date;
                r.Hour = Hour;
                r.teacher = teacher;
                r.subject = subject;
            

                MessageBox.Show(t1.ToString(), "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //add in the list ( collections)
                rooms.Add(r);

                populateListView();

                ClearForm();

            }
            else
            {
                MessageBox.Show("The data is worng", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        #region CRUD
        //Create
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {


        }

        //Read
        private void populateListView()
        {
            // clean the list view (UI)
            lvTeachers.Items.Clear();

            //add in the list view

            foreach (Room t in rooms)
            {
                ListViewItem lvi = new ListViewItem(new String[]
                    { t.Number.ToString(), t.Type,  t.Date , t.Hour, t.teacher.Name, t.subject.Name});


                lvi.Tag = t;

                lvTeachers.Items.Add(lvi);

            }
        }

        //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvTeachers.SelectedItems.Count != 0)
            {
                Room t1 = rooms.ElementAt(lvTeachers.SelectedIndices[0]);

                //  EditFormTeacher edit = new EditFormTeacher(t1);
                // edit.ShowDialog();

                EditFormRoom edit = new EditFormRoom(t1);
                edit.ShowDialog();

                //actualizate the information in the list view
                populateListView();
            }




        }

        //Delete
        private void btnDelData_Click(object sender, EventArgs e)
        {
            if (lvTeachers.SelectedItems.Count != 0)
            {
                if (
                MessageBox.Show("Do you want to delete this entry", "Delete Teacher",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    Room t1 = rooms.ElementAt(lvTeachers.SelectedIndices[0]);
                    rooms.Remove(t1);

                    populateListView();
                }
            }
        }
        #endregion

    }
}
