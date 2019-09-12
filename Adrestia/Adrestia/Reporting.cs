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
    public partial class Reporting : UserControl
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;
        string sqlReport;
        char customReport;
        CustomReport customReportForm = new CustomReport();

        public Reporting()
        {
            InitializeComponent();
        }

        private void BtnTicketSales_Click(object sender, EventArgs e)
        {
            if (rbWeekly.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE WHERE SaleDate >= '" + DateTime.Today.AddDays(-7).ToShortDateString() + "'";
            }
            else if(rbMonthly.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE WHERE SaleDate >= '" + DateTime.Today.AddMonths(-1).ToShortDateString() + "'";
            }
            else if(rbYearly.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE WHERE SaleDate >= '" + DateTime.Today.AddYears(-1).ToShortDateString() + "'";

            }
            else if(rbAll.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE";
            }
            PopulateGridView(this.sqlReport);
            customReport = 'n';
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            customReportForm.ShowDialog();
            if(customReportForm.sqlReport != "")
            {
                PopulateGridView(customReportForm.sqlReport);
                customReport = 'y';
            }

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
        }

        public void PopulateGridView(string sqlReport)
        {
            try
            {
                connection.Open();

                string sql = sqlReport;
                command = new SqlCommand(sql, connection);
                ds = new DataSet();

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "ReportTable");

                dataGridView1.DataMember = "ReportTable";
                dataGridView1.DataSource = ds;

                adapter.Dispose();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                connection.Close();
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(customReport == 'y')
            {
                customReportForm.sqlReport += "";
            }
            else if (customReport == 'n')
            {
                this.sqlReport += "";
            }
        }
    }
}
