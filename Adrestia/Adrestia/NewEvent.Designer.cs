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
            this.btnDeleteVenue = new System.Windows.Forms.Button();
            this.btnEditVenue = new System.Windows.Forms.Button();
            this.cbxVenue = new System.Windows.Forms.ComboBox();
            this.btnNewVenue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnEditType = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnNewType = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
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
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and Time";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:MM";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(111, 71);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(125, 24);
            this.timePicker.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(111, 33);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(125, 24);
            this.datePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
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
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 150);
            this.groupBox2.TabIndex = 3;
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
            this.numPensioners.Location = new System.Drawing.Point(110, 109);
            this.numPensioners.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPensioners.Name = "numPensioners";
            this.numPensioners.Size = new System.Drawing.Size(125, 24);
            this.numPensioners.TabIndex = 6;
            // 
            // numChildren
            // 
            this.numChildren.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numChildren.Location = new System.Drawing.Point(110, 71);
            this.numChildren.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(125, 24);
            this.numChildren.TabIndex = 5;
            // 
            // numAdult
            // 
            this.numAdult.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAdult.Location = new System.Drawing.Point(110, 29);
            this.numAdult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAdult.Name = "numAdult";
            this.numAdult.Size = new System.Drawing.Size(125, 24);
            this.numAdult.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Children:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pensioners:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adults:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteVenue);
            this.groupBox3.Controls.Add(this.btnEditVenue);
            this.groupBox3.Controls.Add(this.cbxVenue);
            this.groupBox3.Controls.Add(this.btnNewVenue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 202);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venue";
            // 
            // btnDeleteVenue
            // 
            this.btnDeleteVenue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteVenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteVenue.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVenue.Location = new System.Drawing.Point(74, 136);
            this.btnDeleteVenue.Name = "btnDeleteVenue";
            this.btnDeleteVenue.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteVenue.TabIndex = 11;
            this.btnDeleteVenue.Text = "Delete";
            this.btnDeleteVenue.UseVisualStyleBackColor = false;
            this.btnDeleteVenue.Click += new System.EventHandler(this.BtnDeleteVenue_Click);
            // 
            // btnEditVenue
            // 
            this.btnEditVenue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditVenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditVenue.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditVenue.Location = new System.Drawing.Point(136, 80);
            this.btnEditVenue.Name = "btnEditVenue";
            this.btnEditVenue.Size = new System.Drawing.Size(100, 50);
            this.btnEditVenue.TabIndex = 10;
            this.btnEditVenue.Text = "Edit";
            this.btnEditVenue.UseVisualStyleBackColor = false;
            this.btnEditVenue.Click += new System.EventHandler(this.BtnEditVenue_Click);
            // 
            // cbxVenue
            // 
            this.cbxVenue.BackColor = System.Drawing.SystemColors.Window;
            this.cbxVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVenue.FormattingEnabled = true;
            this.cbxVenue.Location = new System.Drawing.Point(111, 36);
            this.cbxVenue.Name = "cbxVenue";
            this.cbxVenue.Size = new System.Drawing.Size(125, 24);
            this.cbxVenue.TabIndex = 8;
            // 
            // btnNewVenue
            // 
            this.btnNewVenue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewVenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewVenue.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnNewVenue.Location = new System.Drawing.Point(10, 80);
            this.btnNewVenue.Name = "btnNewVenue";
            this.btnNewVenue.Size = new System.Drawing.Size(100, 50);
            this.btnNewVenue.TabIndex = 9;
            this.btnNewVenue.Text = "New";
            this.btnNewVenue.UseVisualStyleBackColor = false;
            this.btnNewVenue.Click += new System.EventHandler(this.BtnNewVenue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select venue:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteType);
            this.groupBox4.Controls.Add(this.btnEditType);
            this.groupBox4.Controls.Add(this.cbxType);
            this.groupBox4.Controls.Add(this.btnNewType);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(293, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 202);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of Event";
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteType.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnDeleteType.Location = new System.Drawing.Point(73, 136);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteType.TabIndex = 14;
            this.btnDeleteType.Text = "Delete";
            this.btnDeleteType.UseVisualStyleBackColor = false;
            this.btnDeleteType.Click += new System.EventHandler(this.BtnDeleteType_Click);
            // 
            // btnEditType
            // 
            this.btnEditType.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditType.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditType.Location = new System.Drawing.Point(134, 80);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(100, 50);
            this.btnEditType.TabIndex = 13;
            this.btnEditType.Text = "Edit";
            this.btnEditType.UseVisualStyleBackColor = false;
            this.btnEditType.Click += new System.EventHandler(this.BtnEditType_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(109, 32);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(125, 24);
            this.cbxType.TabIndex = 11;
            // 
            // btnNewType
            // 
            this.btnNewType.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewType.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnNewType.Location = new System.Drawing.Point(12, 80);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(100, 50);
            this.btnNewType.TabIndex = 12;
            this.btnNewType.Text = "New";
            this.btnNewType.UseVisualStyleBackColor = false;
            this.btnNewType.Click += new System.EventHandler(this.BtnNewType_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select type:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEvent.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnAddEvent.Location = new System.Drawing.Point(112, 376);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(150, 50);
            this.btnAddEvent.TabIndex = 13;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(292, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Media\\Documents\\CMPG 223\\Adrestia\\Adrestia\\Adrestia\\Adrestia\\res\\Help files\\Us" +
    "er Manual.htm";
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 439);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewEvent";
            this.helpProvider1.SetShowHelp(this, true);
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
        private System.Windows.Forms.Button btnNewVenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxVenue;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Button btnDeleteVenue;
        private System.Windows.Forms.Button btnEditVenue;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}