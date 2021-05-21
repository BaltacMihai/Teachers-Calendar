using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project
{
    public partial class TeacherForm : Form
    {
        List<Teacher> teachers = new List<Teacher>();
        public TeacherForm()
        {
            InitializeComponent();
        }


     
        private void btnDeleteData_Click(object sender, EventArgs e)
        {

            ClearForm();   
        }

        private void ClearForm()
        {
            tbName.Clear();
            tbAdress.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
        }

        #region CRUD
        //Create
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            bool valid = true;

            string Name = tbName.Text;
            if (String.IsNullOrEmpty(Name) ||
                Name.Length < 5)
                valid = false;

            string Adress = tbAdress.Text;
            if (String.IsNullOrEmpty(Adress) ||
             Adress.Length < 5)
                valid = false;



            int.TryParse(tbPhone.Text, out int PhoneNumber);
            if (String.IsNullOrEmpty(tbPhone.Text) ||
                String.IsNullOrWhiteSpace(tbPhone.Text) ||
                (tbPhone.Text).Length != 10)
                valid = false;



            string Email = tbEmail.Text;
            if (String.IsNullOrEmpty(Email) ||
            Email.Length < 5 ||
           !Email.Contains('@')
            )
                valid = false;
            if (valid)
            {
                //create the object
                Teacher t1 = new Teacher();
                t1.Name = Name;
                t1.Adress = Adress;
                t1.PhoneNumber = PhoneNumber;
                t1.Email = Email;

                MessageBox.Show(t1.ToString(), "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //add in the list ( collections)

                teachers.Add(t1);

                populateListView();

                ClearForm();

            }
            else
            {
                MessageBox.Show("The data is worng", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }



        }

        //Read
        private void populateListView()
        {
            // clean the list view (UI)
            lvTeachers.Items.Clear();

            //add in the list view

            foreach (Teacher t in teachers)
            {
                ListViewItem lvi = new ListViewItem(new String[]
                    { t.Name, t.Adress,  t.PhoneNumber.ToString() , t.Email});


                lvi.Tag = t;

                lvTeachers.Items.Add(lvi);

            }
        }

        //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvTeachers.SelectedItems.Count != 0)
            {
                Teacher t1 = teachers.ElementAt(lvTeachers.SelectedIndices[0]);

                EditFormTeacher edit = new EditFormTeacher(t1);
                edit.ShowDialog();

                //actualizate the information in the list view
                populateListView();
            }

           

            //actualizate the information in the list view
            populateListView();
        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvTeachers.SelectedItems.Count != 0)
            {
                if(
                MessageBox.Show("Do you want to delete this entry", "Delete Teacher",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    Teacher t1 = teachers.ElementAt(lvTeachers.SelectedIndices[0]);
                    teachers.Remove(t1);

                    populateListView();
                }
            }
        }



        #endregion

        #region Validatori
        private void tbName_Validating(object sender, CancelEventArgs e)
        {

            string Name = tbName.Text;
            if (String.IsNullOrEmpty(Name) ||
                Name.Length < 5)
            {
                epName.SetError(tbName, "The name must be greater then 5 characters");
                e.Cancel = true;
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            epName.Clear();
        }

        private void tbAdress_Validated(object sender, EventArgs e)
        {
            epAdress.Clear();
        }

        private void tbAdress_Validating(object sender, CancelEventArgs e)
        {
            string Adress = tbAdress.Text;
            if (String.IsNullOrEmpty(Adress) ||
             Adress.Length < 5)
            {
                epAdress.SetError(tbAdress, "The address must be > 5 characters");
                e.Cancel = true;
            }
              
        }

        private void tbPhone_Validated(object sender, EventArgs e)
        {
            epPhone.Clear();
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbPhone.Text, out int PhoneNumber);
            if (String.IsNullOrEmpty(tbPhone.Text) ||
                String.IsNullOrWhiteSpace(tbPhone.Text) ||
                (tbPhone.Text).Length != 10)
            {
                epPhone.SetError(tbPhone, "The number must contain 10 numbers");
                e.Cancel = true;
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            epEmail.Clear();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = tbEmail.Text;
            if (String.IsNullOrEmpty(Email) ||
            Email.Length < 5 ||
            !Email.Contains('@')
            )
            {
                epEmail.SetError(tbEmail, "The email must be valid");
                e.Cancel = true;
            }
        }








        #endregion



        private void lvTeachers_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
               
                
            }
        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {

        }

      

        private void Edit_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        #region Serialization/Deserialization/Text files
        private void obSer_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            SaveFileDialog ofd = new SaveFileDialog();


            ofd.Title = "Select a binary file for Serialize";
            ofd.Filter = "Text files(*txt)|*.txt|Binary files(*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(ofd.FileName, FileMode.Create);
                formatter.Serialize(stream, teachers);

                stream.Close();
                MessageBox.Show("Binery.dat is saved succesifull");
                stream.Close();
            }



           
        }

       

        private void obDes_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();


            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Create the binary file";
            ofd.Filter = "Text files(*txt)|*.txt|Binary files(*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                teachers = formatter.Deserialize(stream) as List<Teacher>;

                stream.Close();
                populateListView();
            }
           

         
        }

        private void xml_ser_Click(object sender, EventArgs e)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Teacher>));

            SaveFileDialog ofd = new SaveFileDialog();


            ofd.Title = "Create the Xml file";
            ofd.Filter = "Text files(*txt)|*.txt|Xml files(*.xml)|*.xml|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = File.Create(ofd.FileName);
                serializer.Serialize(stream, teachers);

                stream.Close();
                MessageBox.Show("File.xml is saved succesifull");
                stream.Close();
            }


        }

        private void xml_dese_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Teacher>));


            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Create the binary file";
            ofd.Filter = "Text files(*.txt)|*.txt|Xml files(*.xml)|*.xml|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                teachers = serializer.Deserialize(stream) as List<Teacher>;

                stream.Close();
                populateListView();
            }

        }

        private void txtExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();


            ofd.Title = "Create the text file";
            ofd.Filter = "Text files(*txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(ofd.FileName);
                writer.WriteLine("Name Adress PhoneNumber Email");
                foreach(Teacher t in teachers)
                {
                    writer.WriteLine(t.ToString());
                }
                writer.Close();
            }
        }

        private void txtImp_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Create the text file";
            ofd.Filter = "Text files(*txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName);
                String line = reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        String[] tokens = line.Split(' ');
                        Teacher t = new Teacher();
                        t.Name = tokens[0];
                        t.Adress = tokens[1];
                        t.PhoneNumber = int.Parse(tokens[2]);
                        t.Email = tokens[3];
                        teachers.Add(t);
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            populateListView();


        }


        #endregion
    }
}
