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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMessaging = new System.Windows.Forms.Button();
            this.btnSpecialEvents = new System.Windows.Forms.Button();
            this.btnLessons = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.specialEvents1 = new Adrestia.SpecialEvents();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMessaging);
            this.panel1.Controls.Add(this.btnSpecialEvents);
            this.panel1.Controls.Add(this.btnLessons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 666);
            this.panel1.TabIndex = 1;
            // 
            // btnMessaging
            // 
            this.btnMessaging.FlatAppearance.BorderSize = 0;
            this.btnMessaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessaging.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessaging.ForeColor = System.Drawing.Color.White;
            this.btnMessaging.Location = new System.Drawing.Point(0, 300);
            this.btnMessaging.Name = "btnMessaging";
            this.btnMessaging.Size = new System.Drawing.Size(200, 75);
            this.btnMessaging.TabIndex = 5;
            this.btnMessaging.Text = "Messaging";
            this.btnMessaging.UseVisualStyleBackColor = true;
            this.btnMessaging.Click += new System.EventHandler(this.BtnMessaging_Click);
            // 
            // btnSpecialEvents
            // 
            this.btnSpecialEvents.FlatAppearance.BorderSize = 0;
            this.btnSpecialEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecialEvents.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialEvents.ForeColor = System.Drawing.Color.White;
            this.btnSpecialEvents.Location = new System.Drawing.Point(0, 200);
            this.btnSpecialEvents.Name = "btnSpecialEvents";
            this.btnSpecialEvents.Size = new System.Drawing.Size(200, 75);
            this.btnSpecialEvents.TabIndex = 4;
            this.btnSpecialEvents.Text = "Special Events";
            this.btnSpecialEvents.UseVisualStyleBackColor = true;
            this.btnSpecialEvents.Click += new System.EventHandler(this.BtnSpecialEvents_Click);
            // 
            // btnLessons
            // 
            this.btnLessons.FlatAppearance.BorderSize = 0;
            this.btnLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessons.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessons.ForeColor = System.Drawing.Color.White;
            this.btnLessons.Location = new System.Drawing.Point(0, 100);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Size = new System.Drawing.Size(200, 75);
            this.btnLessons.TabIndex = 3;
            this.btnLessons.Text = "Lessons";
            this.btnLessons.UseVisualStyleBackColor = true;
            this.btnLessons.Click += new System.EventHandler(this.BtnLessons_Click);
            // 
            // specialEvents1
            // 
            this.specialEvents1.AutoSize = true;
            this.specialEvents1.BackColor = System.Drawing.Color.White;
            this.specialEvents1.Location = new System.Drawing.Point(200, 0);
            this.specialEvents1.Name = "specialEvents1";
            this.specialEvents1.Size = new System.Drawing.Size(1000, 666);
            this.specialEvents1.TabIndex = 3;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.specialEvents1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adrestia";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnLessons;
        private System.Windows.Forms.Button btnMessaging;
        private System.Windows.Forms.Button btnSpecialEvents;
        private SpecialEvents specialEvents1;
        private System.Windows.Forms.Button btnLogout;
    }
}