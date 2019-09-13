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
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnEditLesson = new System.Windows.Forms.Button();
            this.gbEditDelete = new System.Windows.Forms.GroupBox();
            this.rdpEdit = new System.Windows.Forms.RadioButton();
            this.rdpDelete = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.gbEditDelete.SuspendLayout();
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
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 86);
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
            // cbxPrice
            // 
            this.cbxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrice.FormattingEnabled = true;
            this.cbxPrice.Items.AddRange(new object[] {
            "100.00 ",
            "200.00",
            "300.00",
            "400.00",
            "500.00"});
            this.cbxPrice.Location = new System.Drawing.Point(266, 151);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(121, 21);
            this.cbxPrice.TabIndex = 9;
            this.cbxPrice.TextUpdate += new System.EventHandler(this.CbxPrice_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose Time:";
            // 
            // lbFinal
            // 
            this.lbFinal.FormattingEnabled = true;
            this.lbFinal.Location = new System.Drawing.Point(707, 88);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(275, 160);
            this.lbFinal.TabIndex = 12;
            // 
            // cbxTime
            // 
            this.cbxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "8:00",
            "9:30",
            "13:00",
            "14:30",
            "16:00"});
            this.cbxTime.Location = new System.Drawing.Point(266, 86);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(121, 21);
            this.cbxTime.TabIndex = 13;
            this.cbxTime.TextUpdate += new System.EventHandler(this.CbxTime_TextUpdate);
            // 
            // nudStudents
            // 
            this.nudStudents.Location = new System.Drawing.Point(426, 151);
            this.nudStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStudents.Name = "nudStudents";
            this.nudStudents.Size = new System.Drawing.Size(191, 20);
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
            this.label3.Location = new System.Drawing.Point(423, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Max Number of Studnts:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(426, 87);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(198, 20);
            this.tbDescription.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "FINAL LESSON:";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(707, 254);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(75, 23);
            this.btnAddLesson.TabIndex = 26;
            this.btnAddLesson.Text = "Add Lesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.BtnAddLesson_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(907, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Lesson";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(426, 186);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 33);
            this.btnPreview.TabIndex = 28;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // dgvLessons
            // 
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Location = new System.Drawing.Point(9, 294);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.Size = new System.Drawing.Size(744, 157);
            this.dgvLessons.TabIndex = 29;
            this.dgvLessons.SelectionChanged += new System.EventHandler(this.DgvLessons_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Lessons:";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(6, 454);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(132, 20);
            this.lblSelected.TabIndex = 31;
            this.lblSelected.Text = "Selected Lesson:";
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Location = new System.Drawing.Point(10, 563);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteLesson.TabIndex = 32;
            this.btnDeleteLesson.Text = "Delete Selected Lesson";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.BtnDeleteLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.Location = new System.Drawing.Point(8, 592);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(115, 23);
            this.btnEditLesson.TabIndex = 33;
            this.btnEditLesson.Text = "Edit Lesson: ";
            this.btnEditLesson.UseVisualStyleBackColor = true;
            this.btnEditLesson.Click += new System.EventHandler(this.BtnEditLesson_Click);
            // 
            // gbEditDelete
            // 
            this.gbEditDelete.Controls.Add(this.rdpEdit);
            this.gbEditDelete.Controls.Add(this.rdpDelete);
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
            this.rdpEdit.Size = new System.Drawing.Size(125, 17);
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
            this.rdpDelete.Size = new System.Drawing.Size(138, 17);
            this.rdpDelete.TabIndex = 35;
            this.rdpDelete.TabStop = true;
            this.rdpDelete.Text = "Delete Selected Lesson";
            this.rdpDelete.UseVisualStyleBackColor = true;
            this.rdpDelete.CheckedChanged += new System.EventHandler(this.RdpDelete_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Adrestia.Properties.Resources.CloseIcon;
            this.btnExit.Location = new System.Drawing.Point(947, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 45);
            this.btnExit.TabIndex = 35;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LessonsInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbEditDelete);
            this.Controls.Add(this.btnEditLesson);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvLessons);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.gbEditDelete.ResumeLayout(false);
            this.gbEditDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnEditLesson;
        private System.Windows.Forms.GroupBox gbEditDelete;
        private System.Windows.Forms.RadioButton rdpEdit;
        private System.Windows.Forms.RadioButton rdpDelete;
        private System.Windows.Forms.Button btnExit;
    }
}
