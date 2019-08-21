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
    public partial class EditStudent : Form
    {
        private const string DEFAULT_PASSWORD = "music123";
        private const int TYPE_STUDENT = 3;

        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;

        public string studentID;

        public EditStudent()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            txtID.Text = studentID;

            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql1 = "SELECT * FROM [USER] WHERE UserID = '" + studentID + "';";
            command = new SqlCommand(sql1, connection);
            reader = command.ExecuteReader();

            reader.Read();
            txtPass.Text = txtConfirm.Text = reader.GetValue(1).ToString();
            reader.Close();

            string sql2 = "SELECT * FROM [STUDENT] WHERE StudentID = '" + studentID + "';";
            command = new SqlCommand(sql2, connection);
            reader = command.ExecuteReader();

            reader.Read();
            txtFirst.Text = reader.GetValue(1).ToString();
            txtLast.Text = reader.GetValue(2).ToString();
            txtCell.Text = reader.GetValue(3).ToString();
            txtEmail.Text = reader.GetValue(4).ToString();
            reader.Close();
            connection.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!");
                txtConfirm.Clear();
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            connection.Open();

            
            if (txtPass.Text != Security.GetSHA1Hash(DEFAULT_PASSWORD))
            {
                string hashedPassword = Security.GetSHA1Hash(txtPass.Text);
                string sql1 = "UPDATE [USER] SET Password = '" + hashedPassword + "' WHERE UserID = '" + studentID + "';";
                command = new SqlCommand(sql1, connection);
                command.ExecuteNonQuery();
            }
              
            string sql2 = "UPDATE STUDENT SET FirstName = '" + txtFirst.Text + "', " +
                "LastName = '" + txtLast.Text + "', " +
                "CellNo = '" + txtCell.Text +"', " +
                "Email = '" + txtEmail.Text + "' " +
                "WHERE StudentID = '" + studentID + "';";

            command = new SqlCommand(sql2, connection);
            command.ExecuteNonQuery();

            connection.Close();
            this.Close();
        }
    }
}
