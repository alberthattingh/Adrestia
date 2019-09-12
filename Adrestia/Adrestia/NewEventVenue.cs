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
    public partial class NewEventVenue : Form
    {
        public NewEventVenue()
        {
            InitializeComponent();
        }


        //global variables
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;


        // Adds event type to database
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text == "" && numSeats.Value < 1)
                {
                    MessageBox.Show("Please enter a description and the number of seats!");
                    txtDescription.Focus();
                }
                else if(txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter a description!");
                    txtDescription.Focus();
                }
                else if(numSeats.Value < 1)
                {
                    MessageBox.Show("Please enter the number of seats!");
                    numSeats.Focus();
                }
                else
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    string sql = "INSERT INTO VENUE VALUES (@description, @seats)";
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@description", txtDescription.Text);
                    command.Parameters.AddWithValue("@seats", numSeats.Value);
                    command.ExecuteNonQuery();

                    connection.Close();
                    this.Close();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }


        // Closes form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Focus on textbox when form loads
        private void NewEventVenue_Load(object sender, EventArgs e)
        {
            txtDescription.Focus();
        }
    }
}
