namespace Adrestia
{
    partial class CustomReport
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
            this.rbBackupLogs = new System.Windows.Forms.RadioButton();
            this.rbMessaging = new System.Windows.Forms.RadioButton();
            this.rbTicketSales = new System.Windows.Forms.RadioButton();
            this.rbEventVenues = new System.Windows.Forms.RadioButton();
            this.rbEventTypes = new System.Windows.Forms.RadioButton();
            this.rbSpecialEvents = new System.Windows.Forms.RadioButton();
            this.rbLessons = new System.Windows.Forms.RadioButton();
            this.rbStudents = new System.Windows.Forms.RadioButton();
            this.rbInstructors = new System.Windows.Forms.RadioButton();
            this.rbUsers = new System.Windows.Forms.RadioButton();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.cbUserType = new System.Windows.Forms.CheckBox();
            this.gbInstructors = new System.Windows.Forms.GroupBox();
            this.cbILastName = new System.Windows.Forms.CheckBox();
            this.cbICellNo = new System.Windows.Forms.CheckBox();
            this.cbIEmail = new System.Windows.Forms.CheckBox();
            this.cbSalary = new System.Windows.Forms.CheckBox();
            this.cbIFirstName = new System.Windows.Forms.CheckBox();
            this.gbBackupLog = new System.Windows.Forms.GroupBox();
            this.cbBackupTime = new System.Windows.Forms.CheckBox();
            this.cbBackupDate = new System.Windows.Forms.CheckBox();
            this.gbMessaging = new System.Windows.Forms.GroupBox();
            this.cbReceiver = new System.Windows.Forms.CheckBox();
            this.cbMessageText = new System.Windows.Forms.CheckBox();
            this.cbMessageTime = new System.Windows.Forms.CheckBox();
            this.cbMessageDate = new System.Windows.Forms.CheckBox();
            this.cbSender = new System.Windows.Forms.CheckBox();
            this.gbTicketSales = new System.Windows.Forms.GroupBox();
            this.cbSaleTime = new System.Windows.Forms.CheckBox();
            this.cbNoOfAdults = new System.Windows.Forms.CheckBox();
            this.cbTotalOfSale = new System.Windows.Forms.CheckBox();
            this.cbSalesEventID = new System.Windows.Forms.CheckBox();
            this.gbEventVenues = new System.Windows.Forms.GroupBox();
            this.cbMaxSeats = new System.Windows.Forms.CheckBox();
            this.cbVenueDesc = new System.Windows.Forms.CheckBox();
            this.cnNoOfPensioners = new System.Windows.Forms.CheckBox();
            this.cnNoOfChildren = new System.Windows.Forms.CheckBox();
            this.cbSaleDate = new System.Windows.Forms.CheckBox();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.cbSLastName = new System.Windows.Forms.CheckBox();
            this.cbSCellNo = new System.Windows.Forms.CheckBox();
            this.cbSEmail = new System.Windows.Forms.CheckBox();
            this.cbCredits = new System.Windows.Forms.CheckBox();
            this.cbSFirstName = new System.Windows.Forms.CheckBox();
            this.gbEventTypes = new System.Windows.Forms.GroupBox();
            this.cbEventTypeDesc = new System.Windows.Forms.CheckBox();
            this.gbLessons = new System.Windows.Forms.GroupBox();
            this.cbLessonInstructor = new System.Windows.Forms.CheckBox();
            this.cbLessonTime = new System.Windows.Forms.CheckBox();
            this.cbLessonPrice = new System.Windows.Forms.CheckBox();
            this.cbLessonDesc = new System.Windows.Forms.CheckBox();
            this.cbplacesAvailable = new System.Windows.Forms.CheckBox();
            this.cbLessonDate = new System.Windows.Forms.CheckBox();
            this.gbSpecialEvents = new System.Windows.Forms.GroupBox();
            this.cbEventType = new System.Windows.Forms.CheckBox();
            this.cbVenue = new System.Windows.Forms.CheckBox();
            this.cbEventTime = new System.Windows.Forms.CheckBox();
            this.cbAdultCost = new System.Windows.Forms.CheckBox();
            this.cbChildrenCost = new System.Windows.Forms.CheckBox();
            this.cbPensionerCost = new System.Windows.Forms.CheckBox();
            this.cbEventDate = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.gbInstructors.SuspendLayout();
            this.gbBackupLog.SuspendLayout();
            this.gbMessaging.SuspendLayout();
            this.gbTicketSales.SuspendLayout();
            this.gbEventVenues.SuspendLayout();
            this.gbStudents.SuspendLayout();
            this.gbEventTypes.SuspendLayout();
            this.gbLessons.SuspendLayout();
            this.gbSpecialEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBackupLogs);
            this.groupBox1.Controls.Add(this.rbMessaging);
            this.groupBox1.Controls.Add(this.rbTicketSales);
            this.groupBox1.Controls.Add(this.rbEventVenues);
            this.groupBox1.Controls.Add(this.rbEventTypes);
            this.groupBox1.Controls.Add(this.rbSpecialEvents);
            this.groupBox1.Controls.Add(this.rbLessons);
            this.groupBox1.Controls.Add(this.rbStudents);
            this.groupBox1.Controls.Add(this.rbInstructors);
            this.groupBox1.Controls.Add(this.rbUsers);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Report Type";
            // 
            // rbBackupLogs
            // 
            this.rbBackupLogs.AutoSize = true;
            this.rbBackupLogs.Location = new System.Drawing.Point(6, 282);
            this.rbBackupLogs.Name = "rbBackupLogs";
            this.rbBackupLogs.Size = new System.Drawing.Size(111, 21);
            this.rbBackupLogs.TabIndex = 9;
            this.rbBackupLogs.TabStop = true;
            this.rbBackupLogs.Text = "Backup Logs";
            this.rbBackupLogs.UseVisualStyleBackColor = true;
            this.rbBackupLogs.CheckedChanged += new System.EventHandler(this.RbBackupLogs_CheckedChanged);
            // 
            // rbMessaging
            // 
            this.rbMessaging.AutoSize = true;
            this.rbMessaging.Location = new System.Drawing.Point(6, 254);
            this.rbMessaging.Name = "rbMessaging";
            this.rbMessaging.Size = new System.Drawing.Size(99, 21);
            this.rbMessaging.TabIndex = 8;
            this.rbMessaging.TabStop = true;
            this.rbMessaging.Text = "Messaging";
            this.rbMessaging.UseVisualStyleBackColor = true;
            this.rbMessaging.CheckedChanged += new System.EventHandler(this.RbMessaging_CheckedChanged);
            // 
            // rbTicketSales
            // 
            this.rbTicketSales.AutoSize = true;
            this.rbTicketSales.Location = new System.Drawing.Point(6, 226);
            this.rbTicketSales.Name = "rbTicketSales";
            this.rbTicketSales.Size = new System.Drawing.Size(105, 21);
            this.rbTicketSales.TabIndex = 7;
            this.rbTicketSales.TabStop = true;
            this.rbTicketSales.Text = "Ticket Sales";
            this.rbTicketSales.UseVisualStyleBackColor = true;
            this.rbTicketSales.CheckedChanged += new System.EventHandler(this.RbTicketSales_CheckedChanged);
            // 
            // rbEventVenues
            // 
            this.rbEventVenues.AutoSize = true;
            this.rbEventVenues.Location = new System.Drawing.Point(6, 198);
            this.rbEventVenues.Name = "rbEventVenues";
            this.rbEventVenues.Size = new System.Drawing.Size(170, 21);
            this.rbEventVenues.TabIndex = 6;
            this.rbEventVenues.TabStop = true;
            this.rbEventVenues.Text = "Special Event Venues";
            this.rbEventVenues.UseVisualStyleBackColor = true;
            this.rbEventVenues.CheckedChanged += new System.EventHandler(this.RbEventVenues_CheckedChanged);
            // 
            // rbEventTypes
            // 
            this.rbEventTypes.AutoSize = true;
            this.rbEventTypes.Location = new System.Drawing.Point(6, 170);
            this.rbEventTypes.Name = "rbEventTypes";
            this.rbEventTypes.Size = new System.Drawing.Size(157, 21);
            this.rbEventTypes.TabIndex = 5;
            this.rbEventTypes.TabStop = true;
            this.rbEventTypes.Text = "Special Event Types";
            this.rbEventTypes.UseVisualStyleBackColor = true;
            this.rbEventTypes.CheckedChanged += new System.EventHandler(this.RbEventTypes_CheckedChanged);
            // 
            // rbSpecialEvents
            // 
            this.rbSpecialEvents.AutoSize = true;
            this.rbSpecialEvents.Location = new System.Drawing.Point(6, 142);
            this.rbSpecialEvents.Name = "rbSpecialEvents";
            this.rbSpecialEvents.Size = new System.Drawing.Size(122, 21);
            this.rbSpecialEvents.TabIndex = 4;
            this.rbSpecialEvents.TabStop = true;
            this.rbSpecialEvents.Text = "Special Events";
            this.rbSpecialEvents.UseVisualStyleBackColor = true;
            this.rbSpecialEvents.CheckedChanged += new System.EventHandler(this.RbSpecialEvents_CheckedChanged);
            // 
            // rbLessons
            // 
            this.rbLessons.AutoSize = true;
            this.rbLessons.Location = new System.Drawing.Point(6, 114);
            this.rbLessons.Name = "rbLessons";
            this.rbLessons.Size = new System.Drawing.Size(76, 21);
            this.rbLessons.TabIndex = 3;
            this.rbLessons.TabStop = true;
            this.rbLessons.Text = "Lessons";
            this.rbLessons.UseVisualStyleBackColor = true;
            this.rbLessons.CheckedChanged += new System.EventHandler(this.RbLessons_CheckedChanged);
            // 
            // rbStudents
            // 
            this.rbStudents.AutoSize = true;
            this.rbStudents.Location = new System.Drawing.Point(6, 86);
            this.rbStudents.Name = "rbStudents";
            this.rbStudents.Size = new System.Drawing.Size(81, 21);
            this.rbStudents.TabIndex = 2;
            this.rbStudents.TabStop = true;
            this.rbStudents.Text = "Students";
            this.rbStudents.UseVisualStyleBackColor = true;
            this.rbStudents.CheckedChanged += new System.EventHandler(this.RbStudents_CheckedChanged);
            // 
            // rbInstructors
            // 
            this.rbInstructors.AutoSize = true;
            this.rbInstructors.Location = new System.Drawing.Point(6, 58);
            this.rbInstructors.Name = "rbInstructors";
            this.rbInstructors.Size = new System.Drawing.Size(92, 21);
            this.rbInstructors.TabIndex = 1;
            this.rbInstructors.TabStop = true;
            this.rbInstructors.Text = "Instructors";
            this.rbInstructors.UseVisualStyleBackColor = true;
            this.rbInstructors.CheckedChanged += new System.EventHandler(this.RbInstructors_CheckedChanged);
            // 
            // rbUsers
            // 
            this.rbUsers.AutoSize = true;
            this.rbUsers.Location = new System.Drawing.Point(6, 30);
            this.rbUsers.Name = "rbUsers";
            this.rbUsers.Size = new System.Drawing.Size(60, 21);
            this.rbUsers.TabIndex = 0;
            this.rbUsers.TabStop = true;
            this.rbUsers.Text = "Users";
            this.rbUsers.UseVisualStyleBackColor = true;
            this.rbUsers.CheckedChanged += new System.EventHandler(this.RbUsers_CheckedChanged);
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.cbUserType);
            this.gbUsers.Controls.Add(this.gbInstructors);
            this.gbUsers.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbUsers.Location = new System.Drawing.Point(225, 20);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(200, 325);
            this.gbUsers.TabIndex = 1;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // cbUserType
            // 
            this.cbUserType.AutoSize = true;
            this.cbUserType.Location = new System.Drawing.Point(6, 58);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(90, 21);
            this.cbUserType.TabIndex = 1;
            this.cbUserType.Text = "User Type";
            this.cbUserType.UseVisualStyleBackColor = true;
            this.cbUserType.CheckedChanged += new System.EventHandler(this.CbUserType_CheckedChanged);
            // 
            // gbInstructors
            // 
            this.gbInstructors.Controls.Add(this.cbILastName);
            this.gbInstructors.Controls.Add(this.cbICellNo);
            this.gbInstructors.Controls.Add(this.cbIEmail);
            this.gbInstructors.Controls.Add(this.cbSalary);
            this.gbInstructors.Controls.Add(this.cbIFirstName);
            this.gbInstructors.Controls.Add(this.gbBackupLog);
            this.gbInstructors.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbInstructors.Location = new System.Drawing.Point(0, 0);
            this.gbInstructors.Name = "gbInstructors";
            this.gbInstructors.Size = new System.Drawing.Size(200, 325);
            this.gbInstructors.TabIndex = 2;
            this.gbInstructors.TabStop = false;
            this.gbInstructors.Text = "Instructors";
            // 
            // cbILastName
            // 
            this.cbILastName.AutoSize = true;
            this.cbILastName.Location = new System.Drawing.Point(6, 85);
            this.cbILastName.Name = "cbILastName";
            this.cbILastName.Size = new System.Drawing.Size(98, 21);
            this.cbILastName.TabIndex = 5;
            this.cbILastName.Text = "Last Name";
            this.cbILastName.UseVisualStyleBackColor = true;
            this.cbILastName.CheckedChanged += new System.EventHandler(this.CbILastName_CheckedChanged);
            // 
            // cbICellNo
            // 
            this.cbICellNo.AutoSize = true;
            this.cbICellNo.Location = new System.Drawing.Point(6, 114);
            this.cbICellNo.Name = "cbICellNo";
            this.cbICellNo.Size = new System.Drawing.Size(78, 21);
            this.cbICellNo.TabIndex = 4;
            this.cbICellNo.Text = "Cell No";
            this.cbICellNo.UseVisualStyleBackColor = true;
            this.cbICellNo.CheckedChanged += new System.EventHandler(this.CbICellNo_CheckedChanged);
            // 
            // cbIEmail
            // 
            this.cbIEmail.AutoSize = true;
            this.cbIEmail.Location = new System.Drawing.Point(6, 143);
            this.cbIEmail.Name = "cbIEmail";
            this.cbIEmail.Size = new System.Drawing.Size(65, 21);
            this.cbIEmail.TabIndex = 3;
            this.cbIEmail.Text = "Email";
            this.cbIEmail.UseVisualStyleBackColor = true;
            this.cbIEmail.CheckedChanged += new System.EventHandler(this.CbIEmail_CheckedChanged);
            // 
            // cbSalary
            // 
            this.cbSalary.AutoSize = true;
            this.cbSalary.Location = new System.Drawing.Point(6, 170);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(67, 21);
            this.cbSalary.TabIndex = 2;
            this.cbSalary.Text = "Salary";
            this.cbSalary.UseVisualStyleBackColor = true;
            this.cbSalary.CheckedChanged += new System.EventHandler(this.CbSalary_CheckedChanged);
            // 
            // cbIFirstName
            // 
            this.cbIFirstName.AutoSize = true;
            this.cbIFirstName.Location = new System.Drawing.Point(6, 58);
            this.cbIFirstName.Name = "cbIFirstName";
            this.cbIFirstName.Size = new System.Drawing.Size(98, 21);
            this.cbIFirstName.TabIndex = 1;
            this.cbIFirstName.Text = "First Name";
            this.cbIFirstName.UseVisualStyleBackColor = true;
            this.cbIFirstName.CheckedChanged += new System.EventHandler(this.CbIFirstName_CheckedChanged);
            // 
            // gbBackupLog
            // 
            this.gbBackupLog.Controls.Add(this.cbBackupTime);
            this.gbBackupLog.Controls.Add(this.cbBackupDate);
            this.gbBackupLog.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbBackupLog.Location = new System.Drawing.Point(0, 0);
            this.gbBackupLog.Name = "gbBackupLog";
            this.gbBackupLog.Size = new System.Drawing.Size(200, 325);
            this.gbBackupLog.TabIndex = 12;
            this.gbBackupLog.TabStop = false;
            this.gbBackupLog.Text = "Backup Logs";
            // 
            // cbBackupTime
            // 
            this.cbBackupTime.AutoSize = true;
            this.cbBackupTime.Location = new System.Drawing.Point(6, 84);
            this.cbBackupTime.Name = "cbBackupTime";
            this.cbBackupTime.Size = new System.Drawing.Size(60, 21);
            this.cbBackupTime.TabIndex = 7;
            this.cbBackupTime.Text = "Time";
            this.cbBackupTime.UseVisualStyleBackColor = true;
            this.cbBackupTime.CheckedChanged += new System.EventHandler(this.CbBackupTime_CheckedChanged);
            // 
            // cbBackupDate
            // 
            this.cbBackupDate.AutoSize = true;
            this.cbBackupDate.Location = new System.Drawing.Point(6, 57);
            this.cbBackupDate.Name = "cbBackupDate";
            this.cbBackupDate.Size = new System.Drawing.Size(59, 21);
            this.cbBackupDate.TabIndex = 1;
            this.cbBackupDate.Text = "Date";
            this.cbBackupDate.UseVisualStyleBackColor = true;
            this.cbBackupDate.CheckedChanged += new System.EventHandler(this.CbBackupDate_CheckedChanged);
            // 
            // gbMessaging
            // 
            this.gbMessaging.Controls.Add(this.cbReceiver);
            this.gbMessaging.Controls.Add(this.cbMessageText);
            this.gbMessaging.Controls.Add(this.cbMessageTime);
            this.gbMessaging.Controls.Add(this.cbMessageDate);
            this.gbMessaging.Controls.Add(this.cbSender);
            this.gbMessaging.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbMessaging.Location = new System.Drawing.Point(0, 6);
            this.gbMessaging.Name = "gbMessaging";
            this.gbMessaging.Size = new System.Drawing.Size(200, 325);
            this.gbMessaging.TabIndex = 12;
            this.gbMessaging.TabStop = false;
            this.gbMessaging.Text = "Messaging";
            // 
            // cbReceiver
            // 
            this.cbReceiver.AutoSize = true;
            this.cbReceiver.Location = new System.Drawing.Point(10, 86);
            this.cbReceiver.Name = "cbReceiver";
            this.cbReceiver.Size = new System.Drawing.Size(86, 21);
            this.cbReceiver.TabIndex = 7;
            this.cbReceiver.Text = "Receiver";
            this.cbReceiver.UseVisualStyleBackColor = true;
            this.cbReceiver.CheckedChanged += new System.EventHandler(this.CbReceiver_CheckedChanged);
            // 
            // cbMessageText
            // 
            this.cbMessageText.AutoSize = true;
            this.cbMessageText.Location = new System.Drawing.Point(10, 114);
            this.cbMessageText.Name = "cbMessageText";
            this.cbMessageText.Size = new System.Drawing.Size(119, 21);
            this.cbMessageText.TabIndex = 6;
            this.cbMessageText.Text = "Message Text";
            this.cbMessageText.UseVisualStyleBackColor = true;
            this.cbMessageText.CheckedChanged += new System.EventHandler(this.CbMessageText_CheckedChanged);
            // 
            // cbMessageTime
            // 
            this.cbMessageTime.AutoSize = true;
            this.cbMessageTime.Location = new System.Drawing.Point(10, 170);
            this.cbMessageTime.Name = "cbMessageTime";
            this.cbMessageTime.Size = new System.Drawing.Size(60, 21);
            this.cbMessageTime.TabIndex = 3;
            this.cbMessageTime.Text = "Time";
            this.cbMessageTime.UseVisualStyleBackColor = true;
            this.cbMessageTime.CheckedChanged += new System.EventHandler(this.CbMessageTime_CheckedChanged);
            // 
            // cbMessageDate
            // 
            this.cbMessageDate.AutoSize = true;
            this.cbMessageDate.Location = new System.Drawing.Point(10, 141);
            this.cbMessageDate.Name = "cbMessageDate";
            this.cbMessageDate.Size = new System.Drawing.Size(59, 21);
            this.cbMessageDate.TabIndex = 2;
            this.cbMessageDate.Text = "Date";
            this.cbMessageDate.UseVisualStyleBackColor = true;
            this.cbMessageDate.CheckedChanged += new System.EventHandler(this.CbMessageDate_CheckedChanged);
            // 
            // cbSender
            // 
            this.cbSender.AutoSize = true;
            this.cbSender.Location = new System.Drawing.Point(10, 58);
            this.cbSender.Name = "cbSender";
            this.cbSender.Size = new System.Drawing.Size(73, 21);
            this.cbSender.TabIndex = 1;
            this.cbSender.Text = "Sender";
            this.cbSender.UseVisualStyleBackColor = true;
            this.cbSender.CheckedChanged += new System.EventHandler(this.CbSender_CheckedChanged);
            // 
            // gbTicketSales
            // 
            this.gbTicketSales.Controls.Add(this.cbSaleTime);
            this.gbTicketSales.Controls.Add(this.cbNoOfAdults);
            this.gbTicketSales.Controls.Add(this.cbTotalOfSale);
            this.gbTicketSales.Controls.Add(this.cbSalesEventID);
            this.gbTicketSales.Controls.Add(this.gbEventVenues);
            this.gbTicketSales.Controls.Add(this.cnNoOfPensioners);
            this.gbTicketSales.Controls.Add(this.cnNoOfChildren);
            this.gbTicketSales.Controls.Add(this.cbSaleDate);
            this.gbTicketSales.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbTicketSales.Location = new System.Drawing.Point(0, 1);
            this.gbTicketSales.Name = "gbTicketSales";
            this.gbTicketSales.Size = new System.Drawing.Size(200, 325);
            this.gbTicketSales.TabIndex = 11;
            this.gbTicketSales.TabStop = false;
            this.gbTicketSales.Text = "Ticket Sales";
            // 
            // cbSaleTime
            // 
            this.cbSaleTime.AutoSize = true;
            this.cbSaleTime.Location = new System.Drawing.Point(10, 86);
            this.cbSaleTime.Name = "cbSaleTime";
            this.cbSaleTime.Size = new System.Drawing.Size(60, 21);
            this.cbSaleTime.TabIndex = 7;
            this.cbSaleTime.Text = "Time";
            this.cbSaleTime.UseVisualStyleBackColor = true;
            this.cbSaleTime.CheckedChanged += new System.EventHandler(this.CbSaleTime_CheckedChanged);
            // 
            // cbNoOfAdults
            // 
            this.cbNoOfAdults.AutoSize = true;
            this.cbNoOfAdults.Location = new System.Drawing.Point(10, 114);
            this.cbNoOfAdults.Name = "cbNoOfAdults";
            this.cbNoOfAdults.Size = new System.Drawing.Size(111, 21);
            this.cbNoOfAdults.TabIndex = 6;
            this.cbNoOfAdults.Text = "No Of Adults";
            this.cbNoOfAdults.UseVisualStyleBackColor = true;
            this.cbNoOfAdults.CheckedChanged += new System.EventHandler(this.CbNoOfAdults_CheckedChanged);
            // 
            // cbTotalOfSale
            // 
            this.cbTotalOfSale.AutoSize = true;
            this.cbTotalOfSale.Location = new System.Drawing.Point(10, 198);
            this.cbTotalOfSale.Name = "cbTotalOfSale";
            this.cbTotalOfSale.Size = new System.Drawing.Size(112, 21);
            this.cbTotalOfSale.TabIndex = 5;
            this.cbTotalOfSale.Text = "Total Of Sale";
            this.cbTotalOfSale.UseVisualStyleBackColor = true;
            this.cbTotalOfSale.CheckedChanged += new System.EventHandler(this.CbTotalOfSale_CheckedChanged);
            // 
            // cbSalesEventID
            // 
            this.cbSalesEventID.AutoSize = true;
            this.cbSalesEventID.Location = new System.Drawing.Point(10, 226);
            this.cbSalesEventID.Name = "cbSalesEventID";
            this.cbSalesEventID.Size = new System.Drawing.Size(76, 21);
            this.cbSalesEventID.TabIndex = 4;
            this.cbSalesEventID.Text = "EventID";
            this.cbSalesEventID.UseVisualStyleBackColor = true;
            this.cbSalesEventID.CheckedChanged += new System.EventHandler(this.CbSalesEventID_CheckedChanged);
            // 
            // gbEventVenues
            // 
            this.gbEventVenues.Controls.Add(this.gbMessaging);
            this.gbEventVenues.Controls.Add(this.cbMaxSeats);
            this.gbEventVenues.Controls.Add(this.cbVenueDesc);
            this.gbEventVenues.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbEventVenues.Location = new System.Drawing.Point(0, 0);
            this.gbEventVenues.Name = "gbEventVenues";
            this.gbEventVenues.Size = new System.Drawing.Size(200, 325);
            this.gbEventVenues.TabIndex = 10;
            this.gbEventVenues.TabStop = false;
            this.gbEventVenues.Text = "Event Venues";
            // 
            // cbMaxSeats
            // 
            this.cbMaxSeats.AutoSize = true;
            this.cbMaxSeats.Location = new System.Drawing.Point(6, 85);
            this.cbMaxSeats.Name = "cbMaxSeats";
            this.cbMaxSeats.Size = new System.Drawing.Size(139, 21);
            this.cbMaxSeats.TabIndex = 2;
            this.cbMaxSeats.Text = "Max No Of Seats";
            this.cbMaxSeats.UseVisualStyleBackColor = true;
            this.cbMaxSeats.CheckedChanged += new System.EventHandler(this.CbMaxSeats_CheckedChanged);
            // 
            // cbVenueDesc
            // 
            this.cbVenueDesc.AutoSize = true;
            this.cbVenueDesc.Location = new System.Drawing.Point(6, 58);
            this.cbVenueDesc.Name = "cbVenueDesc";
            this.cbVenueDesc.Size = new System.Drawing.Size(103, 21);
            this.cbVenueDesc.TabIndex = 1;
            this.cbVenueDesc.Text = "Description";
            this.cbVenueDesc.UseVisualStyleBackColor = true;
            this.cbVenueDesc.CheckedChanged += new System.EventHandler(this.CbVenueDesc_CheckedChanged);
            // 
            // cnNoOfPensioners
            // 
            this.cnNoOfPensioners.AutoSize = true;
            this.cnNoOfPensioners.Location = new System.Drawing.Point(10, 170);
            this.cnNoOfPensioners.Name = "cnNoOfPensioners";
            this.cnNoOfPensioners.Size = new System.Drawing.Size(141, 21);
            this.cnNoOfPensioners.TabIndex = 3;
            this.cnNoOfPensioners.Text = "No Of Pensioners";
            this.cnNoOfPensioners.UseVisualStyleBackColor = true;
            this.cnNoOfPensioners.CheckedChanged += new System.EventHandler(this.CnNoOfPensioners_CheckedChanged);
            // 
            // cnNoOfChildren
            // 
            this.cnNoOfChildren.AutoSize = true;
            this.cnNoOfChildren.Location = new System.Drawing.Point(10, 141);
            this.cnNoOfChildren.Name = "cnNoOfChildren";
            this.cnNoOfChildren.Size = new System.Drawing.Size(127, 21);
            this.cnNoOfChildren.TabIndex = 2;
            this.cnNoOfChildren.Text = "No Of Children";
            this.cnNoOfChildren.UseVisualStyleBackColor = true;
            this.cnNoOfChildren.CheckedChanged += new System.EventHandler(this.CnNoOfChildren_CheckedChanged);
            // 
            // cbSaleDate
            // 
            this.cbSaleDate.AutoSize = true;
            this.cbSaleDate.Location = new System.Drawing.Point(10, 58);
            this.cbSaleDate.Name = "cbSaleDate";
            this.cbSaleDate.Size = new System.Drawing.Size(59, 21);
            this.cbSaleDate.TabIndex = 1;
            this.cbSaleDate.Text = "Date";
            this.cbSaleDate.UseVisualStyleBackColor = true;
            this.cbSaleDate.CheckedChanged += new System.EventHandler(this.CbSaleDate_CheckedChanged);
            // 
            // gbStudents
            // 
            this.gbStudents.Controls.Add(this.cbSLastName);
            this.gbStudents.Controls.Add(this.cbSCellNo);
            this.gbStudents.Controls.Add(this.cbSEmail);
            this.gbStudents.Controls.Add(this.cbCredits);
            this.gbStudents.Controls.Add(this.cbSFirstName);
            this.gbStudents.Controls.Add(this.gbTicketSales);
            this.gbStudents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbStudents.Location = new System.Drawing.Point(225, 13);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.Size = new System.Drawing.Size(200, 325);
            this.gbStudents.TabIndex = 6;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Students";
            // 
            // cbSLastName
            // 
            this.cbSLastName.AutoSize = true;
            this.cbSLastName.Location = new System.Drawing.Point(8, 86);
            this.cbSLastName.Name = "cbSLastName";
            this.cbSLastName.Size = new System.Drawing.Size(98, 21);
            this.cbSLastName.TabIndex = 5;
            this.cbSLastName.Text = "Last Name";
            this.cbSLastName.UseVisualStyleBackColor = true;
            this.cbSLastName.CheckedChanged += new System.EventHandler(this.CbSLastName_CheckedChanged);
            // 
            // cbSCellNo
            // 
            this.cbSCellNo.AutoSize = true;
            this.cbSCellNo.Location = new System.Drawing.Point(8, 113);
            this.cbSCellNo.Name = "cbSCellNo";
            this.cbSCellNo.Size = new System.Drawing.Size(78, 21);
            this.cbSCellNo.TabIndex = 4;
            this.cbSCellNo.Text = "Cell No";
            this.cbSCellNo.UseVisualStyleBackColor = true;
            this.cbSCellNo.CheckedChanged += new System.EventHandler(this.CbSCellNo_CheckedChanged);
            // 
            // cbSEmail
            // 
            this.cbSEmail.AutoSize = true;
            this.cbSEmail.Location = new System.Drawing.Point(8, 142);
            this.cbSEmail.Name = "cbSEmail";
            this.cbSEmail.Size = new System.Drawing.Size(65, 21);
            this.cbSEmail.TabIndex = 3;
            this.cbSEmail.Text = "Email";
            this.cbSEmail.UseVisualStyleBackColor = true;
            this.cbSEmail.CheckedChanged += new System.EventHandler(this.CbSEmail_CheckedChanged);
            // 
            // cbCredits
            // 
            this.cbCredits.AutoSize = true;
            this.cbCredits.Location = new System.Drawing.Point(8, 170);
            this.cbCredits.Name = "cbCredits";
            this.cbCredits.Size = new System.Drawing.Size(74, 21);
            this.cbCredits.TabIndex = 2;
            this.cbCredits.Text = "Credits";
            this.cbCredits.UseVisualStyleBackColor = true;
            this.cbCredits.CheckedChanged += new System.EventHandler(this.CbCredits_CheckedChanged);
            // 
            // cbSFirstName
            // 
            this.cbSFirstName.AutoSize = true;
            this.cbSFirstName.Location = new System.Drawing.Point(8, 58);
            this.cbSFirstName.Name = "cbSFirstName";
            this.cbSFirstName.Size = new System.Drawing.Size(98, 21);
            this.cbSFirstName.TabIndex = 1;
            this.cbSFirstName.Text = "First Name";
            this.cbSFirstName.UseVisualStyleBackColor = true;
            this.cbSFirstName.CheckedChanged += new System.EventHandler(this.CbSFirstName_CheckedChanged);
            // 
            // gbEventTypes
            // 
            this.gbEventTypes.Controls.Add(this.cbEventTypeDesc);
            this.gbEventTypes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbEventTypes.Location = new System.Drawing.Point(225, 14);
            this.gbEventTypes.Name = "gbEventTypes";
            this.gbEventTypes.Size = new System.Drawing.Size(200, 325);
            this.gbEventTypes.TabIndex = 9;
            this.gbEventTypes.TabStop = false;
            this.gbEventTypes.Text = "Event Types";
            // 
            // cbEventTypeDesc
            // 
            this.cbEventTypeDesc.AutoSize = true;
            this.cbEventTypeDesc.Location = new System.Drawing.Point(6, 58);
            this.cbEventTypeDesc.Name = "cbEventTypeDesc";
            this.cbEventTypeDesc.Size = new System.Drawing.Size(103, 21);
            this.cbEventTypeDesc.TabIndex = 1;
            this.cbEventTypeDesc.Text = "Description";
            this.cbEventTypeDesc.UseVisualStyleBackColor = true;
            this.cbEventTypeDesc.CheckedChanged += new System.EventHandler(this.CbEventTypeDesc_CheckedChanged);
            // 
            // gbLessons
            // 
            this.gbLessons.Controls.Add(this.cbLessonInstructor);
            this.gbLessons.Controls.Add(this.cbLessonTime);
            this.gbLessons.Controls.Add(this.cbLessonPrice);
            this.gbLessons.Controls.Add(this.cbLessonDesc);
            this.gbLessons.Controls.Add(this.cbplacesAvailable);
            this.gbLessons.Controls.Add(this.cbLessonDate);
            this.gbLessons.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbLessons.Location = new System.Drawing.Point(225, 20);
            this.gbLessons.Name = "gbLessons";
            this.gbLessons.Size = new System.Drawing.Size(200, 318);
            this.gbLessons.TabIndex = 7;
            this.gbLessons.TabStop = false;
            this.gbLessons.Text = "Lessons";
            // 
            // cbLessonInstructor
            // 
            this.cbLessonInstructor.AutoSize = true;
            this.cbLessonInstructor.Location = new System.Drawing.Point(9, 198);
            this.cbLessonInstructor.Name = "cbLessonInstructor";
            this.cbLessonInstructor.Size = new System.Drawing.Size(92, 21);
            this.cbLessonInstructor.TabIndex = 6;
            this.cbLessonInstructor.Text = "Organizer";
            this.cbLessonInstructor.UseVisualStyleBackColor = true;
            this.cbLessonInstructor.CheckedChanged += new System.EventHandler(this.CbLessonOrganizer_CheckedChanged);
            // 
            // cbLessonTime
            // 
            this.cbLessonTime.AutoSize = true;
            this.cbLessonTime.Location = new System.Drawing.Point(9, 114);
            this.cbLessonTime.Name = "cbLessonTime";
            this.cbLessonTime.Size = new System.Drawing.Size(60, 21);
            this.cbLessonTime.TabIndex = 5;
            this.cbLessonTime.Text = "Time";
            this.cbLessonTime.UseVisualStyleBackColor = true;
            this.cbLessonTime.CheckedChanged += new System.EventHandler(this.CbLessonTime_CheckedChanged);
            // 
            // cbLessonPrice
            // 
            this.cbLessonPrice.AutoSize = true;
            this.cbLessonPrice.Location = new System.Drawing.Point(9, 142);
            this.cbLessonPrice.Name = "cbLessonPrice";
            this.cbLessonPrice.Size = new System.Drawing.Size(61, 21);
            this.cbLessonPrice.TabIndex = 4;
            this.cbLessonPrice.Text = "Price";
            this.cbLessonPrice.UseVisualStyleBackColor = true;
            this.cbLessonPrice.CheckedChanged += new System.EventHandler(this.CbLessonPrice_CheckedChanged);
            // 
            // cbLessonDesc
            // 
            this.cbLessonDesc.AutoSize = true;
            this.cbLessonDesc.Location = new System.Drawing.Point(9, 58);
            this.cbLessonDesc.Name = "cbLessonDesc";
            this.cbLessonDesc.Size = new System.Drawing.Size(103, 21);
            this.cbLessonDesc.TabIndex = 3;
            this.cbLessonDesc.Text = "Description";
            this.cbLessonDesc.UseVisualStyleBackColor = true;
            this.cbLessonDesc.CheckedChanged += new System.EventHandler(this.CbLessonDesc_CheckedChanged);
            // 
            // cbplacesAvailable
            // 
            this.cbplacesAvailable.AutoSize = true;
            this.cbplacesAvailable.Location = new System.Drawing.Point(9, 170);
            this.cbplacesAvailable.Name = "cbplacesAvailable";
            this.cbplacesAvailable.Size = new System.Drawing.Size(141, 21);
            this.cbplacesAvailable.TabIndex = 2;
            this.cbplacesAvailable.Text = "Places Available";
            this.cbplacesAvailable.UseVisualStyleBackColor = true;
            this.cbplacesAvailable.CheckedChanged += new System.EventHandler(this.CbplacesAvailable_CheckedChanged);
            // 
            // cbLessonDate
            // 
            this.cbLessonDate.AutoSize = true;
            this.cbLessonDate.Location = new System.Drawing.Point(9, 85);
            this.cbLessonDate.Name = "cbLessonDate";
            this.cbLessonDate.Size = new System.Drawing.Size(59, 21);
            this.cbLessonDate.TabIndex = 1;
            this.cbLessonDate.Text = "Date";
            this.cbLessonDate.UseVisualStyleBackColor = true;
            this.cbLessonDate.CheckedChanged += new System.EventHandler(this.CbLessonDate_CheckedChanged);
            // 
            // gbSpecialEvents
            // 
            this.gbSpecialEvents.Controls.Add(this.cbEventType);
            this.gbSpecialEvents.Controls.Add(this.cbVenue);
            this.gbSpecialEvents.Controls.Add(this.cbEventTime);
            this.gbSpecialEvents.Controls.Add(this.cbAdultCost);
            this.gbSpecialEvents.Controls.Add(this.cbChildrenCost);
            this.gbSpecialEvents.Controls.Add(this.cbPensionerCost);
            this.gbSpecialEvents.Controls.Add(this.cbEventDate);
            this.gbSpecialEvents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gbSpecialEvents.Location = new System.Drawing.Point(225, 20);
            this.gbSpecialEvents.Name = "gbSpecialEvents";
            this.gbSpecialEvents.Size = new System.Drawing.Size(200, 325);
            this.gbSpecialEvents.TabIndex = 8;
            this.gbSpecialEvents.TabStop = false;
            this.gbSpecialEvents.Text = "Special Events";
            // 
            // cbEventType
            // 
            this.cbEventType.AutoSize = true;
            this.cbEventType.Location = new System.Drawing.Point(6, 225);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(58, 21);
            this.cbEventType.TabIndex = 7;
            this.cbEventType.Text = "Type";
            this.cbEventType.UseVisualStyleBackColor = true;
            this.cbEventType.CheckedChanged += new System.EventHandler(this.CbEventType_CheckedChanged);
            // 
            // cbVenue
            // 
            this.cbVenue.AutoSize = true;
            this.cbVenue.Location = new System.Drawing.Point(6, 198);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(71, 21);
            this.cbVenue.TabIndex = 6;
            this.cbVenue.Text = "Venue";
            this.cbVenue.UseVisualStyleBackColor = true;
            this.cbVenue.CheckedChanged += new System.EventHandler(this.CbVenue_CheckedChanged);
            // 
            // cbEventTime
            // 
            this.cbEventTime.AutoSize = true;
            this.cbEventTime.Location = new System.Drawing.Point(6, 86);
            this.cbEventTime.Name = "cbEventTime";
            this.cbEventTime.Size = new System.Drawing.Size(60, 21);
            this.cbEventTime.TabIndex = 5;
            this.cbEventTime.Text = "Time";
            this.cbEventTime.UseVisualStyleBackColor = true;
            this.cbEventTime.CheckedChanged += new System.EventHandler(this.CbEventTime_CheckedChanged);
            // 
            // cbAdultCost
            // 
            this.cbAdultCost.AutoSize = true;
            this.cbAdultCost.Location = new System.Drawing.Point(6, 114);
            this.cbAdultCost.Name = "cbAdultCost";
            this.cbAdultCost.Size = new System.Drawing.Size(140, 21);
            this.cbAdultCost.TabIndex = 4;
            this.cbAdultCost.Text = "Adult Ticket Cost";
            this.cbAdultCost.UseVisualStyleBackColor = true;
            this.cbAdultCost.CheckedChanged += new System.EventHandler(this.CbAdultCost_CheckedChanged);
            // 
            // cbChildrenCost
            // 
            this.cbChildrenCost.AutoSize = true;
            this.cbChildrenCost.Location = new System.Drawing.Point(6, 142);
            this.cbChildrenCost.Name = "cbChildrenCost";
            this.cbChildrenCost.Size = new System.Drawing.Size(158, 21);
            this.cbChildrenCost.TabIndex = 3;
            this.cbChildrenCost.Text = "Chidren Ticket Cost";
            this.cbChildrenCost.UseVisualStyleBackColor = true;
            this.cbChildrenCost.CheckedChanged += new System.EventHandler(this.CbChildrenCost_CheckedChanged);
            // 
            // cbPensionerCost
            // 
            this.cbPensionerCost.AutoSize = true;
            this.cbPensionerCost.Location = new System.Drawing.Point(6, 170);
            this.cbPensionerCost.Name = "cbPensionerCost";
            this.cbPensionerCost.Size = new System.Drawing.Size(170, 21);
            this.cbPensionerCost.TabIndex = 2;
            this.cbPensionerCost.Text = "Pensioner Ticket Cost";
            this.cbPensionerCost.UseVisualStyleBackColor = true;
            this.cbPensionerCost.CheckedChanged += new System.EventHandler(this.CbPensionerCost_CheckedChanged);
            // 
            // cbEventDate
            // 
            this.cbEventDate.AutoSize = true;
            this.cbEventDate.Location = new System.Drawing.Point(6, 58);
            this.cbEventDate.Name = "cbEventDate";
            this.cbEventDate.Size = new System.Drawing.Size(59, 21);
            this.cbEventDate.TabIndex = 1;
            this.cbEventDate.Text = "Date";
            this.cbEventDate.UseVisualStyleBackColor = true;
            this.cbEventDate.CheckedChanged += new System.EventHandler(this.CbEventDate_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(255, 343);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(39, 343);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 50);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Media\\Documents\\CMPG 223\\Adrestia\\Adrestia\\Adrestia\\Adrestia\\Main Menu.htm";
            // 
            // CustomReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 403);
            this.Controls.Add(this.gbLessons);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbSpecialEvents);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbStudents);
            this.Controls.Add(this.gbEventTypes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbUsers);
            this.Name = "CustomReport";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "CustomReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.gbInstructors.ResumeLayout(false);
            this.gbInstructors.PerformLayout();
            this.gbBackupLog.ResumeLayout(false);
            this.gbBackupLog.PerformLayout();
            this.gbMessaging.ResumeLayout(false);
            this.gbMessaging.PerformLayout();
            this.gbTicketSales.ResumeLayout(false);
            this.gbTicketSales.PerformLayout();
            this.gbEventVenues.ResumeLayout(false);
            this.gbEventVenues.PerformLayout();
            this.gbStudents.ResumeLayout(false);
            this.gbStudents.PerformLayout();
            this.gbEventTypes.ResumeLayout(false);
            this.gbEventTypes.PerformLayout();
            this.gbLessons.ResumeLayout(false);
            this.gbLessons.PerformLayout();
            this.gbSpecialEvents.ResumeLayout(false);
            this.gbSpecialEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.RadioButton rbBackupLogs;
        private System.Windows.Forms.RadioButton rbMessaging;
        private System.Windows.Forms.RadioButton rbTicketSales;
        private System.Windows.Forms.RadioButton rbEventVenues;
        private System.Windows.Forms.RadioButton rbEventTypes;
        private System.Windows.Forms.RadioButton rbSpecialEvents;
        private System.Windows.Forms.RadioButton rbLessons;
        private System.Windows.Forms.RadioButton rbStudents;
        private System.Windows.Forms.RadioButton rbInstructors;
        private System.Windows.Forms.RadioButton rbUsers;
        private System.Windows.Forms.CheckBox cbUserType;
        private System.Windows.Forms.GroupBox gbInstructors;
        private System.Windows.Forms.GroupBox gbStudents;
        private System.Windows.Forms.GroupBox gbLessons;
        private System.Windows.Forms.GroupBox gbSpecialEvents;
        private System.Windows.Forms.GroupBox gbEventTypes;
        private System.Windows.Forms.GroupBox gbEventVenues;
        private System.Windows.Forms.CheckBox cbVenueDesc;
        private System.Windows.Forms.CheckBox cbEventTypeDesc;
        private System.Windows.Forms.CheckBox cbVenue;
        private System.Windows.Forms.CheckBox cbEventTime;
        private System.Windows.Forms.CheckBox cbAdultCost;
        private System.Windows.Forms.CheckBox cbChildrenCost;
        private System.Windows.Forms.CheckBox cbPensionerCost;
        private System.Windows.Forms.CheckBox cbEventDate;
        private System.Windows.Forms.CheckBox cbLessonInstructor;
        private System.Windows.Forms.CheckBox cbLessonTime;
        private System.Windows.Forms.CheckBox cbLessonPrice;
        private System.Windows.Forms.CheckBox cbLessonDesc;
        private System.Windows.Forms.CheckBox cbplacesAvailable;
        private System.Windows.Forms.CheckBox cbLessonDate;
        private System.Windows.Forms.CheckBox cbSLastName;
        private System.Windows.Forms.CheckBox cbSCellNo;
        private System.Windows.Forms.CheckBox cbSEmail;
        private System.Windows.Forms.CheckBox cbCredits;
        private System.Windows.Forms.CheckBox cbSFirstName;
        private System.Windows.Forms.CheckBox cbILastName;
        private System.Windows.Forms.CheckBox cbICellNo;
        private System.Windows.Forms.CheckBox cbIEmail;
        private System.Windows.Forms.CheckBox cbSalary;
        private System.Windows.Forms.CheckBox cbIFirstName;
        private System.Windows.Forms.GroupBox gbTicketSales;
        private System.Windows.Forms.CheckBox cbSaleTime;
        private System.Windows.Forms.CheckBox cbNoOfAdults;
        private System.Windows.Forms.CheckBox cbTotalOfSale;
        private System.Windows.Forms.CheckBox cbSalesEventID;
        private System.Windows.Forms.CheckBox cnNoOfPensioners;
        private System.Windows.Forms.CheckBox cnNoOfChildren;
        private System.Windows.Forms.CheckBox cbSaleDate;
        private System.Windows.Forms.GroupBox gbMessaging;
        private System.Windows.Forms.CheckBox cbReceiver;
        private System.Windows.Forms.CheckBox cbMessageText;
        private System.Windows.Forms.CheckBox cbMessageTime;
        private System.Windows.Forms.CheckBox cbMessageDate;
        private System.Windows.Forms.CheckBox cbSender;
        private System.Windows.Forms.GroupBox gbBackupLog;
        private System.Windows.Forms.CheckBox cbBackupTime;
        private System.Windows.Forms.CheckBox cbBackupDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbEventType;
        private System.Windows.Forms.CheckBox cbMaxSeats;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}