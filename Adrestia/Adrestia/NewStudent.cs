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
        private string defaultPassword = "music123";

        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;

        public NewStudent()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetNextAvailableStudentID()
        {
            connection.Open();
            string sql = "SELECT MAX(UserID) FROM [USER]";
            command = new SqlCommand(sql, connection);
            int id;

            try
            {
                id = (int) command.ExecuteScalar();
            }
            catch (Exception)
            {
                id = 0;
            }
            
            connection.Close();
            return id + 1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql1 = "INSERT INTO [USER] VALUES (@pw, @type)";
            command = new SqlCommand(sql1, connection);
            command.Parameters.AddWithValue("@pw", txtPass.Text);
            command.Parameters.AddWithValue("@type", 3);
            command.ExecuteNonQuery();

            int studentId = int.Parse(txtID.Text);

            string sql2 = "INSERT INTO STUDENT VALUES (@id, @first, @last, @cell, @email, @credits, @instrument)";
            command = new SqlCommand(sql2, connection);
            command.Parameters.AddWithValue("@id", studentId);
            command.Parameters.AddWithValue("@first", txtFirst.Text);
            command.Parameters.AddWithValue("@last", txtLast.Text);
            command.Parameters.AddWithValue("@cell", txtCell.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@credits", DBNull.Value);
            command.Parameters.AddWithValue("@instrument", DBNull.Value);
            command.ExecuteNonQuery();

            connection.Close();
            this.Close();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {           
            try
            {
                connection = new SqlConnection(connectionString);
                txtPass.Text = defaultPassword;
                txtID.Text = GetNextAvailableStudentID().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("DB Error: " + err.Message);
            }
        }
    }
}
