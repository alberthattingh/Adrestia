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
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public NewEventVenue()
        {
            InitializeComponent();
        }

        private void BtnAddType_Click(object sender, EventArgs e)
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
