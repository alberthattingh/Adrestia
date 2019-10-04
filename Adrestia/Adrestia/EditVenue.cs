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
    public partial class EditVenue : Form
    {
        public EditVenue()
        {
            InitializeComponent();
        }
        public SqlConnection connection;
        public SqlCommand command;
        public string selectedVenue;
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter a description!");
                    txtDescription.Focus();
                }
                else if(numSeats.Value <= 0)
                {
                    MessageBox.Show("Please enter the number of seats!");
                    numSeats.Focus();
                }
                else
                {
                    connection = new SqlConnection(Security.ConnectionString);
                    connection.Open();
                    string sql = "UPDATE VENUE SET Description = '" + txtDescription.Text + "', " +
                        "MaxNoOfSeats = '" + numSeats.Value + "' " +
                        "WHERE Description = '" + selectedVenue + "';";
                    command = new SqlCommand(sql,connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                }
            }
            catch
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
