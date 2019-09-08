using System;
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
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;

        public SpecialEvents()
        {
            InitializeComponent();
        }

        private void SpecialEvents_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                PopulateGridView();
            }
            catch (Exception er)
            {
                MessageBox.Show("DB Error: " + er.Message);
            }
        }

        public void PopulateGridView()
        {
            connection.Open();

            string sql = "SELECT * FROM SPECIAL_EVENT";
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

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void BtnShowUpcoming_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = "SELECT * FROM SPECIAL_EVENT WHERE EventDate >='" + DateTime.Today + "';";
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

        private void BtnNewEvent_Click(object sender, EventArgs e)
        {
            NewEvent eventForm =new NewEvent();
            eventForm.ShowDialog();
            PopulateGridView();
        }

        private void BtnEditEvent_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text == "")
            {
                MessageBox.Show("Enter the EventID of the event you wish to edit into the textbox below.");
                txtEdit.Focus();
                return;
            }

            connection.Open();
            string sql = "SELECT * FROM [SPECIAL_EVENT] WHERE EventID = '" + txtEdit.Text + "';";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("There aren't any events with the EventID: " + txtEdit.Text);
                txtEdit.Clear();
                txtEdit.Focus();
                connection.Close();
                return;
            }
            connection.Close();

            EditEvent editEventForm = new EditEvent
            {
                eventID = txtEdit.Text
            };
            editEventForm.ShowDialog();
            txtEdit.Clear();
            txtEdit.Focus();

            PopulateGridView();
        }

        private void BtnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Enter the StudentID of the student you wish to remove into the textbox below.");
                txtDelete.Focus();
            }
            else
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT COUNT(*) FROM [SPECIAL_EVENT] WHERE EventID = '" + txtDelete.Text + "';";
                    command = new SqlCommand(sql, connection);
                    int exists = (int)command.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("There aren't any events with the Event ID: " + txtDelete.Text);
                        connection.Close();
                        txtDelete.Clear();
                        txtDelete.Focus();
                        return;
                    }

                    sql = "DELETE FROM [SPECIAL_EVENT] WHERE EventID = '" + txtDelete.Text + "';";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

            txtDelete.Clear();
            txtDelete.Focus();
            PopulateGridView();
        }
    }
}
