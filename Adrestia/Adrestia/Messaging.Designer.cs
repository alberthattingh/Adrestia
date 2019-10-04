namespace Adrestia
{
    partial class Messaging
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRecipient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.redOutput = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.rdbReceived = new System.Windows.Forms.RadioButton();
            this.rdbSent = new System.Windows.Forms.RadioButton();
            this.cmbReciever = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.rdpStudent = new System.Windows.Forms.RadioButton();
            this.rdpInstructor = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Adrestia.Properties.Resources.CloseIcon;
            this.btnExit.Location = new System.Drawing.Point(937, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Messaging";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbRecipient
            // 
            this.cmbRecipient.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.cmbRecipient.FormattingEnabled = true;
            this.cmbRecipient.Location = new System.Drawing.Point(163, 234);
            this.cmbRecipient.Name = "cmbRecipient";
            this.cmbRecipient.Size = new System.Drawing.Size(237, 24);
            this.cmbRecipient.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipient:";
            // 
            // redOutput
            // 
            this.redOutput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.redOutput.Location = new System.Drawing.Point(506, 167);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(458, 348);
            this.redOutput.TabIndex = 4;
            this.redOutput.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(670, 521);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(150, 50);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Load Messages";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // rdbReceived
            // 
            this.rdbReceived.AutoSize = true;
            this.rdbReceived.Checked = true;
            this.rdbReceived.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbReceived.Location = new System.Drawing.Point(670, 138);
            this.rdbReceived.Name = "rdbReceived";
            this.rdbReceived.Size = new System.Drawing.Size(90, 21);
            this.rdbReceived.TabIndex = 6;
            this.rdbReceived.TabStop = true;
            this.rdbReceived.Text = "Received";
            this.rdbReceived.UseVisualStyleBackColor = true;
            this.rdbReceived.CheckedChanged += new System.EventHandler(this.RdbReceived_CheckedChanged);
            // 
            // rdbSent
            // 
            this.rdbSent.AutoSize = true;
            this.rdbSent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbSent.Location = new System.Drawing.Point(799, 138);
            this.rdbSent.Name = "rdbSent";
            this.rdbSent.Size = new System.Drawing.Size(54, 21);
            this.rdbSent.TabIndex = 7;
            this.rdbSent.Text = "Sent";
            this.rdbSent.UseVisualStyleBackColor = true;
            this.rdbSent.CheckedChanged += new System.EventHandler(this.RdbSent_CheckedChanged);
            // 
            // cmbReciever
            // 
            this.cmbReciever.FormattingEnabled = true;
            this.cmbReciever.Location = new System.Drawing.Point(108, 38);
            this.cmbReciever.Name = "cmbReciever";
            this.cmbReciever.Size = new System.Drawing.Size(232, 24);
            this.cmbReciever.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(108, 80);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(232, 24);
            this.txtMessage.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(140, 110);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 50);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send:";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.rdpStudent);
            this.gbUser.Controls.Add(this.rdpInstructor);
            this.gbUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbUser.Location = new System.Drawing.Point(148, 138);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(215, 58);
            this.gbUser.TabIndex = 14;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Select User Chat:";
            // 
            // rdpStudent
            // 
            this.rdpStudent.AutoSize = true;
            this.rdpStudent.Location = new System.Drawing.Point(6, 19);
            this.rdpStudent.Name = "rdpStudent";
            this.rdpStudent.Size = new System.Drawing.Size(75, 21);
            this.rdpStudent.TabIndex = 15;
            this.rdpStudent.TabStop = true;
            this.rdpStudent.Text = "Student";
            this.rdpStudent.UseVisualStyleBackColor = true;
            this.rdpStudent.CheckedChanged += new System.EventHandler(this.RdpStudent_CheckedChanged);
            // 
            // rdpInstructor
            // 
            this.rdpInstructor.AutoSize = true;
            this.rdpInstructor.Location = new System.Drawing.Point(121, 19);
            this.rdpInstructor.Name = "rdpInstructor";
            this.rdpInstructor.Size = new System.Drawing.Size(86, 21);
            this.rdpInstructor.TabIndex = 16;
            this.rdpInstructor.TabStop = true;
            this.rdpInstructor.Text = "Instructor";
            this.rdpInstructor.UseVisualStyleBackColor = true;
            this.rdpInstructor.CheckedChanged += new System.EventHandler(this.RdpInstructor_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(592, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chat:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbReciever);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(40, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 176);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Message:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Media\\Documents\\CMPG 223\\Adrestia\\Adrestia\\Adrestia\\Adrestia\\Main Menu.htm";
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.rdbSent);
            this.Controls.Add(this.rdbReceived);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.redOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRecipient);
            this.Controls.Add(this.panel1);
            this.Name = "Messaging";
            this.Size = new System.Drawing.Size(988, 666);
            this.Load += new System.EventHandler(this.Messaging_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRecipient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox redOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rdbReceived;
        private System.Windows.Forms.RadioButton rdbSent;
        private System.Windows.Forms.ComboBox cmbReciever;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.RadioButton rdpStudent;
        private System.Windows.Forms.RadioButton rdpInstructor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
