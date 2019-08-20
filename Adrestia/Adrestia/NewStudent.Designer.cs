namespace Adrestia
{
    partial class NewStudent
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(175, 52);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 33);
            this.txtID.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(175, 91);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(155, 33);
            this.txtPass.TabIndex = 0;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(175, 130);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(155, 33);
            this.txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(175, 169);
            this.txtLast.Multiline = true;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(155, 33);
            this.txtLast.TabIndex = 1;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(175, 208);
            this.txtCell.Multiline = true;
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(155, 33);
            this.txtCell.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 247);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 33);
            this.txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cell number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(90, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Name = "NewStudent";
            this.Text = "New Student";
            this.Load += new System.EventHandler(this.NewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}