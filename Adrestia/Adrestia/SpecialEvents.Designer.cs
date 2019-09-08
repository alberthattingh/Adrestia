namespace Adrestia
{
    partial class SpecialEvents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnShowUpcoming = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Special Events";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 466);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(860, 411);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(137, 20);
            this.txtDelete.TabIndex = 9;
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(860, 319);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(137, 20);
            this.txtEdit.TabIndex = 10;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(860, 350);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(137, 50);
            this.btnDeleteEvent.TabIndex = 6;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.BtnDeleteEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Location = new System.Drawing.Point(860, 258);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(137, 50);
            this.btnEditEvent.TabIndex = 7;
            this.btnEditEvent.Text = "Edit Event";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.BtnEditEvent_Click);
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(860, 197);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(137, 50);
            this.btnNewEvent.TabIndex = 8;
            this.btnNewEvent.Text = "New Event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.BtnNewEvent_Click);
            // 
            // btnShowUpcoming
            // 
            this.btnShowUpcoming.Location = new System.Drawing.Point(204, 98);
            this.btnShowUpcoming.Name = "btnShowUpcoming";
            this.btnShowUpcoming.Size = new System.Drawing.Size(137, 50);
            this.btnShowUpcoming.TabIndex = 11;
            this.btnShowUpcoming.Text = "Show Upcoming Events";
            this.btnShowUpcoming.UseVisualStyleBackColor = true;
            this.btnShowUpcoming.Click += new System.EventHandler(this.BtnShowUpcoming_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(50, 98);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(137, 50);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Show All Events";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // SpecialEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowUpcoming);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "SpecialEvents";
            this.Size = new System.Drawing.Size(1000, 666);
            this.Load += new System.EventHandler(this.SpecialEvents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Button btnShowUpcoming;
        private System.Windows.Forms.Button btnShowAll;
    }
}
