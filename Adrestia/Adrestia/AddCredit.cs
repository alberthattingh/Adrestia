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
        public string studentID;

        public AddCredit()
        {
            InitializeComponent();
        }

        private void AddCredit_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            txtID.Text = studentID;

            /*string sql = "SELECT * FROM STUDENT";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboStudentID.Items.Add(reader.GetValue(0));
            }

            reader.Close();
            connection.Close();*/

            string sql = "SELECT * FROM [USER]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            string first, last;
            while (reader.Read())
            {
                first = reader.GetString(2);
                last = reader.GetString(3);
                // current = double.Parse(reader.GetValue(5).ToString());
                if (reader.GetValue(0).ToString().Equals(studentID))
                {
                    txtFirst.Text = first;
                    txtLast.Text = last;


                    break;
                }
            }

            reader.Close();

            string sql2 = "SELECT * FROM STUDENT WHERE StudentID = '" + studentID + "'";
            SqlCommand cmd = new SqlCommand(sql2, connection);
            SqlDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                if (reader2.GetValue(0).ToString().Equals(studentID))
                {
                    current = double.Parse(reader2.GetValue(1).ToString());
                    break;
                }
            }

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
                if (studentID != null || studentID != "")
                {
                    newAmount = current + amount;
                    string sqlAmount = newAmount.ToString().Replace(',', '.');

                    connection.Open();
                    string sql = "UPDATE STUDENT SET Credits = " + sqlAmount + " WHERE StudentID = '" + studentID + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must select a student.");
                    txtID.Focus();
                    return;
                }
            }
        }

        private void ComboStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*connection.Open();

            string sql = "SELECT * FROM [USER]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();

            string first, last;
            while (reader.Read())
            {
                first = reader.GetString(2);
                last = reader.GetString(3);
                // current = double.Parse(reader.GetValue(5).ToString());
                if (reader.GetValue(0).Equals(comboStudentID.SelectedItem))
                {
                    txtFirst.Text = first;
                    txtLast.Text = last;

                    
                    break;
                }
            }

            reader.Close();

            string sql2 = "SELECT * FROM STUDENT WHERE StudentID = '" + comboStudentID.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql2, connection);
            SqlDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                if (reader2.GetValue(0).ToString().Equals(comboStudentID.SelectedItem.ToString()))
                {
                    current = double.Parse(reader2.GetValue(1).ToString());
                    break;
                }
            }

            connection.Close();*/
        }
    }
}
