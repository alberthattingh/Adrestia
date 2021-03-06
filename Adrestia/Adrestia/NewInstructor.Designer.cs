﻿namespace Adrestia
{
    partial class NewInstructor
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Enabled = false;
            this.txtInstructorID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtInstructorID.Location = new System.Drawing.Point(143, 28);
            this.txtInstructorID.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstructorID.Multiline = true;
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(150, 24);
            this.txtInstructorID.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(143, 75);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 24);
            this.txtPassword.TabIndex = 7;
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInstructor.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnAddInstructor.Location = new System.Drawing.Point(12, 333);
            this.btnAddInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(150, 50);
            this.btnAddInstructor.TabIndex = 4;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.BtnAddInstructor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(170, 333);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(143, 242);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 24);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cell number:";
            // 
            // txtCellNo
            // 
            this.txtCellNo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtCellNo.Location = new System.Drawing.Point(143, 201);
            this.txtCellNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellNo.Multiline = true;
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(150, 24);
            this.txtCellNo.TabIndex = 2;
            this.txtCellNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCellNo_Validating);
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtLastname.Location = new System.Drawing.Point(143, 160);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(150, 24);
            this.txtLastname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "First name:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtFirstname.Location = new System.Drawing.Point(143, 118);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(150, 24);
            this.txtFirstname.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Salary:";
            // 
            // numSalary
            // 
            this.numSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSalary.Location = new System.Drawing.Point(143, 292);
            this.numSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSalary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(150, 20);
            this.numSalary.TabIndex = 22;
            this.numSalary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Media\\Documents\\CMPG 223\\Adrestia\\Adrestia\\Adrestia\\Adrestia\\Main Menu.htm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewInstructor
            // 
            this.AcceptButton = this.btnAddInstructor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(331, 394);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtCellNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtInstructorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewInstructor";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "New Instructor";
            this.Load += new System.EventHandler(this.NewInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}