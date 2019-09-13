namespace Adrestia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMessaging = new System.Windows.Forms.Button();
            this.btnBookLessons = new System.Windows.Forms.Button();
            this.btnUpcoming = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnUpcoming);
            this.panel1.Controls.Add(this.btnMessaging);
            this.panel1.Controls.Add(this.btnBookLessons);
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
            this.btnMessaging.TabIndex = 4;
            this.btnMessaging.Text = "Messaging";
            this.btnMessaging.UseVisualStyleBackColor = true;
            this.btnMessaging.Click += new System.EventHandler(this.BtnMessaging_Click);
            // 
            // btnBookLessons
            // 
            this.btnBookLessons.FlatAppearance.BorderSize = 0;
            this.btnBookLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLessons.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookLessons.ForeColor = System.Drawing.Color.White;
            this.btnBookLessons.Location = new System.Drawing.Point(0, 100);
            this.btnBookLessons.Name = "btnBookLessons";
            this.btnBookLessons.Size = new System.Drawing.Size(200, 75);
            this.btnBookLessons.TabIndex = 2;
            this.btnBookLessons.Text = "Book Lesson";
            this.btnBookLessons.UseVisualStyleBackColor = true;
            this.btnBookLessons.Click += new System.EventHandler(this.BtnBookLessons_Click);
            // 
            // btnUpcoming
            // 
            this.btnUpcoming.FlatAppearance.BorderSize = 0;
            this.btnUpcoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpcoming.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpcoming.ForeColor = System.Drawing.Color.White;
            this.btnUpcoming.Location = new System.Drawing.Point(0, 200);
            this.btnUpcoming.Name = "btnUpcoming";
            this.btnUpcoming.Size = new System.Drawing.Size(200, 75);
            this.btnUpcoming.TabIndex = 5;
            this.btnUpcoming.Text = "Upcoming Events";
            this.btnUpcoming.UseVisualStyleBackColor = true;
            this.btnUpcoming.Click += new System.EventHandler(this.BtnUpcoming_Click);
            // 
            // btnEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 200);
            this.Name = "btnEvents";
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMessaging;
        private System.Windows.Forms.Button btnBookLessons;
        private System.Windows.Forms.Button btnUpcoming;
    }
}