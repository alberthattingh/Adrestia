﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Adrestia
{
    public partial class Form1 : Form
    {
        public string UserID;
        public string UserType;
        public SqlConnection connection;
        public SqlCommand command;
        public string backupFileName = @"C:/Backup/";

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string id, string type)
        {
            InitializeComponent();
            this.UserID = id;
            this.UserType = type;
        }

        private void HideAllControls()
        {
            instructors1.Visible = false;
            students1.Visible = false;
            reporting1.Visible = false;
            ticketSales1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Security.ConnectionString);
            HideAllControls();
            students1.Visible = true;
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            HideAllControls();
            students1.Visible = true;
        }

        private void BtnInstructors_Click(object sender, EventArgs e)
        {
            HideAllControls();
            instructors1.Visible = true;
        }

        private void BtnTicketSales_Click(object sender, EventArgs e)
        {
            HideAllControls();
            ticketSales1.Visible = true;
        }

        private void BtnMessaging_Click(object sender, EventArgs e)
        {
            HideAllControls();
            // messaging1.Visible = true;
        }

        private void BtnReporting_Click(object sender, EventArgs e)
        {
            HideAllControls();
            reporting1.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {

                connection = new SqlConnection(Security.ConnectionString);
                connection.Open();
                string sql = "BACKUP DATABASE adrestia TO DISK = '" + backupFileName + "';";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                sql = @"INSERT INTO BACKUP_LOG VALUES (@date,@time)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@date", DateTime.Today);
                command.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());

                MessageBox.Show("Database backup up successfull!");
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Database backup up successfull");
            }
        }

        private void Messaging1_Load(object sender, EventArgs e)
        {

        }
    }
}
