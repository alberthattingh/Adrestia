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
    public partial class Messaging : UserControl
    {
        private int userType = 2;
        private int userID = 1002;
        private string receiverID = "1003";
        private string ConnectionString = Security.ConnectionString;
        private SqlConnection Connection;
        private SqlDataReader Reader;
        private SqlCommand Command;

        public Messaging()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Messaging_Load(object sender, EventArgs e)
        {
            if (userType == 2)
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();

                string sql;
                SqlDataAdapter adapter = new SqlDataAdapter();

                sql = @"Select * from STUDENT";
                Command = new SqlCommand(sql, Connection);

                DataSet ds = new DataSet();

                adapter.SelectCommand = Command;
                adapter.Fill(ds, "STUDENT");

                cmbRecipient.DisplayMember = "FirstName";
                cmbRecipient.ValueMember = "FirstName";
                cmbRecipient.DataSource = ds.Tables["STUDENT"];

                Connection.Close();
            }
            else
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();

                string sql;
                SqlDataAdapter adapter = new SqlDataAdapter();

                sql = @"Select * from INSTRUCTOR";
                Command = new SqlCommand(sql, Connection);

                DataSet ds = new DataSet();

                adapter.SelectCommand = Command;
                adapter.Fill(ds, "INSTRUCTOR");

                cmbRecipient.DisplayMember = "FirstName";
                cmbRecipient.ValueMember = "FirstName";
                cmbRecipient.DataSource = ds.Tables["INSTRUCTOR"];

                Connection.Close();
            }

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (userType == 2)
            {
                Connection.Open();

                string sql2;
                SqlDataReader reader2;

                sql2 = @"Select * from STUDENT where FirstName = '" + cmbRecipient.Text + "'";
                SqlCommand command2 = new SqlCommand(sql2, Connection);

                reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    receiverID = reader2.GetValue(0).ToString();
                }

                Connection.Close();

                if (rdbReceived.Checked)
                {
                    Connection.Open();

                    string sql;
                    SqlDataReader reader;

                    sql = @"Select * from MESSAGE where Sender = '" + userID + "' and Receiver = '" + receiverID + "'";
                    Command = new SqlCommand(sql, Connection);

                    reader = Command.ExecuteReader();

                    redOutput.Text = "";
                    while (reader.Read())
                    {
                        redOutput.Text = redOutput.Text + cmbRecipient.Text + " [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n";
                    }

                    Connection.Close();
                }
                else
                {
                    Connection.Open();

                    string sql;
                    SqlDataReader reader;

                    sql = @"Select * from MESSAGE where Receiver = '" + userID + "' and Sender = '" + receiverID + "'";
                    Command = new SqlCommand(sql, Connection);

                    reader = Command.ExecuteReader();

                    redOutput.Text = "";
                    while (reader.Read())
                    {
                        redOutput.Text = redOutput.Text + "You [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }

                    Connection.Close();
                }
            }
            else
            {
                Connection.Open();

                string sql2;
                SqlDataReader reader2;

                sql2 = @"Select * from INSTRUCTOR where FirstName = '" + cmbRecipient.Text + "'";
                SqlCommand command2 = new SqlCommand(sql2, Connection);

                reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    receiverID = reader2.GetValue(0).ToString();
                }

                Connection.Close();

                if (rdbReceived.Checked)
                {
                    Connection.Open();

                    string sql;
                    SqlDataReader reader;

                    sql = @"Select * from MESSAGE where Sender = '" + userID + "' and Receiver = '" + receiverID + "'";
                    Command = new SqlCommand(sql, Connection);

                    reader = Command.ExecuteReader();

                    redOutput.Text = "";
                    while (reader.Read())
                    {
                        redOutput.Text = redOutput.Text + cmbRecipient.Text + " [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n";
                    }

                    Connection.Close();
                }
                else
                {
                    Connection.Open();

                    string sql;
                    SqlDataReader reader;

                    sql = @"Select * from MESSAGE where Receiver = '" + userID + "' and Sender = '" + receiverID + "'";
                    Command = new SqlCommand(sql, Connection);

                    reader = Command.ExecuteReader();

                    redOutput.Text = "";
                    while (reader.Read())
                    {
                        redOutput.Text = redOutput.Text + "You [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }

                    Connection.Close();
                }
            }
        }

        private void RdbSent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSent.Checked)
            {
                rdbReceived.Checked = false;
            }
        }

        private void RdbReceived_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReceived.Checked)
            {
                rdbSent.Checked = false;
            }
        }
    }
}
