
namespace Project
{
    partial class TeacherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvTeachers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAdress = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binOp = new System.Windows.Forms.ToolStripMenuItem();
            this.obSer = new System.Windows.Forms.ToolStripMenuItem();
            this.obDes = new System.Windows.Forms.ToolStripMenuItem();
            this.xml = new System.Windows.Forms.ToolStripMenuItem();
            this.xml_ser = new System.Windows.Forms.ToolStripMenuItem();
            this.xml_dese = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.ToolStripMenuItem();
            this.txtExp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtImp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            this.cms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(12, 363);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(100, 23);
            this.btnAddTeacher.TabIndex = 0;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adress";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(29, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(257, 23);
            this.tbName.TabIndex = 3;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(29, 111);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(257, 23);
            this.tbAdress.TabIndex = 4;
            this.tbAdress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdress_Validating);
            this.tbAdress.Validated += new System.EventHandler(this.tbAdress_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(29, 174);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(257, 23);
            this.tbPhone.TabIndex = 7;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            this.tbPhone.Validated += new System.EventHandler(this.tbPhone_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(29, 235);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(257, 23);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAdress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 296);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Teacher";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(223, 363);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteData.TabIndex = 9;
            this.btnDeleteData.Text = "Clear the Form";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teacher\'s List";
            // 
            // lvTeachers
            // 
            this.lvTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTeachers.FullRowSelect = true;
            this.lvTeachers.HideSelection = false;
            this.lvTeachers.Location = new System.Drawing.Point(344, 72);
            this.lvTeachers.Name = "lvTeachers";
            this.lvTeachers.Size = new System.Drawing.Size(452, 278);
            this.lvTeachers.TabIndex = 11;
            this.lvTeachers.UseCompatibleStateImageBehavior = false;
            this.lvTeachers.View = System.Windows.Forms.View.Details;
            this.lvTeachers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTeachers_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adress";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone Number";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 120;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epAdress
            // 
            this.epAdress.ContainerControl = this;
            // 
            // epPhone
            // 
            this.epPhone.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(696, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(590, 363);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit Data";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.Delete});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(108, 48);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(107, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binOp,
            this.xml,
            this.text});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binOp
            // 
            this.binOp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obSer,
            this.obDes});
            this.binOp.Name = "binOp";
            this.binOp.Size = new System.Drawing.Size(107, 20);
            this.binOp.Text = "Binar Operations";
            // 
            // obSer
            // 
            this.obSer.Name = "obSer";
            this.obSer.Size = new System.Drawing.Size(150, 22);
            this.obSer.Text = "Serialization";
            this.obSer.Click += new System.EventHandler(this.obSer_Click);
            // 
            // obDes
            // 
            this.obDes.Name = "obDes";
            this.obDes.Size = new System.Drawing.Size(150, 22);
            this.obDes.Text = "Deserialization";
            this.obDes.Click += new System.EventHandler(this.obDes_Click);
            // 
            // xml
            // 
            this.xml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xml_ser,
            this.xml_dese});
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(43, 20);
            this.xml.Text = "XML";
            // 
            // xml_ser
            // 
            this.xml_ser.Name = "xml_ser";
            this.xml_ser.Size = new System.Drawing.Size(150, 22);
            this.xml_ser.Text = "Serialization";
            this.xml_ser.Click += new System.EventHandler(this.xml_ser_Click);
            // 
            // xml_dese
            // 
            this.xml_dese.Name = "xml_dese";
            this.xml_dese.Size = new System.Drawing.Size(150, 22);
            this.xml_dese.Text = "Deserialization";
            this.xml_dese.Click += new System.EventHandler(this.xml_dese_Click);
            // 
            // text
            // 
            this.text.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtExp,
            this.txtImp});
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(62, 20);
            this.text.Text = "Text File";
            // 
            // txtExp
            // 
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(110, 22);
            this.txtExp.Text = "Export";
            this.txtExp.Click += new System.EventHandler(this.txtExp_Click);
            // 
            // txtImp
            // 
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(110, 22);
            this.txtImp.Text = "Import";
            this.txtImp.Click += new System.EventHandler(this.txtImp_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(826, 421);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.lvTeachers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "Teacher Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            this.cms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epAdress;
        private System.Windows.Forms.ErrorProvider epPhone;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binOp;
        private System.Windows.Forms.ToolStripMenuItem xml;
        private System.Windows.Forms.ToolStripMenuItem text;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem obSer;
        private System.Windows.Forms.ToolStripMenuItem obDes;
        private System.Windows.Forms.ToolStripMenuItem xml_ser;
        private System.Windows.Forms.ToolStripMenuItem xml_dese;
        private System.Windows.Forms.ToolStripMenuItem txtExp;
        private System.Windows.Forms.ToolStripMenuItem txtImp;
    }
}

