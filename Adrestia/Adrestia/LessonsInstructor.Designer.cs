namespace Adrestia
{
    partial class LessonsInstructor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.cbxPrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.ListBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.nudStudents = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.cbxInstuctorID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnDescription = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instructor: Set Time";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(8, 92);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Date:";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(9, 266);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 7;
            this.btnDate.Text = "Select Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.BtnDate_Click);
            // 
            // cbxPrice
            // 
            this.cbxPrice.FormattingEnabled = true;
            this.cbxPrice.Items.AddRange(new object[] {
            "100.00 ",
            "200.00",
            "300.00",
            "400.00",
            "500.00"});
            this.cbxPrice.Location = new System.Drawing.Point(277, 204);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(121, 21);
            this.cbxPrice.TabIndex = 9;
            this.cbxPrice.SelectedIndexChanged += new System.EventHandler(this.CbxPrice_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose Time:";
            // 
            // lbFinal
            // 
            this.lbFinal.FormattingEnabled = true;
            this.lbFinal.Location = new System.Drawing.Point(9, 356);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(226, 173);
            this.lbFinal.TabIndex = 12;
            // 
            // cbxTime
            // 
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "8:00-9:15",
            "9:30-11:00",
            "13:00-14:15",
            "14:30-15:45",
            "16:00-17:45"});
            this.cbxTime.Location = new System.Drawing.Point(277, 92);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(121, 21);
            this.cbxTime.TabIndex = 13;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(279, 119);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 14;
            this.btnTime.Text = "Select Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.BtnTime_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(277, 231);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPrice.TabIndex = 15;
            this.btnPrice.Text = "Choose Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // nudStudents
            // 
            this.nudStudents.Location = new System.Drawing.Point(463, 93);
            this.nudStudents.Name = "nudStudents";
            this.nudStudents.Size = new System.Drawing.Size(191, 20);
            this.nudStudents.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Max Number of Studnts:";
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(463, 119);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(95, 23);
            this.btnStudents.TabIndex = 18;
            this.btnStudents.Text = "Select Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbxInstuctorID
            // 
            this.cbxInstuctorID.FormattingEnabled = true;
            this.cbxInstuctorID.Location = new System.Drawing.Point(463, 204);
            this.cbxInstuctorID.Name = "cbxInstuctorID";
            this.cbxInstuctorID.Size = new System.Drawing.Size(121, 21);
            this.cbxInstuctorID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Instuctor ID:";
            // 
            // btnInsID
            // 
            this.btnInsID.Location = new System.Drawing.Point(463, 231);
            this.btnInsID.Name = "btnInsID";
            this.btnInsID.Size = new System.Drawing.Size(75, 23);
            this.btnInsID.TabIndex = 21;
            this.btnInsID.Text = "Select ID";
            this.btnInsID.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(710, 92);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(198, 20);
            this.tbDescription.TabIndex = 23;
            // 
            // btnDescription
            // 
            this.btnDescription.Location = new System.Drawing.Point(710, 118);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(101, 23);
            this.btnDescription.TabIndex = 24;
            this.btnDescription.Text = "Select Description";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.BtnDescription_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "FINAL LESSON:";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(8, 535);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(75, 23);
            this.btnAddLesson.TabIndex = 26;
            this.btnAddLesson.Text = "Add Lesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Lesson";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LessonsInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxInstuctorID);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudStudents);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.cbxTime);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxPrice);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Name = "LessonsInstructor";
            this.Size = new System.Drawing.Size(1000, 666);
            this.Load += new System.EventHandler(this.LessonsInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.ComboBox cbxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbFinal;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.NumericUpDown nudStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.ComboBox cbxInstuctorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnClear;
    }
}
