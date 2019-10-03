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
    public partial class NewStudent : Form
    {
        private const string DEFAULT_PASSWORD = "music123";
        private const int TYPE_STUDENT = 3;

        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;

        public NewStudent()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Remove newly created user when cancelled
            connection.Open();
            string sql = "DELETE FROM [USER] WHERE UserID = '" + txtID.Text + "';";
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private int GetStudentID()
        {
            string sql = "SELECT MAX(UserID) FROM [USER]";
            command = new SqlCommand(sql, connection);
            int id;

            try
            {
                id = (int) command.ExecuteScalar();
            }
            catch (Exception)
            {
                id = 1000;
            }
            return id;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "" && txtLast.Text == "" && txtCell.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Please enter the details of the student!");
                txtFirst.Focus();
            }
            else if (txtFirst.Text == "")
            {
                MessageBox.Show("Please enter the first name of the student!");
                txtFirst.Focus();
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Please enter the last name of the student!");
                txtLast.Focus();
            }
            else if (txtCell.Text == "")
            {
                MessageBox.Show("Please enter the cell number of the student!");
                txtCell.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter the email address of the student!");
                txtEmail.Focus();
            }
            else
            {

                connection.Open();
                string hashedPassword = Security.GetSHA1Hash(txtPass.Text);



                int studentId = GetStudentID();

                string sql = "INSERT INTO [USER] VALUES (@pw, @first, @last, @cell, @email, @type)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@pw", hashedPassword);
                command.Parameters.AddWithValue("@first", txtFirst.Text);
                command.Parameters.AddWithValue("@last", txtLast.Text);
                command.Parameters.AddWithValue("@cell", txtCell.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@type", TYPE_STUDENT);
                command.ExecuteNonQuery();

                sql = "INSERT INTO STUDENT VALUES (@id, @Credits)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", studentId);
                command.Parameters.AddWithValue("@credits", 0.0);
                command.ExecuteNonQuery();

                connection.Close();
                this.Close();
            }
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {           
            try
            {
                connection = new SqlConnection(connectionString);
                txtPass.Text = DEFAULT_PASSWORD;
            }
            catch (Exception err)
            {
                MessageBox.Show("DB Error: " + err.Message);
            }
        }
    }
}
