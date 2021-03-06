﻿namespace Adrestia
{
    partial class btnEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnEvents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpcoming = new System.Windows.Forms.Button();
            this.btnMessaging = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnBookLessons = new System.Windows.Forms.Button();
            this.messaging1 = new Adrestia.Messaging();
            this.studentLessons1 = new Adrestia.StudentLessons();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.upcoming1 = new Adrestia.Upcoming();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnUpcoming);
            this.panel1.Controls.Add(this.btnMessaging);
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.btnBookLessons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 666);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::Adrestia.Properties.Resources.LogoutIcon;
            this.btnLogout.Location = new System.Drawing.Point(3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 54);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnUpcoming
            // 
            this.btnUpcoming.FlatAppearance.BorderSize = 0;
            this.btnUpcoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpcoming.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpcoming.ForeColor = System.Drawing.Color.White;
            this.btnUpcoming.Location = new System.Drawing.Point(0, 346);
            this.btnUpcoming.Name = "btnUpcoming";
            this.btnUpcoming.Size = new System.Drawing.Size(200, 75);
            this.btnUpcoming.TabIndex = 5;
            this.btnUpcoming.Text = "Upcoming Events";
            this.btnUpcoming.UseVisualStyleBackColor = true;
            this.btnUpcoming.Click += new System.EventHandler(this.BtnUpcoming_Click);
            // 
            // btnMessaging
            // 
            this.btnMessaging.FlatAppearance.BorderSize = 0;
            this.btnMessaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessaging.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessaging.ForeColor = System.Drawing.Color.White;
            this.btnMessaging.Location = new System.Drawing.Point(0, 446);
            this.btnMessaging.Name = "btnMessaging";
            this.btnMessaging.Size = new System.Drawing.Size(200, 75);
            this.btnMessaging.TabIndex = 4;
            this.btnMessaging.Text = "Messaging";
            this.btnMessaging.UseVisualStyleBackColor = true;
            this.btnMessaging.Click += new System.EventHandler(this.BtnMessaging_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(0, 146);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(200, 75);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // btnBookLessons
            // 
            this.btnBookLessons.FlatAppearance.BorderSize = 0;
            this.btnBookLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLessons.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookLessons.ForeColor = System.Drawing.Color.White;
            this.btnBookLessons.Location = new System.Drawing.Point(0, 246);
            this.btnBookLessons.Name = "btnBookLessons";
            this.btnBookLessons.Size = new System.Drawing.Size(200, 75);
            this.btnBookLessons.TabIndex = 2;
            this.btnBookLessons.Text = "Book Lesson";
            this.btnBookLessons.UseVisualStyleBackColor = true;
            this.btnBookLessons.Click += new System.EventHandler(this.BtnBookLessons_Click);
            // 
            // messaging1
            // 
            this.messaging1.BackColor = System.Drawing.Color.White;
            this.messaging1.Location = new System.Drawing.Point(200, 0);
            this.messaging1.Name = "messaging1";
            this.helpProvider1.SetShowHelp(this.messaging1, true);
            this.messaging1.Size = new System.Drawing.Size(988, 666);
            this.messaging1.TabIndex = 3;
            this.messaging1.Load += new System.EventHandler(this.Messaging1_Load);
            // 
            // studentLessons1
            // 
            this.studentLessons1.BackColor = System.Drawing.Color.White;
            this.studentLessons1.Location = new System.Drawing.Point(198, 0);
            this.studentLessons1.Name = "studentLessons1";
            this.studentLessons1.Size = new System.Drawing.Size(1000, 666);
            this.studentLessons1.TabIndex = 3;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Program Files\\Adrestia Group\\Adrestia\\res\\help\\User Manual.htm";
            // 
            // upcoming1
            // 
            this.upcoming1.Location = new System.Drawing.Point(198, 0);
            this.upcoming1.Name = "upcoming1";
            this.upcoming1.Size = new System.Drawing.Size(1000, 666);
            this.upcoming1.TabIndex = 4;
            // 
            // btnEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.upcoming1);
            this.Controls.Add(this.studentLessons1);
            this.Controls.Add(this.messaging1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 200);
            this.Name = "btnEvents";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adrestia";
            this.Load += new System.EventHandler(this.BtnEvents_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button btnMessaging;

        private System.Windows.Forms.Button btnBookLessons;

        private System.Windows.Forms.Button btnUpcoming;

        private System.Windows.Forms.Button btnLogout;

        private Messaging messaging1;

        private StudentLessons studentLessons1;


        private System.Windows.Forms.HelpProvider helpProvider1;
        private Upcoming upcoming1;
        private System.Windows.Forms.Button btnEditProfile;
    }
}