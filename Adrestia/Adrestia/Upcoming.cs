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
    public partial class Upcoming : UserControl
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;
        public Upcoming()
        {
            InitializeComponent();
        }

        private void Upcoming_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM SPECIAL_EVENT WHERE EventDate >='" + DateTime.Today + "';";
            command = new SqlCommand(sql, connection);
            ds = new DataSet();

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "EventTable");

            dataGridView1.DataMember = "EventTable";
            dataGridView1.DataSource = ds;

            adapter.Dispose();
            connection.Close();
        }
    }
}
