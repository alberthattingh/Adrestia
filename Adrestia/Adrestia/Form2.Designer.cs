namespace Adrestia
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.lessonsInstructor1 = new Adrestia.LessonsInstructor();
            this.messaging1 = new Adrestia.Messaging();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 666);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 71);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(0, 114);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(200, 71);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // lessonsInstructor1
            // 
            this.lessonsInstructor1.Location = new System.Drawing.Point(206, 12);
            this.lessonsInstructor1.Name = "lessonsInstructor1";
            this.lessonsInstructor1.Size = new System.Drawing.Size(1000, 666);
            this.lessonsInstructor1.TabIndex = 2;
            this.lessonsInstructor1.Load += new System.EventHandler(this.LessonsInstructor1_Load);
            // 
            // messaging1
            // 
            this.messaging1.Location = new System.Drawing.Point(196, 0);
            this.messaging1.Name = "messaging1";
            this.messaging1.Size = new System.Drawing.Size(988, 666);
            this.messaging1.TabIndex = 3;
            this.messaging1.Load += new System.EventHandler(this.Messaging1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.messaging1);
            this.Controls.Add(this.lessonsInstructor1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStudents;
        private LessonsInstructor lessonsInstructor1;
        private Messaging messaging1;
    }
}