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
        public string connectionString = @"Data Source=alberts-pc;User ID=albert;Password=sql123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;

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

        private void BtnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent newStudentForm = new NewStudent();
            newStudentForm.ShowDialog();
            PopulateGridView();
        }
    }
}
