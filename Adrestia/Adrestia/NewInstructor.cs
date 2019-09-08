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
    public partial class NewInstructor : Form
    {

        private const string DEFAULT_PASSWORD = "music123";
        private const int TYPE_INSTRUCTOR = 2;

        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;

        public NewInstructor()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Remove newly created user when cancelled
            connection.Open();
            string sql = "DELETE FROM [USER] WHERE UserID = '" + txtInstructorID.Text + "';";
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private int GetInstructorID()
        {
            connection.Open();
            string sql = "SELECT MAX(UserID) FROM [USER]";
            command = new SqlCommand(sql, connection);
            int id;

            try
            {
                id = (int)command.ExecuteScalar();
            }
            catch (Exception)
            {
                id = 0;
            }

            connection.Close();
            return id;
        }

        private void BtnAddInstructor_Click(object sender, EventArgs e)
        {
            // Add the newly created user as a student
            connection.Open();

            int instructorId = int.Parse(txtInstructorID.Text);

            string sql2 = "INSERT INTO INSTRUCTOR VALUES (@id, @first, @last, @cell, @email, @salary)";
            command = new SqlCommand(sql2, connection);
            command.Parameters.AddWithValue("@id", instructorId);
            command.Parameters.AddWithValue("@first", txtFirstname.Text);
            command.Parameters.AddWithValue("@last", txtLastname.Text);
            command.Parameters.AddWithValue("@cell", txtCellNo.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@salary", 0.0);
            command.ExecuteNonQuery();

            connection.Close();
            this.Close();
        }

        private void NewInstructor_Load(object sender, EventArgs e)
        {
            try
            {
                // Add new user
                connection = new SqlConnection(connectionString);
                connection.Open();

                txtPassword.Text = DEFAULT_PASSWORD;
                string hashedPassword = Security.GetSHA1Hash(txtPassword.Text);

                string sql1 = "INSERT INTO [USER] VALUES (@pw, @type)";
                command = new SqlCommand(sql1, connection);
                command.Parameters.AddWithValue("@pw", hashedPassword);
                command.Parameters.AddWithValue("@type", TYPE_INSTRUCTOR);
                command.ExecuteNonQuery();
                connection.Close();

                txtInstructorID.Text = GetInstructorID().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("DB Error: " + err.Message);
            }
        }
    }
}
