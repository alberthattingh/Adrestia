namespace Adrestia
{
    partial class TicketSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEventID = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPensioners = new System.Windows.Forms.NumericUpDown();
            this.numAdult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPensioners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 48);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket Sales";
            // 
            // lbEventID
            // 
            this.lbEventID.FormattingEnabled = true;
            this.lbEventID.Location = new System.Drawing.Point(427, 80);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(120, 17);
            this.lbEventID.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPensioners);
            this.groupBox1.Controls.Add(this.numAdult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numChildren);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(88, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of Tickets Sold:";
            // 
            // numPensioners
            // 
            this.numPensioners.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPensioners.Location = new System.Drawing.Point(569, 48);
            this.numPensioners.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPensioners.Name = "numPensioners";
            this.numPensioners.Size = new System.Drawing.Size(120, 20);
            this.numPensioners.TabIndex = 12;
            this.numPensioners.ValueChanged += new System.EventHandler(this.NumPensioners_ValueChanged);
            // 
            // numAdult
            // 
            this.numAdult.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAdult.Location = new System.Drawing.Point(115, 43);
            this.numAdult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAdult.Name = "numAdult";
            this.numAdult.Size = new System.Drawing.Size(120, 20);
            this.numAdult.TabIndex = 10;
            this.numAdult.ValueChanged += new System.EventHandler(this.NumAdult_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adults:";
            // 
            // numChildren
            // 
            this.numChildren.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numChildren.Location = new System.Drawing.Point(354, 48);
            this.numChildren.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(120, 20);
            this.numChildren.TabIndex = 11;
            this.numChildren.ValueChanged += new System.EventHandler(this.NumChildren_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pensioners:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Children:";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.Location = new System.Drawing.Point(81, 396);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(245, 42);
            this.lblSale.TabIndex = 4;
            this.lblSale.Text = "Total Of Sale:";
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(338, 512);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(245, 89);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "button1";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.BtnSale_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timePicker);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(88, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date and Time of Ticket Sale";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:MM";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(545, 50);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(114, 20);
            this.timePicker.TabIndex = 11;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(161, 49);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(114, 20);
            this.datePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Time:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Adrestia.Properties.Resources.CloseIcon;
            this.btnExit.Location = new System.Drawing.Point(947, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TicketSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbEventID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TicketSales";
            this.Size = new System.Drawing.Size(1000, 666);
            this.Load += new System.EventHandler(this.TicketSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPensioners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEventID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPensioners;
        private System.Windows.Forms.NumericUpDown numAdult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
    }
}
