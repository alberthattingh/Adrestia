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
    
    public partial class NewEvent : Form
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;

        public NewEvent()
        {
            InitializeComponent();
            
        }

        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            connection.Open();
            string venueID = "";
            string typeID = "";

            string sql = "SELECT EventTypeID FROM EVENT_TYPE WHERE Description ='" + lbType.SelectedItem.ToString() + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                typeID = reader.GetValue(0).ToString();
            }
            reader.Close();

             sql = "SELECT VenueID FROM VENUE WHERE Description ='" + lbVenue.SelectedItem.ToString() + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                venueID = reader.GetValue(0).ToString();
            }
            reader.Close();




            sql = "INSERT INTO SPECIAL_EVENT VALUES (@date, @time, @costAdult, @costChildren, @costPensioner, @venue, @type)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@date", datePicker.Value.ToShortDateString());
            command.Parameters.AddWithValue("@time", timePicker.Value.ToShortTimeString());
            command.Parameters.AddWithValue("@costAdult", numAdult.Value);
            command.Parameters.AddWithValue("@costChildren", numChildren.Value);
            command.Parameters.AddWithValue("@costPensioner", numPensioners.Value);
            command.Parameters.AddWithValue("@venue", int.Parse(venueID));
            command.Parameters.AddWithValue("@type", int.Parse(typeID));
            command.ExecuteNonQuery();

            connection.Close();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewVenue_Click(object sender, EventArgs e)
        {
            NewEventVenue venueForm = new NewEventVenue();
            venueForm.ShowDialog();

            connection.Open();

            string sql = "SELECT * FROM VENUE";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!lbVenue.Items.Contains(reader.GetValue(1)))
                {
                    lbVenue.Items.Add(reader.GetValue(1));
                }

            }
            reader.Close();
            connection.Close();
        }

        private void NewEvent_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM EVENT_TYPE";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(!lbType.Items.Contains(reader.GetValue(1)))
                {
                    lbType.Items.Add(reader.GetValue(1));
                }
            }
            reader.Close();

            sql = "SELECT * FROM VENUE";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!lbVenue.Items.Contains(reader.GetValue(1)))
                {
                    lbVenue.Items.Add(reader.GetValue(1));
                }
                    
            }
            reader.Close();
            connection.Close();
        }

        private void BtnNewType_Click(object sender, EventArgs e)
        {
            NewEventType typeForm = new NewEventType();
            typeForm.ShowDialog();

            connection.Open();

            string sql = "SELECT * FROM EVENT_TYPE";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!lbType.Items.Contains(reader.GetValue(1)))
                {
                    lbType.Items.Add(reader.GetValue(1));
                }
            }
            reader.Close();

            connection.Close();

        }
    }
}
