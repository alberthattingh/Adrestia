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
        int selectedInstructor;

        public Instructors()
        {
            InitializeComponent();
        }

        private void BtnNewInstructor_Click(object sender, EventArgs e)
        {
            NewInstructor newInstructorForm = new NewInstructor();
            newInstructorForm.ShowDialog();
            PopulateGridView();
        }

        public void PopulateGridView()
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

        public void PopulateGridView(string query)
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
            try
            {
                if (selectedInstructor != 0)
                {
                    ChangeDetails editStudentForm = new ChangeDetails
                    {
                        instructorID = selectedInstructor.ToString()
                    };
                    editStudentForm.ShowDialog();
                    PopulateGridView();
                    connection.Close();
                }
                else
                    MessageBox.Show("Please select a Instructor");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void BtnRemoveInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedInstructor != 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete the instructor?", "Delete Instructor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection.Open();
                        string sql = "DELETE FROM [INSTRUCTOR] WHERE InstructorID = '" + selectedInstructor + "';";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        sql = "DELETE FROM [USER] WHERE UserID = '" + selectedInstructor + "';";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        PopulateGridView();
                    }
                }
                else
                    MessageBox.Show("Please select a Instructor");

            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void Instructors_Load(object sender, EventArgs e)
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGridView(txtSearch.Text);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                    selectedInstructor = (int)selectedRow.Cells["InstructorID"].Value;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please choose a row with values!");
                selectedInstructor = 0;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
