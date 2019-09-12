using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adrestia
{
    public partial class NewEventType : Form
    {
        public NewEventType()
        {
            InitializeComponent();
        }


        // Global variables
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;


        // Add Event Type to database
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter a description!");
                    txtDescription.Focus();
                }
                else
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    string sql = "INSERT INTO EVENT_TYPE VALUES (@description)";
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@description", txtDescription.Text);
                    command.ExecuteNonQuery();

                    connection.Close();
                    this.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }


        // Closes the form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Focus on textbox
        private void NewEventType_Load(object sender, EventArgs e)
        {
            txtDescription.Focus();
        }
    }
}
