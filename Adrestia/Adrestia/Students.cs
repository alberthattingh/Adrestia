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
    public partial class Students : UserControl
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;

        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
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

            string sql = "SELECT * FROM STUDENT";
            command = new SqlCommand(sql, connection);
            ds = new DataSet();

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "StudentTable");

            dataGridView1.DataMember = "StudentTable";
            dataGridView1.DataSource = ds;

            adapter.Dispose();
            connection.Close();
        }

        public void PopulateGridView(string query)
        {
            connection.Open();

            string sql = "SELECT * FROM STUDENT " +
                "WHERE StudentID LIKE '%" + query + "%' OR " +
                "FirstName LIKE '%" + query + "%' OR " +
                "LastName LIKE '%" + query + "%' OR " +
                "Email LIKE '%" + query + "%'";

            command = new SqlCommand(sql, connection);
            ds = new DataSet();

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "StudentTable");

            dataGridView1.DataMember = "StudentTable";
            dataGridView1.DataSource = ds;

            adapter.Dispose();
            connection.Close();
        }

        private void BtnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent newStudentForm = new NewStudent();
            newStudentForm.ShowDialog();
            PopulateGridView();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGridView(txtSearch.Text);
        }

        private void BtnEditStudent_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text == "")
            {
                MessageBox.Show("Enter the StudentID of the student you wish to edit into the textbox below.");
                txtEdit.Focus();
                return;
            }

            // This query is only to check if the userID is valid
            connection.Open();
            string sql = "SELECT * FROM [USER] WHERE UserID = '" + txtEdit.Text + "';";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            
            if (!reader.HasRows)
            {
                MessageBox.Show("There aren't any students with the Student ID: " + txtEdit.Text);
                txtEdit.Clear();
                txtEdit.Focus();
                connection.Close();
                return;
            }
            connection.Close();

            EditStudent editStudentForm = new EditStudent
            {
                studentID = txtEdit.Text
            };
            editStudentForm.ShowDialog();
            txtEdit.Clear();
            txtEdit.Focus();

            PopulateGridView();
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Enter the StudentID of the student you wish to remove into the textbox below.");
            }
            else
            {
                try
                {
                    connection.Open();

                    // Check if studentID in table
                    string sql = "SELECT COUNT(*) FROM [STUDENT] WHERE StudentID = '" + txtDelete.Text + "';";
                    command = new SqlCommand(sql, connection);
                    int exists = (int)command.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("There aren't any students with the Student ID: " + txtDelete.Text);
                        connection.Close();
                        txtDelete.Clear();
                        txtDelete.Focus();
                        return;
                    }

                    sql = "DELETE FROM [STUDENT] WHERE StudentID = '" + txtDelete.Text + "';";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    sql = "DELETE FROM [USER] WHERE UserID = '" + txtDelete.Text + "';";
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

        private void BtnAddCredit_Click(object sender, EventArgs e)
        {
            AddCredit credit = new AddCredit();
            credit.ShowDialog();
            PopulateGridView();
        }
    }
}
