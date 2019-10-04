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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.ListBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.nudStudents = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnEditLesson = new System.Windows.Forms.Button();
            this.gbEditDelete = new System.Windows.Forms.GroupBox();
            this.rdpEdit = new System.Windows.Forms.RadioButton();
            this.rdpDelete = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudents)).BeginInit();
            this.gbEditDelete.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instructor: Set Time";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Location = new System.Drawing.Point(10, 74);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Date:";
            // 
            // cbxPrice
            // 
            this.cbxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.cbxPrice.FormattingEnabled = true;
            this.cbxPrice.Items.AddRange(new object[] {
            "100.00 ",
            "200.00",
            "300.00",
            "400.00",
            "500.00"});
            this.cbxPrice.Location = new System.Drawing.Point(266, 151);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(121, 24);
            this.cbxPrice.TabIndex = 9;
            this.cbxPrice.TextUpdate += new System.EventHandler(this.CbxPrice_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(266, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(263, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose Time:";
            // 
            // lbFinal
            // 
            this.lbFinal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lbFinal.FormattingEnabled = true;
            this.lbFinal.ItemHeight = 16;
            this.lbFinal.Location = new System.Drawing.Point(682, 79);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(275, 148);
            this.lbFinal.TabIndex = 12;
            // 
            // cbxTime
            // 
            this.cbxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "8:00",
            "9:30",
            "13:00",
            "14:30",
            "16:00"});
            this.cbxTime.Location = new System.Drawing.Point(266, 86);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(121, 24);
            this.cbxTime.TabIndex = 13;
            this.cbxTime.TextUpdate += new System.EventHandler(this.CbxTime_TextUpdate);
            // 
            // nudStudents
            // 
            this.nudStudents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.nudStudents.Location = new System.Drawing.Point(419, 151);
            this.nudStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStudents.Name = "nudStudents";
            this.nudStudents.Size = new System.Drawing.Size(191, 24);
            this.nudStudents.TabIndex = 16;
            this.nudStudents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(423, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Max Number of Studnts:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(423, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tbDescription.Location = new System.Drawing.Point(419, 86);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(198, 24);
            this.tbDescription.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(679, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "FINAL LESSON:";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLesson.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnAddLesson.ForeColor = System.Drawing.Color.White;
            this.btnAddLesson.Location = new System.Drawing.Point(667, 233);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(150, 50);
            this.btnAddLesson.TabIndex = 26;
            this.btnAddLesson.Text = "Add Lesson";
            this.btnAddLesson.UseVisualStyleBackColor = false;
            this.btnAddLesson.Click += new System.EventHandler(this.BtnAddLesson_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(832, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Lesson";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreview.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(336, 186);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 50);
            this.btnPreview.TabIndex = 28;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Lessons:";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelected.Location = new System.Drawing.Point(6, 454);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(120, 17);
            this.lblSelected.TabIndex = 31;
            this.lblSelected.Text = "Selected Lesson:";
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteLesson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLesson.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLesson.Location = new System.Drawing.Point(10, 563);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteLesson.TabIndex = 32;
            this.btnDeleteLesson.Text = "Delete Selected Lesson";
            this.btnDeleteLesson.UseVisualStyleBackColor = false;
            this.btnDeleteLesson.Click += new System.EventHandler(this.BtnDeleteLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditLesson.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditLesson.ForeColor = System.Drawing.Color.White;
            this.btnEditLesson.Location = new System.Drawing.Point(166, 563);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(150, 50);
            this.btnEditLesson.TabIndex = 33;
            this.btnEditLesson.Text = "Edit Lesson: ";
            this.btnEditLesson.UseVisualStyleBackColor = false;
            this.btnEditLesson.Click += new System.EventHandler(this.BtnEditLesson_Click);
            // 
            // gbEditDelete
            // 
            this.gbEditDelete.Controls.Add(this.rdpEdit);
            this.gbEditDelete.Controls.Add(this.rdpDelete);
            this.gbEditDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbEditDelete.Location = new System.Drawing.Point(10, 477);
            this.gbEditDelete.Name = "gbEditDelete";
            this.gbEditDelete.Size = new System.Drawing.Size(156, 80);
            this.gbEditDelete.TabIndex = 34;
            this.gbEditDelete.TabStop = false;
            this.gbEditDelete.Text = "Edit/Delete";
            // 
            // rdpEdit
            // 
            this.rdpEdit.AutoSize = true;
            this.rdpEdit.Location = new System.Drawing.Point(6, 50);
            this.rdpEdit.Name = "rdpEdit";
            this.rdpEdit.Size = new System.Drawing.Size(162, 21);
            this.rdpEdit.TabIndex = 35;
            this.rdpEdit.TabStop = true;
            this.rdpEdit.Text = "Edit Selected Lesson";
            this.rdpEdit.UseVisualStyleBackColor = true;
            this.rdpEdit.CheckedChanged += new System.EventHandler(this.RdpEdit_CheckedChanged);
            // 
            // rdpDelete
            // 
            this.rdpDelete.AutoSize = true;
            this.rdpDelete.Location = new System.Drawing.Point(6, 19);
            this.rdpDelete.Name = "rdpDelete";
            this.rdpDelete.Size = new System.Drawing.Size(183, 21);
            this.rdpDelete.TabIndex = 35;
            this.rdpDelete.TabStop = true;
            this.rdpDelete.Text = "Delete Selected Lesson";
            this.rdpDelete.UseVisualStyleBackColor = true;
            this.rdpDelete.CheckedChanged += new System.EventHandler(this.RdpDelete_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(423, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Students in Lesson:";
            // 
            // lbStudents
            // 
            this.lbStudents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(426, 477);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(531, 132);
            this.lbStudents.TabIndex = 36;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudents.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(604, 613);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(150, 50);
            this.btnStudents.TabIndex = 37;
            this.btnStudents.Text = "Load Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 48);
            this.panel1.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Adrestia.Properties.Resources.CloseIcon;
            this.button1.Location = new System.Drawing.Point(937, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(376, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Set Time For Lessons";
            // 
            // dgvLessons
            // 
            this.dgvLessons.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLessons.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLessons.EnableHeadersVisualStyles = false;
            this.dgvLessons.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvLessons.Location = new System.Drawing.Point(10, 298);
            this.dgvLessons.Name = "dgvLessons";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLessons.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLessons.Size = new System.Drawing.Size(744, 157);
            this.dgvLessons.TabIndex = 40;
            this.dgvLessons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLessons_CellContentClick_1);
            this.dgvLessons.SelectionChanged += new System.EventHandler(this.DgvLessons_SelectionChanged_1);
            // 
            // LessonsInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvLessons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbEditDelete);
            this.Controls.Add(this.btnEditLesson);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudStudents);
            this.Controls.Add(this.cbxTime);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Name = "LessonsInstructor";
            this.Size = new System.Drawing.Size(1000, 666);
            this.Load += new System.EventHandler(this.LessonsInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudents)).EndInit();
            this.gbEditDelete.ResumeLayout(false);
            this.gbEditDelete.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbFinal;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.NumericUpDown nudStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnEditLesson;
        private System.Windows.Forms.GroupBox gbEditDelete;
        private System.Windows.Forms.RadioButton rdpEdit;
        private System.Windows.Forms.RadioButton rdpDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvLessons;
    }
}
