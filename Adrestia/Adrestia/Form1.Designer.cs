
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMessaging = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.messaging1 = new Adrestia.Messaging();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            this.button1 = new System.Windows.Forms.Button();
            this.lessonsInstructor1 = new Adrestia.LessonsInstructor();
            this.students1 = new Adrestia.Students();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnMessaging);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 666);
            this.panel1.TabIndex = 0;
            // 
            // btnMessaging
            // 
            this.btnMessaging.Location = new System.Drawing.Point(0, 185);
            this.btnMessaging.Name = "btnMessaging";
            this.btnMessaging.Size = new System.Drawing.Size(200, 71);
            this.btnMessaging.TabIndex = 2;
            this.btnMessaging.Text = "Messaging";
            this.btnMessaging.UseVisualStyleBackColor = true;
            this.btnMessaging.Click += new System.EventHandler(this.BtnMessaging_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 71);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(0, 114);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(200, 71);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.BtnStudents_Click);
            // 
            // messaging1
            // 
            this.messaging1.Location = new System.Drawing.Point(207, 0);
            this.messaging1.Name = "messaging1";
            this.messaging1.Size = new System.Drawing.Size(1000, 666);
            this.messaging1.TabIndex = 1;
            // 
            // lessonsInstructor1
            // 
            this.lessonsInstructor1.Location = new System.Drawing.Point(197, 0);
            this.lessonsInstructor1.Name = "lessonsInstructor1";
            this.lessonsInstructor1.Size = new System.Drawing.Size(1000, 666);
            this.lessonsInstructor1.TabIndex = 2;
            this.lessonsInstructor1.Load += new System.EventHandler(this.LessonsInstructor1_Load);
            // 
            // students1
            // 
            this.students1.Location = new System.Drawing.Point(197, -3);
            this.students1.Name = "students1";
            this.students1.Size = new System.Drawing.Size(1000, 666);
            this.students1.TabIndex = 1;
            this.students1.Visible = false;
            this.students1.Load += new System.EventHandler(this.Students1_Load);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(0, 595);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 71);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.messaging1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Adrestia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        private System.Windows.Forms.Button btnHome;
        private Messaging messaging1;
        private System.Windows.Forms.Button btnMessaging;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button button1;
        private LessonsInstructor lessonsInstructor1;