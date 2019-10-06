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
            PopulateGridView();
        }

        public void PopulateGridView()
        {
            connection.Open();

            string sql = "SELECT S.EventID, T.Description AS EventDescription, S.EventDate, S.EventTime, S.CostAdult, S.CostChildren, S.CostPensioner, U.LastName AS Organizer, V.Description AS Venue FROM SPECIAL_EVENT S, VENUE V, EVENT_TYPE T, [USER] U WHERE S.VenueID = V.VenueID AND S.EventTypeID = T.EventTypeID AND S.Organizer = U.UserID AND EventDate >='" + DateTime.Today + "';";
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
