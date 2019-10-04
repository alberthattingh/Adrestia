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
        public NewEvent()
        {
            InitializeComponent();
            
        }

        //Global variables
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public int userID;
       
        //Add event record to database
        private void BtnAddEvent_Click(object sender, EventArgs e)
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

                sql = "INSERT INTO SPECIAL_EVENT VALUES (@date, @time, @costAdult, @costChildren, @costPensioner, @id, @venue, @type)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@date", datePicker.Value.ToShortDateString());
                command.Parameters.AddWithValue("@time", timePicker.Value.ToShortTimeString());
                command.Parameters.AddWithValue("@costAdult", numAdult.Value);
                command.Parameters.AddWithValue("@costChildren", numChildren.Value);
                command.Parameters.AddWithValue("@costPensioner", numPensioners.Value);
                command.Parameters.AddWithValue("@id", this.userID);
                command.Parameters.AddWithValue("@venue", int.Parse(venueID));
                command.Parameters.AddWithValue("@type", int.Parse(typeID));
                command.ExecuteNonQuery();

                connection.Close();
                this.Close();
            }
        }


        //Cancel and close form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Add new event venue
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
                if (!cbxVenue.Items.Contains(reader.GetValue(1)))
                {
                    cbxVenue.Items.Add(reader.GetValue(1));
                }

            }
            reader.Close();
            connection.Close();
        }


        //Load event types and venues into comboboxes
        private void NewEvent_Load(object sender, EventArgs e)
        {
            datePicker.Focus();

            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM EVENT_TYPE";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(!cbxType.Items.Contains(reader.GetValue(1)))
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
            connection.Close();
        }


        // Add new event type
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
                if (!cbxType.Items.Contains(reader.GetValue(1)))
                {
                    cbxType.Items.Add(reader.GetValue(1));
                }
            }
            reader.Close();

            connection.Close();

        }

        private void BtnEditVenue_Click(object sender, EventArgs e)
        {
            if (cbxVenue.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a venue to edit");
            }
            else
            {
                EditVenue editvenue = new EditVenue()
                {
                    selectedVenue = cbxVenue.SelectedItem.ToString()
                };
                editvenue.ShowDialog();
                cbxVenue.Items.Clear();
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
        }

        private void BtnDeleteVenue_Click(object sender, EventArgs e)
        {
            if(cbxVenue.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a venue to delete");
            }
            else
            {
                
                connection.Open();
                string sql = "DELETE FROM VENUE WHERE Description = '" + cbxVenue.SelectedItem.ToString() + "';";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                cbxVenue.Items.Clear();
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
                connection.Close();
            }
        }

        private void BtnEditType_Click(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a venue to edit");
            }
            else
            {
                EditEventType editType = new EditEventType()
                {
                    selectedType = cbxType.SelectedItem.ToString()
                };
                editType.ShowDialog();
                cbxType.Items.Clear();
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
        }

        private void BtnDeleteType_Click(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an event type to delete");
            }
            else
            {
                
                connection.Open();
                string sql = "DELETE FROM EVENT_TYPE WHERE Description = '" + cbxType.SelectedItem.ToString() + "';";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                cbxType.Items.Clear();
                sql = "SELECT * FROM EVENT_TYPE";
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
        }
    }
}
