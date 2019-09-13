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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnExit);
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
            this.cmbRecipient.Location = new System.Drawing.Point(69, 103);
            this.cmbRecipient.Name = "cmbRecipient";
            this.cmbRecipient.Size = new System.Drawing.Size(237, 21);
            this.cmbRecipient.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipient";
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(69, 183);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(848, 413);
            this.redOutput.TabIndex = 4;
            this.redOutput.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(83, 143);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // rdbReceived
            // 
            this.rdbReceived.AutoSize = true;
            this.rdbReceived.Checked = true;
            this.rdbReceived.Location = new System.Drawing.Point(184, 146);
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
            this.rdbSent.Location = new System.Drawing.Point(261, 146);
            this.rdbSent.Name = "rdbSent";
            this.rdbSent.Size = new System.Drawing.Size(47, 17);
            this.rdbSent.TabIndex = 7;
            this.rdbSent.Text = "Sent";
            this.rdbSent.UseVisualStyleBackColor = true;
            this.rdbSent.CheckedChanged += new System.EventHandler(this.RdbSent_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Adrestia.Properties.Resources.CloseIcon;
            this.btnExit.Location = new System.Drawing.Point(935, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button btnExit;
    }
}
