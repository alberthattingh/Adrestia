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
        public EditEvent()
        {
            InitializeComponent();
        }


        // Global variables
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public int eventID;


        //Load data into controls
        private void EditEvent_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sql = "SELECT * FROM EVENT_TYPE";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!cbxType.Items.Contains(reader.GetValue(1)))
                    {
                        cbxType.Items.Add(reader.GetValue(1));
                    }
                }
                reader.Close();

                sql = "SELECT * FROM VENUE";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!cbxVenue.Items.Contains(reader.GetValue(1)))
                    {
                        cbxVenue.Items.Add(reader.GetValue(1));
                    }

                }
                reader.Close();

                sql = "SELECT * FROM SPECIAL_EVENT WHERE EventID = '" + eventID + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                reader.Read();

                //datePicker.Value = (DateTime)reader.GetValue(1);
                //timePicker.Value = (DateTime)((TimeSpan)reader.GetValue(2));
                //numAdult.Value = decimal.Parse(reader.GetValue(3).ToString());
                //numChildren.Value = decimal.Parse(reader.GetValue(4).ToString());
                //numPensioners.Value = decimal.Parse(reader.GetValue(5).ToString());
                //cbxVenue.SelectedItem = reader.GetValue(6);
                //cbxType.SelectedItem = reader.GetValue(7);


                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        } 


        // Updaate event in database
        private void BtnEditEvent_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbxType.SelectedIndex < 0 && cbxVenue.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select an event venue and event type!");
                    cbxVenue.Focus();
                }
                else if (cbxType.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select an event type!");
                    cbxType.Focus();
                }
                else if (cbxVenue.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select an event venue!");
                    cbxVenue.Focus();

                }
                else
                {
                    connection.Open();
                    string venueID = "";
                    string typeID = "";

                    string sql = "SELECT EventTypeID FROM EVENT_TYPE WHERE Description ='" + cbxType.SelectedItem.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        typeID = reader.GetValue(0).ToString();
                    }
                    reader.Close();

                    sql = "SELECT VenueID FROM VENUE WHERE Description ='" + cbxVenue.SelectedItem.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        venueID = reader.GetValue(0).ToString();
                    }
                    reader.Close();

                    string sql2 = "UPDATE SPECIAL_EVENT SET EventDate = '" + datePicker.Value + "', " +
                        "EventTime = '" + timePicker.Value + "', " +
                        "CostAdult = '" + numAdult.Value + "', " +
                        "CostChildren = '" + numChildren.Value + "', " +
                        "CostPensioner = '" + numPensioners.Value + "', " +
                        "VenueID = '" + venueID + "', " +
                        "EventTypeID = '" + typeID + "' " +
                        "WHERE EventID = '" + eventID + "';";

                    command = new SqlCommand(sql2, connection);
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
        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        // Add new event venue
        private void BtnNewVenue_Click_1(object sender, EventArgs e)
        {
            try
            {
                NewEventVenue venueForm = new NewEventVenue();
                venueForm.ShowDialog();

                connection.Open();

                string sql = "SELECT * FROM VENUE";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!cbxVenue.Items.Contains(reader.GetValue(1)))
                    {
                        cbxVenue.Items.Add(reader.GetValue(1));
                    }

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }


        // Add new event type
        private void BtnNewType_Click_1(object sender, EventArgs e)
        {
            try
            {
                NewEventType typeForm = new NewEventType();
                typeForm.ShowDialog();

                connection.Open();

                string sql = "SELECT * FROM EVENT_TYPE";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!cbxType.Items.Contains(reader.GetValue(1)))
                    {
                        cbxType.Items.Add(reader.GetValue(1));
                    }
                }
                reader.Close();

                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
