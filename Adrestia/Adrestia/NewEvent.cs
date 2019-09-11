﻿using System;
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


        //Add event record to database
        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            connection.Open();
            string venueID = "";
            string typeID = "";

            string sql = "SELECT EventTypeID FROM EVENT_TYPE WHERE Description ='" + cbxType.SelectedItem.ToString() + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while(reader.Read())
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
               
            
            //if(cbxType.)
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
    }
}
