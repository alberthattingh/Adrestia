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
    public partial class TicketSales : UserControl
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        double totalSale = 0.0;
        double adultSale = 0.0;
        double childrenSale = 0.0;
        double pensionerSale = 0.0;
        public TicketSales()
        {
            InitializeComponent();
        }

        private void TicketSales_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            string sql = "SELECT * FROM SPECIAL_EVENT";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!cbxEventID.Items.Contains(reader.GetValue(0)))
                {
                    cbxEventID.Items.Add(reader.GetValue(0));
                }

            }
            reader.Close();
            connection.Close();
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = "INSERT INTO TICKET_SALE VALUES (@date, @time, @noOfAdults, @noOfChildren, @noOfPensioners, @total, @eventId)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@date", datePicker.Value.ToShortDateString());
            command.Parameters.AddWithValue("@time", timePicker.Value.ToShortTimeString());
            command.Parameters.AddWithValue("@noOfAdults", numAdult.Value);
            command.Parameters.AddWithValue("@noOfChildren", numChildren.Value);
            command.Parameters.AddWithValue("@noOfPensioners", numPensioners.Value);
            command.Parameters.AddWithValue("@total", totalSale);
            command.Parameters.AddWithValue("@eventId", cbxEventID.SelectedItem);
            command.ExecuteNonQuery();
            MessageBox.Show("Sale Successfull!");
            connection.Close();
        }

        private void NumAdult_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalSale();
        }

        private void NumChildren_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalSale();
        }

        private void NumPensioners_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalSale();
        }

        private void CalculateTotalSale()
        {
            connection.Open();

            string sql = "SELECT * FROM SPECIAL_EVENT WHERE EventID = '" + cbxEventID.SelectedItem + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            reader.Read();

            adultSale = Convert.ToDouble(reader.GetValue(3)) * Convert.ToDouble(numAdult.Value);
            childrenSale = Convert.ToDouble(reader.GetValue(4)) * Convert.ToDouble(numChildren.Value);
            pensionerSale = Convert.ToDouble(reader.GetValue(5)) * Convert.ToDouble(numPensioners.Value);
            totalSale = adultSale + childrenSale + pensionerSale;
            lblSale.Text = "Total Of Sale: R" + totalSale;

            reader.Close();
            connection.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            numAdult.Value = 0;
            numAdult.Value = 0;
            numAdult.Value = 0;
            cbxEventID.SelectionLength = 0;
            datePicker.Value = DateTime.Today;
            //timePicker.Value = (DateTime)DateTime.Now.TimeOfDay;

        }
    }
}
