﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adrestia
{
    public partial class SpecialEvents : UserControl
    {
        public SpecialEvents()
        {
            InitializeComponent();
        }

        // public variables
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;
        int selectedEvent;
        public string userID;


        // Create connection to database and populate the gridview
        private void SpecialEvents_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                PopulateGridView();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }


        // Method to populate the Gridview
        public void PopulateGridView()
        {
            try
            {
                connection.Open();

                string sql = "SELECT S.EventID, T.Description AS EventDescription, S.EventDate, S.EventTime, S.CostAdult, S.CostChildren, S.CostPensioner, U.LastName AS Organizer, V.Description AS Venue FROM SPECIAL_EVENT S, VENUE V, EVENT_TYPE T, [USER] U WHERE S.VenueID = V.VenueID AND S.EventTypeID = T.EventTypeID AND S.Organizer = U.UserID";
                command = new SqlCommand(sql, connection);
                ds = new DataSet();

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "EventTable");

                dataGridView1.DataMember = "EventTable";
                dataGridView1.DataSource = ds;

                adapter.Dispose();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            
        }


        // Populates the gridview when button is clicked
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateGridView();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        
        // Shows the upcoming events in the gridview when button is clicked
        private void BtnShowUpcoming_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = "SELECT S.EventID, T.Description AS EventDescription, S.EventDate, S.EventTime, S.CostAdult, S.CostChildren, S.CostPensioner, U.LastName AS Organizer, V.Description AS Venue FROM SPECIAL_EVENT S, VENUE V, EVENT_TYPE T, [USER] U WHERE S.VenueID = V.VenueID AND S.EventTypeID = T.EventTypeID AND S.Organizer = U.UserID AND EventDate >='" + DateTime.Today + "';";
                command = new SqlCommand(sql, connection);
                ds = new DataSet();

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "EventTable");

                dataGridView1.DataMember = "EventTable";
                dataGridView1.DataSource = ds;

                adapter.Dispose();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        // Show the form to create a new special event
        private void BtnNewEvent_Click(object sender, EventArgs e)
        {
            try
            {
                NewEvent eventForm = new NewEvent()
                {
                    userID = int.Parse(this.userID)
                };
                eventForm.ShowDialog();
                PopulateGridView();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            
        }


        // Edit an existing special event
        private void BtnEditEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEvent != 0)
                {
                    EditEvent editEventForm = new EditEvent
                    {
                        eventID = selectedEvent
                    };
                    editEventForm.ShowDialog();
                    PopulateGridView();
                }
                else
                    MessageBox.Show("Please select an event");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }


        // Delete an existing special event
        private void BtnDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedEvent != 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete the student?", "Delete Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection.Open();
                        string sql = "DELETE FROM SPECIAL_EVENT WHERE EventID = '" + selectedEvent + "'";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        PopulateGridView();
                    }
                }
                else
                    MessageBox.Show("Please select an event");

            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        // Gets eventID of selected row of datagridview
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                    selectedEvent = (int)selectedRow.Cells["EventID"].Value;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a row with values!");
                selectedEvent = 0;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
