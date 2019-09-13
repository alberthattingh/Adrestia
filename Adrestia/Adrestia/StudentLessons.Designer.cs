namespace Adrestia
{
    partial class StudentLessons
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudentLessons = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLessonSum = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBookedLessons = new System.Windows.Forms.ListBox();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnShowBooked = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students: Book Lessons";
            // 
            // dgvStudentLessons
            // 
            this.dgvStudentLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentLessons.Location = new System.Drawing.Point(8, 82);
            this.dgvStudentLessons.Name = "dgvStudentLessons";
            this.dgvStudentLessons.Size = new System.Drawing.Size(609, 187);
            this.dgvStudentLessons.TabIndex = 1;
            this.dgvStudentLessons.SelectionChanged += new System.EventHandler(this.DgvStudentLessons_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Lessons:";
            // 
            // lbLessonSum
            // 
            this.lbLessonSum.FormattingEnabled = true;
            this.lbLessonSum.Location = new System.Drawing.Point(623, 82);
            this.lbLessonSum.Name = "lbLessonSum";
            this.lbLessonSum.Size = new System.Drawing.Size(357, 186);
            this.lbLessonSum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lesson Sumary";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(624, 274);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "My Booked Lesson:";
            // 
            // lbBookedLessons
            // 
            this.lbBookedLessons.FormattingEnabled = true;
            this.lbBookedLessons.Location = new System.Drawing.Point(19, 320);
            this.lbBookedLessons.Name = "lbBookedLessons";
            this.lbBookedLessons.Size = new System.Drawing.Size(845, 212);
            this.lbBookedLessons.TabIndex = 7;
            this.lbBookedLessons.SelectedIndexChanged += new System.EventHandler(this.LbBookedLessons_SelectedIndexChanged);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(19, 567);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(98, 23);
            this.btnCancelBooking.TabIndex = 8;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.BtnCancelBooking_Click);
            // 
            // btnShowBooked
            // 
            this.btnShowBooked.Location = new System.Drawing.Point(19, 538);
            this.btnShowBooked.Name = "btnShowBooked";
            this.btnShowBooked.Size = new System.Drawing.Size(144, 23);
            this.btnShowBooked.TabIndex = 9;
            this.btnShowBooked.Text = "Show Boooked Lessons";
            this.btnShowBooked.UseVisualStyleBackColor = true;
            this.btnShowBooked.Click += new System.EventHandler(this.BtnShowBooked_Click);
            // 
            // StudentLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowBooked);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.lbBookedLessons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLessonSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStudentLessons);
            this.Controls.Add(this.label1);
            this.Name = "StudentLessons";
            this.Size = new System.Drawing.Size(1000, 666);
            this.Load += new System.EventHandler(this.StudentLessons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudentLessons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbLessonSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBookedLessons;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnShowBooked;
    }
}
