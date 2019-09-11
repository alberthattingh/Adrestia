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
            this.rdpAdmin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Messaging";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbRecipient
            // 
            this.cmbRecipient.FormattingEnabled = true;
            this.cmbRecipient.Location = new System.Drawing.Point(69, 148);
            this.cmbRecipient.Name = "cmbRecipient";
            this.cmbRecipient.Size = new System.Drawing.Size(237, 21);
            this.cmbRecipient.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipient";
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(69, 230);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(432, 247);
            this.redOutput.TabIndex = 4;
            this.redOutput.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(69, 175);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(97, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Load Messages";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // rdbReceived
            // 
            this.rdbReceived.AutoSize = true;
            this.rdbReceived.Checked = true;
            this.rdbReceived.Location = new System.Drawing.Point(172, 181);
            this.rdbReceived.Name = "rdbReceived";
            this.rdbReceived.Size = new System.Drawing.Size(71, 17);
            this.rdbReceived.TabIndex = 6;
            this.rdbReceived.TabStop = true;
            this.rdbReceived.Text = "Received";
            this.rdbReceived.UseVisualStyleBackColor = true;
            this.rdbReceived.CheckedChanged += new System.EventHandler(this.RdbReceived_CheckedChanged);
            // 
            // rdbSent
            // 
            this.rdbSent.AutoSize = true;
            this.rdbSent.Location = new System.Drawing.Point(249, 181);
            this.rdbSent.Name = "rdbSent";
            this.rdbSent.Size = new System.Drawing.Size(47, 17);
            this.rdbSent.TabIndex = 7;
            this.rdbSent.Text = "Sent";
            this.rdbSent.UseVisualStyleBackColor = true;
            this.rdbSent.CheckedChanged += new System.EventHandler(this.RdbSent_CheckedChanged);
            // 
            // cmbReciever
            // 
            this.cmbReciever.FormattingEnabled = true;
            this.cmbReciever.Location = new System.Drawing.Point(84, 39);
            this.cmbReciever.Name = "cmbReciever";
            this.cmbReciever.Size = new System.Drawing.Size(168, 21);
            this.cmbReciever.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(84, 81);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(363, 20);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.TextChanged += new System.EventHandler(this.TxtMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(9, 120);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send:";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.rdpAdmin);
            this.gbUser.Controls.Add(this.rdpStudent);
            this.gbUser.Controls.Add(this.rdpInstructor);
            this.gbUser.Location = new System.Drawing.Point(69, 71);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(315, 58);
            this.gbUser.TabIndex = 14;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Select User Chat:";
            // 
            // rdpStudent
            // 
            this.rdpStudent.AutoSize = true;
            this.rdpStudent.Location = new System.Drawing.Point(6, 19);
            this.rdpStudent.Name = "rdpStudent";
            this.rdpStudent.Size = new System.Drawing.Size(62, 17);
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
            this.rdpInstructor.Size = new System.Drawing.Size(69, 17);
            this.rdpInstructor.TabIndex = 16;
            this.rdpInstructor.TabStop = true;
            this.rdpInstructor.Text = "Instructor";
            this.rdpInstructor.UseVisualStyleBackColor = true;
            this.rdpInstructor.CheckedChanged += new System.EventHandler(this.RdpInstructor_CheckedChanged);
            // 
            // rdpAdmin
            // 
            this.rdpAdmin.AutoSize = true;
            this.rdpAdmin.Location = new System.Drawing.Point(255, 19);
            this.rdpAdmin.Name = "rdpAdmin";
            this.rdpAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdpAdmin.TabIndex = 17;
            this.rdpAdmin.TabStop = true;
            this.rdpAdmin.Text = "Admin";
            this.rdpAdmin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(64, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 162);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Message:";
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.RadioButton rdpAdmin;
        private System.Windows.Forms.RadioButton rdpStudent;
        private System.Windows.Forms.RadioButton rdpInstructor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
