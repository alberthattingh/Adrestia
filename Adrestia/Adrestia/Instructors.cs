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
    public partial class Instructors : UserControl
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;

        public Instructors()
        {
            InitializeComponent();
        }

        private void BtnNewInstructor_Click(object sender, EventArgs e)
        {
            NewInstructor newInstructorForm = new NewInstructor();
            newInstructorForm.ShowDialog();
            DisplayGridView();
        }

        public void DisplayGridView()
        {
            connection.Open();

            string sql = "SELECT * FROM INSTRUCTOR";
            command = new SqlCommand(sql, connection);
            ds = new DataSet();

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "InstructorTable");

            dataGridView1.DataMember = "InstructorTable";
            dataGridView1.DataSource = ds;

            adapter.Dispose();
            connection.Close();
        }

        public void DisplayGridView(string query)
        {
            connection.Open();

            string sql = "SELECT * FROM INSTRUCTOR " +
                "WHERE InstructorID LIKE '%" + query + "%' OR " +
                "FirstName LIKE '%" + query + "%' OR " +
                "LastName LIKE '%" + query + "%' OR " +
                "Email LIKE '%" + query + "%'";

            command = new SqlCommand(sql, connection);
            ds = new DataSet();

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "InstructorTable");

            dataGridView1.DataMember = "InstructorTable";
            dataGridView1.DataSource = ds;

            adapter.Dispose();
            connection.Close();
        }

        private void BtnChangeDetails_Click(object sender, EventArgs e)
        {
            if (txtChangeDetails.Text == "")
            {
                MessageBox.Show("Enter the InstructorID of the instructor you wish to change the details into the textbox below.");
                txtChangeDetails.Focus();
                return;
            }

            // This query is only to check if the userID is valid
            connection.Open();
            string sql = "SELECT * FROM [USER] WHERE UserID = '" + txtChangeDetails.Text + "';";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("There aren't any instructors with the Instructor ID: " + txtChangeDetails.Text);
                txtChangeDetails.Clear();
                txtChangeDetails.Focus();
                connection.Close();
                return;
            }
            connection.Close();

            ChangeDetails changeDelailsForm = new ChangeDetails
            {
                instructorID = txtChangeDetails.Text
            };
            changeDelailsForm.ShowDialog();
            txtChangeDetails.Clear();
            txtChangeDetails.Focus();

            DisplayGridView();
        }

        private void BtnRemoveInstructor_Click(object sender, EventArgs e)
        {
            if (txtRemove.Text == "")
            {
                MessageBox.Show("Enter the InstructorID of the instructor you wish to remove into the textbox below.");
            }
            else
            {
                try
                {
                    connection.Open();

                    // Check if instructorId in table
                    string sql = "SELECT COUNT(*) FROM [INSTRUCTOR] WHERE InstructorID = '" + txtRemove.Text + "';";
                    command = new SqlCommand(sql, connection);
                    int exists = (int)command.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("There aren't any instructors with the Instructor ID: " + txtRemove.Text);
                        connection.Close();
                        txtRemove.Clear();
                        txtRemove.Focus();
                        return;
                    }

                    sql = "DELETE FROM [INSTRUCTOR] WHERE InstructorID = '" + txtRemove.Text + "';";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    sql = "DELETE FROM [USER] WHERE UserID = '" + txtRemove.Text + "';";
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

            txtRemove.Clear();
            txtRemove.Focus();
            DisplayGridView();
        }

        private void Instructors_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                DisplayGridView();
            }
            catch (Exception er)
            {
                MessageBox.Show("DB Error: " + er.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
