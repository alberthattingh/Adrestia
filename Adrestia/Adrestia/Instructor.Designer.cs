namespace Adrestia
{
    partial class Instructors_UC_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewInstructor = new System.Windows.Forms.Button();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.txtChangeDetails = new System.Windows.Forms.TextBox();
            this.btnDeleteInstructor = new System.Windows.Forms.Button();
            this.txtDeleteInstructor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(30, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 572);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrolled instructors";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 541);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnNewInstructor
            // 
            this.btnNewInstructor.Location = new System.Drawing.Point(1111, 141);
            this.btnNewInstructor.Name = "btnNewInstructor";
            this.btnNewInstructor.Size = new System.Drawing.Size(151, 46);
            this.btnNewInstructor.TabIndex = 5;
            this.btnNewInstructor.Text = "New Instructor";
            this.btnNewInstructor.UseVisualStyleBackColor = true;
            this.btnNewInstructor.Click += new System.EventHandler(this.BtnNewInstructor_Click);
            // 
            // btnChangeDetails
            // 
            this.btnChangeDetails.Location = new System.Drawing.Point(1111, 193);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(151, 46);
            this.btnChangeDetails.TabIndex = 6;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = true;
            this.btnChangeDetails.Click += new System.EventHandler(this.BtnChangeDetails_Click);
            // 
            // txtChangeDetails
            // 
            this.txtChangeDetails.Location = new System.Drawing.Point(1111, 245);
            this.txtChangeDetails.Name = "txtChangeDetails";
            this.txtChangeDetails.Size = new System.Drawing.Size(151, 22);
            this.txtChangeDetails.TabIndex = 7;
            // 
            // btnDeleteInstructor
            // 
            this.btnDeleteInstructor.Location = new System.Drawing.Point(1111, 273);
            this.btnDeleteInstructor.Name = "btnDeleteInstructor";
            this.btnDeleteInstructor.Size = new System.Drawing.Size(151, 46);
            this.btnDeleteInstructor.TabIndex = 8;
            this.btnDeleteInstructor.Text = "Delete Instructor";
            this.btnDeleteInstructor.UseVisualStyleBackColor = true;
            this.btnDeleteInstructor.Click += new System.EventHandler(this.BtnDeleteInstructor_Click);
            // 
            // txtDeleteInstructor
            // 
            this.txtDeleteInstructor.Location = new System.Drawing.Point(1111, 325);
            this.txtDeleteInstructor.Name = "txtDeleteInstructor";
            this.txtDeleteInstructor.Size = new System.Drawing.Size(151, 22);
            this.txtDeleteInstructor.TabIndex = 9;
            // 
            // Instructors_UC_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDeleteInstructor);
            this.Controls.Add(this.btnDeleteInstructor);
            this.Controls.Add(this.txtChangeDetails);
            this.Controls.Add(this.btnChangeDetails);
            this.Controls.Add(this.btnNewInstructor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Instructors_UC_";
            this.Size = new System.Drawing.Size(1358, 716);
            this.Load += new System.EventHandler(this.Instructors_UC__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewInstructor;
        private System.Windows.Forms.Button btnChangeDetails;
        private System.Windows.Forms.TextBox txtChangeDetails;
        private System.Windows.Forms.Button btnDeleteInstructor;
        private System.Windows.Forms.TextBox txtDeleteInstructor;
    }
}
