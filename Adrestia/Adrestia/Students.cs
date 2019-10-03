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
        int selectedStudent;

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
            try
            {
                if (selectedStudent != 0)
                {
                    EditStudent editStudentForm = new EditStudent
                    {
                        studentID = selectedStudent.ToString()
                    };
                    editStudentForm.ShowDialog();
                    PopulateGridView();
                    connection.Close();
                }
                else
                    MessageBox.Show("Please select a student");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudent != 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete the student?", "Delete Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection.Open();
                        string sql = "DELETE FROM [STUDENT] WHERE StudentID = '" + selectedStudent + "';";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        sql = "DELETE FROM [USER] WHERE UserID = '" + selectedStudent + "';";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        PopulateGridView();
                    }
                }
                else
                    MessageBox.Show("Please select a student");

            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void BtnAddCredit_Click(object sender, EventArgs e)
        {
            AddCredit credit = new AddCredit();
            credit.ShowDialog();
            PopulateGridView();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                    selectedStudent = (int)selectedRow.Cells["StudentID"].Value;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please choose a row with values!");
                selectedStudent = 0;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
