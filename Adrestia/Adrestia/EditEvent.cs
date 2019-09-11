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
    public partial class EditEvent : Form
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public int eventID;

        public EditEvent()
        {
            InitializeComponent();
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
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

            sql = "SELECT * FROM SPECIAL_EVENT WHERE EventID = '" + eventID + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            reader.Read();

            datePicker.Value = Convert.ToDateTime(reader.GetValue(1));
           // timePicker.Value = Convert.ToDateTime(reader.GetValue(2));
            numAdult.Value = decimal.Parse(reader.GetValue(3).ToString());
            numChildren.Value = decimal.Parse(reader.GetValue(4).ToString());
            numPensioners.Value = decimal.Parse(reader.GetValue(5).ToString());
            //lbVenue.SelectedItem = reader.GetValue(6);
            //lbType.SelectedItem = reader.GetValue(7);


            connection.Close();
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

        private void BtnEditEvent_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql2 = "UPDATE SPECIAL_EVENT SET EventDate = '" + datePicker.Value + "', " +
                "EventTime = '" + timePicker.Value + "', " +
                "CostAdult = '" + numAdult.Value + "', " +
                "CostChildren = '" + numChildren.Value + "', " +
                "CostPensioners = '" + numPensioners.Value + "', " +
                "VenueID = '" + lbType.SelectedItem.ToString() + "', " +
                "EventTypeID = '" + lbType.SelectedItem.ToString() + "', " +
                "WHERE StudentID = '" + eventID + "';";

            command = new SqlCommand(sql2, connection);
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
