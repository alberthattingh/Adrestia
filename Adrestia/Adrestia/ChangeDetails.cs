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
    public partial class ChangeDetails : Form
    {
        private const string DEFAULT_PASSWORD = "music123";
        private const int TYPE_INSTRUCTOR = 2;

        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;

        public string instructorID;

        public ChangeDetails()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeDetails_Load(object sender, EventArgs e)
        {
            txtInstructorID.Text = instructorID;

            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql1 = "SELECT * FROM [USER] WHERE UserID = '" + instructorID + "';";
            command = new SqlCommand(sql1, connection);
            reader = command.ExecuteReader();

            reader.Read();
            txtPassword.Text = txtConPassword.Text = reader.GetValue(1).ToString();
            txtFirstname.Text = reader.GetValue(2).ToString();
            txtLastname.Text = reader.GetValue(3).ToString();
            txtCellNo.Text = reader.GetValue(4).ToString();
            txtEmail.Text = reader.GetValue(5).ToString();
            reader.Close();

            string sql2 = "SELECT * FROM INSTRUCTOR WHERE InstructorID = '" + instructorID + "';";
            command = new SqlCommand(sql2, connection);
            reader = command.ExecuteReader();

            reader.Read();
            numSalary.Value = (decimal)double.Parse(reader.GetValue(1).ToString());
            connection.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
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

            if (txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                txtConPassword.Clear();
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else if (txtFirstname.Text == "" && txtLastname.Text == "" && txtCellNo.Text == "" && txtEmail.Text == "")
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
                connection.Open();


                if (txtPassword.Text != Security.GetSHA1Hash(DEFAULT_PASSWORD))
                {
                    string hashedPassword = Security.GetSHA1Hash(txtPassword.Text);
                    string sql1 = "UPDATE [USER] SET Password = '" + hashedPassword + "' WHERE UserID = '" + instructorID + "';";
                    command = new SqlCommand(sql1, connection);
                    command.ExecuteNonQuery();
                }

                string sql2 = "UPDATE [USER] SET FirstName = '" + txtFirstname.Text + "', " +
                    "LastName = '" + txtLastname.Text + "', " +
                    "CellNo = '" + txtCellNo.Text + "', " +
                    "Email = '" + txtEmail.Text + "' " +
                    "WHERE UserID = '" + instructorID + "';";

                command = new SqlCommand(sql2, connection);
                command.ExecuteNonQuery();

                sql2 = "UPDATE INSTRUCTOR SET Salary = '" + numSalary.Value + "' " +
                    "WHERE InstructorID = '" + instructorID + "';";

                command = new SqlCommand(sql2, connection);
                command.ExecuteNonQuery();

                connection.Close();
                this.Close();
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
    }
}
