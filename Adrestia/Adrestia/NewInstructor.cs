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
            /*connection.Open();
            string sql = "DELETE FROM [USER] WHERE UserID = '" + txtInstructorID.Text + "';";
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();*/

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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                id = 1000;
            }

            connection.Close();
            return id + 1;
        }

        private void BtnAddInstructor_Click(object sender, EventArgs e)
        {
            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
            {
                errorProvider1.SetError(txtEmail, "The value entered is not a valid email address.");
                return;
            }

            if ((txtCellNo.Text.Length != 10) || !int.TryParse(txtCellNo.Text, out int x))
            {
                errorProvider1.SetError(txtCellNo, "The value entered is not a valid cell number.");
                return;
            }

            if (txtFirstname.Text == "" && txtLastname.Text == "" && txtCellNo.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Please enter the details of the instructor!");
                txtFirstname.Focus();
            }
            else if (txtFirstname.Text == "")
            {
                MessageBox.Show("Please enter the first name of the instructor!");
                txtFirstname.Focus();
            }
            else if (txtLastname.Text == "")
            {
                MessageBox.Show("Please enter the last name of the instructor!");
                txtLastname.Focus();
            }
            else if (txtCellNo.Text == "")
            {
                MessageBox.Show("Please enter the cell number of the instructor!");
                txtCellNo.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter the email address of the instructor!");
                txtEmail.Focus();
            }
            else
            {
                // Add the newly created user as a instructor
                connection.Open();

                int instructorId = int.Parse(txtInstructorID.Text);
                string hashedPassword = Security.GetSHA1Hash(txtPassword.Text);

                string sql = "INSERT INTO [USER] VALUES (@id, @pw, @first, @last, @cell, @email, @type)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", instructorId);
                command.Parameters.AddWithValue("@pw", hashedPassword);
                command.Parameters.AddWithValue("@first", txtFirstname.Text);
                command.Parameters.AddWithValue("@last", txtLastname.Text);
                command.Parameters.AddWithValue("@cell", txtCellNo.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@type", TYPE_INSTRUCTOR);
                command.ExecuteNonQuery();

                sql = "INSERT INTO INSTRUCTOR VALUES (@id, @salary)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", instructorId);
                command.Parameters.AddWithValue("@Salary", numSalary.Value);
                command.ExecuteNonQuery();

                connection.Close();
                this.Close();
            }
        }

        private void NewInstructor_Load(object sender, EventArgs e)
        {
            try
            {
                // Add new user
                connection = new SqlConnection(connectionString);     
                txtPassword.Text = DEFAULT_PASSWORD;
                txtInstructorID.Text = GetInstructorID().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("DB Error: " + err.Message);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
            {
                errorProvider1.SetError(txtEmail, "The value entered is not a valid email address.");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void TxtCellNo_Validating(object sender, CancelEventArgs e)
        {
            if ((txtCellNo.Text.Length != 10) || !int.TryParse(txtCellNo.Text, out int x))
            {
                errorProvider1.SetError(txtCellNo, "The value entered is not a valid cell number.");
            }
            else
            {
                errorProvider1.SetError(txtCellNo, "");
            }
        }
    }
}
