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
            reader.Close();

            string sql2 = "SELECT * FROM [INSTRUCTOR] WHERE InstructorID = '" + instructorID + "';";
            command = new SqlCommand(sql2, connection);
            reader = command.ExecuteReader();

            reader.Read();
            txtFirstname.Text = reader.GetValue(1).ToString();
            txtLastname.Text = reader.GetValue(2).ToString();
            txtCellNo.Text = reader.GetValue(3).ToString();
            txtEmail.Text = reader.GetValue(4).ToString();
            reader.Close();
            connection.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                txtConPassword.Clear();
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            connection.Open();


            if (txtPassword.Text != Security.GetSHA1Hash(DEFAULT_PASSWORD))
            {
                string hashedPassword = Security.GetSHA1Hash(txtPassword.Text);
                string sql1 = "UPDATE [USER] SET Password = '" + hashedPassword + "' WHERE UserID = '" + instructorID + "';";
                command = new SqlCommand(sql1, connection);
                command.ExecuteNonQuery();
            }

            string sql2 = "UPDATE INSTRUCTOR SET FirstName = '" + txtFirstname.Text + "', " +
                "LastName = '" + txtLastname.Text + "', " +
                "CellNo = '" + txtCellNo.Text + "', " +
                "Email = '" + txtEmail.Text + "' " +
                "WHERE InstructorID = '" + instructorID + "';";

            command = new SqlCommand(sql2, connection);
            command.ExecuteNonQuery();

            connection.Close();
            this.Close();
        }
    }
}
