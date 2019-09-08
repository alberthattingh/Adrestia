namespace Adrestia
{
    partial class NewEvent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numPensioners = new System.Windows.Forms.NumericUpDown();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.numAdult = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbVenue = new System.Windows.Forms.ListBox();
            this.btnNewVenue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbType = new System.Windows.Forms.ListBox();
            this.btnNewType = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPensioners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and Time";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:MM";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(73, 87);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(107, 20);
            this.timePicker.TabIndex = 3;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(73, 39);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(107, 20);
            this.datePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numPensioners);
            this.groupBox2.Controls.Add(this.numChildren);
            this.groupBox2.Controls.Add(this.numAdult);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Costs";
            // 
            // numPensioners
            // 
            this.numPensioners.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPensioners.Location = new System.Drawing.Point(74, 114);
            this.numPensioners.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPensioners.Name = "numPensioners";
            this.numPensioners.Size = new System.Drawing.Size(120, 20);
            this.numPensioners.TabIndex = 6;
            // 
            // numChildren
            // 
            this.numChildren.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numChildren.Location = new System.Drawing.Point(74, 78);
            this.numChildren.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(120, 20);
            this.numChildren.TabIndex = 5;
            // 
            // numAdult
            // 
            this.numAdult.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAdult.Location = new System.Drawing.Point(74, 37);
            this.numAdult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAdult.Name = "numAdult";
            this.numAdult.Size = new System.Drawing.Size(120, 20);
            this.numAdult.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Children:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pensioners:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adults:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbVenue);
            this.groupBox3.Controls.Add(this.btnNewVenue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 149);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venue";
            // 
            // lbVenue
            // 
            this.lbVenue.FormattingEnabled = true;
            this.lbVenue.Location = new System.Drawing.Point(85, 39);
            this.lbVenue.Name = "lbVenue";
            this.lbVenue.Size = new System.Drawing.Size(81, 17);
            this.lbVenue.TabIndex = 2;
            // 
            // btnNewVenue
            // 
            this.btnNewVenue.Location = new System.Drawing.Point(54, 91);
            this.btnNewVenue.Name = "btnNewVenue";
            this.btnNewVenue.Size = new System.Drawing.Size(75, 23);
            this.btnNewVenue.TabIndex = 1;
            this.btnNewVenue.Text = "New Venue";
            this.btnNewVenue.UseVisualStyleBackColor = true;
            this.btnNewVenue.Click += new System.EventHandler(this.BtnNewVenue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select venue:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbType);
            this.groupBox4.Controls.Add(this.btnNewType);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(235, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 149);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of Event";
            // 
            // lbType
            // 
            this.lbType.FormattingEnabled = true;
            this.lbType.Location = new System.Drawing.Point(89, 39);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(81, 17);
            this.lbType.TabIndex = 3;
            // 
            // btnNewType
            // 
            this.btnNewType.Location = new System.Drawing.Point(52, 91);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(75, 23);
            this.btnNewType.TabIndex = 2;
            this.btnNewType.Text = "New Type";
            this.btnNewType.UseVisualStyleBackColor = true;
            this.btnNewType.Click += new System.EventHandler(this.BtnNewType_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select Date:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(177, 354);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewEvent";
            this.Text = "NewEvent";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPensioners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numPensioners;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.NumericUpDown numAdult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbVenue;
        private System.Windows.Forms.Button btnNewVenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbType;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnCancel;
    }
}