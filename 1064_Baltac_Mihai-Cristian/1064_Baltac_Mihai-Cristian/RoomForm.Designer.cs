
namespace _1064_Baltac_Mihai_Cristian
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lvTeachers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(706, 429);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 41);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit Room";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelData
            // 
            this.btnDelData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelData.Location = new System.Drawing.Point(852, 429);
            this.btnDelData.Name = "btnDelData";
            this.btnDelData.Size = new System.Drawing.Size(140, 41);
            this.btnDelData.TabIndex = 12;
            this.btnDelData.Text = "Delete Room";
            this.btnDelData.UseVisualStyleBackColor = false;
            this.btnDelData.Click += new System.EventHandler(this.btnDelData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(401, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "List of the Room";
            // 
            // lvTeachers
            // 
            this.lvTeachers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvTeachers.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTeachers.FullRowSelect = true;
            this.lvTeachers.HideSelection = false;
            this.lvTeachers.Location = new System.Drawing.Point(404, 29);
            this.lvTeachers.Name = "lvTeachers";
            this.lvTeachers.Size = new System.Drawing.Size(584, 396);
            this.lvTeachers.TabIndex = 10;
            this.lvTeachers.UseCompatibleStateImageBehavior = false;
            this.lvTeachers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hour";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teacher";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Subject";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(233, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 41);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelData_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(12, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTeacher);
            this.groupBox1.Controls.Add(this.tbHour);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(362, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Room";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpDate.Location = new System.Drawing.Point(28, 169);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(310, 23);
            this.dtpDate.TabIndex = 14;
            // 
            // tbSubject
            // 
            this.tbSubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSubject.Location = new System.Drawing.Point(29, 344);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(310, 23);
            this.tbSubject.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subject";
            // 
            // tbTeacher
            // 
            this.tbTeacher.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTeacher.Location = new System.Drawing.Point(28, 285);
            this.tbTeacher.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(310, 23);
            this.tbTeacher.TabIndex = 9;
            // 
            // tbHour
            // 
            this.tbHour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbHour.Location = new System.Drawing.Point(28, 227);
            this.tbHour.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(310, 23);
            this.tbHour.TabIndex = 8;
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbType.Location = new System.Drawing.Point(28, 108);
            this.tbType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(310, 23);
            this.tbType.TabIndex = 6;
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNumber.Location = new System.Drawing.Point(28, 51);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(310, 23);
            this.tbNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1017, 510);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvTeachers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}