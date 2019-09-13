namespace Adrestia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnMessaging = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.reporting1 = new Adrestia.Reporting();
            this.students1 = new Adrestia.Students();
            this.messaging1 = new Adrestia.Messaging();
            this.instructors1 = new Adrestia.Instructors();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnMessaging);
            this.panel1.Controls.Add(this.btnReporting);
            this.panel1.Controls.Add(this.btnInstructors);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 666);
            this.panel1.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(0, 500);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 75);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup Data";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnMessaging
            // 
            this.btnMessaging.FlatAppearance.BorderSize = 0;
            this.btnMessaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessaging.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnMessaging.ForeColor = System.Drawing.Color.White;
            this.btnMessaging.Location = new System.Drawing.Point(0, 400);
            this.btnMessaging.Name = "btnMessaging";
            this.btnMessaging.Size = new System.Drawing.Size(200, 75);
            this.btnMessaging.TabIndex = 3;
            this.btnMessaging.Text = "Messaging";
            this.btnMessaging.UseVisualStyleBackColor = true;
            this.btnMessaging.Click += new System.EventHandler(this.BtnMessaging_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnReporting.ForeColor = System.Drawing.Color.White;
            this.btnReporting.Location = new System.Drawing.Point(0, 300);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(200, 75);
            this.btnReporting.TabIndex = 2;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.BtnReporting_Click);
            // 
            // btnInstructors
            // 
            this.btnInstructors.FlatAppearance.BorderSize = 0;
            this.btnInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructors.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructors.ForeColor = System.Drawing.Color.White;
            this.btnInstructors.Location = new System.Drawing.Point(0, 100);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(200, 75);
            this.btnInstructors.TabIndex = 1;
            this.btnInstructors.Text = "Instructors";
            this.btnInstructors.UseVisualStyleBackColor = true;
            this.btnInstructors.Click += new System.EventHandler(this.BtnInstructors_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(0, 200);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(200, 75);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.BtnStudents_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::Adrestia.Properties.Resources.LogoutIcon;
            this.btnLogout.Location = new System.Drawing.Point(3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(53, 58);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // reporting1
            // 
            this.reporting1.BackColor = System.Drawing.Color.White;
            this.reporting1.Location = new System.Drawing.Point(200, 0);
            this.reporting1.Name = "reporting1";
            this.reporting1.Size = new System.Drawing.Size(1000, 666);
            this.reporting1.TabIndex = 4;
            // 
            // students1
            // 
            this.students1.Location = new System.Drawing.Point(200, 0);
            this.students1.Name = "students1";
            this.students1.Size = new System.Drawing.Size(1000, 666);
            this.students1.TabIndex = 3;
            // 
            // messaging1
            // 
            this.messaging1.Location = new System.Drawing.Point(200, 0);
            this.messaging1.Name = "messaging1";
            this.messaging1.Size = new System.Drawing.Size(988, 666);
            this.messaging1.TabIndex = 2;
            // 
            // instructors1
            // 
            this.instructors1.Location = new System.Drawing.Point(200, 0);
            this.instructors1.Name = "instructors1";
            this.instructors1.Size = new System.Drawing.Size(1000, 666);
            this.instructors1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.reporting1);
            this.Controls.Add(this.students1);
            this.Controls.Add(this.messaging1);
            this.Controls.Add(this.instructors1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adrestia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMessaging;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnStudents;
        private Instructors instructors1;
        private System.Windows.Forms.Button btnBackup;
        private Messaging messaging1;
        private Students students1;
        private Reporting reporting1;
        private System.Windows.Forms.Button btnLogout;
    }
}

