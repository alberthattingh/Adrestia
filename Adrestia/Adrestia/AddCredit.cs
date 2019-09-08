using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrestia
{
    public partial class AddCredit : Form
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;

        public double current;

        public AddCredit()
        {
            InitializeComponent();
        }

        private void AddCredit_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM STUDENT";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboStudentID.Items.Add(reader.GetValue(0));
            }

            reader.Close();
            connection.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double amount, newAmount;
            if (!double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Invalid entry for credit amount.");
                txtAmount.Clear();
                txtAmount.Focus();
                return;
            }
            else
            {
                if (comboStudentID.SelectedItem != null || comboStudentID.SelectedItem.ToString() != "")
                {
                    newAmount = current + amount;

                    connection.Open();
                    string sql = "UPDATE STUDENT SET Credits = '" + newAmount + "' WHERE StudentID = '" + comboStudentID.SelectedItem.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must select a student.");
                    comboStudentID.Focus();
                    return;
                }
            }
        }

        private void ComboStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            string sql = "SELECT * FROM STUDENT";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            string first, last;
            while (reader.Read())
            {
                first = reader.GetString(1);
                last = reader.GetString(2);
                current = (double) reader.GetValue(5);
                if (reader.GetValue(0).Equals(comboStudentID.SelectedItem))
                {
                    txtFirst.Text = first;
                    txtLast.Text = last;
                    break;
                }
            }

            reader.Close();
            connection.Close();
        }
    }
}
