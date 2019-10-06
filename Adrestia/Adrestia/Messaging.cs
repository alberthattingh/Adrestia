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
    //DATABASE:
    public partial class Messaging : UserControl
    {
        public int userType;
        public int userID;

        private string receiverID;
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
            Connection = new SqlConnection(ConnectionString);
            rdpStudent.Checked = true;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (rdpStudent.Checked == true)
            {
                Connection.Open();

                string sql2;
                SqlDataReader reader2;

                sql2 = @"Select * from [USER] where FirstName = '" + cmbRecipient.Text + "' AND UserTypeID = 3";
                SqlCommand command2 = new SqlCommand(sql2, Connection);

                reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    receiverID = reader2.GetValue(0).ToString();
                }
                reader2.Close();
                Connection.Close();

                if (rdbReceived.Checked)
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
                        redOutput.Text = redOutput.Text + cmbRecipient.Text + " [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }
                    reader2.Close();
                    Connection.Close();
                }
                else
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
                        redOutput.Text = redOutput.Text + "You [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }
                    reader2.Close();
                    Connection.Close();
                }
            }
            else if (rdpInstructor.Checked == true)
            {
                Connection.Open();
                string sql2;
                SqlDataReader reader2;

                sql2 = @"Select * from [USER] where FirstName = '" + cmbRecipient.Text + "' AND UserTypeID = 2";
                SqlCommand command2 = new SqlCommand(sql2, Connection);

                reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    receiverID = reader2.GetValue(0).ToString();
                }
                reader2.Close();
                Connection.Close();

                if (rdbReceived.Checked)
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
                        redOutput.Text = redOutput.Text + cmbRecipient.Text + " [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }
                    reader2.Close();
                    Connection.Close();
                }
                else
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
                        redOutput.Text = redOutput.Text + "You [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }
                    reader.Close();
                    Connection.Close();
                }
            }
            else
            {
                //SqlConnection conn = new SqlConnection(ConnectionString);
                //conn.Open();
                Connection.Open();
                string sql2;
                SqlDataReader reader2;

                sql2 = @"Select UserID FROM [USER] WHERE UserTypeID = 1";
                SqlCommand command2 = new SqlCommand(sql2, Connection);

                reader2 = command2.ExecuteReader();

                reader2.Read();

                receiverID = reader2.GetValue(0).ToString();
                reader2.Close();
                Connection.Close();

                //receiverID = "1006";

                if (rdbReceived.Checked)
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
                        redOutput.Text = redOutput.Text + cmbRecipient.Text + " [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n";
                    }
                    reader.Close();
                    Connection.Close();
                }
                else
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
                        redOutput.Text = redOutput.Text + "You [" + reader.GetValue(4).ToString() + " " + reader.GetValue(5).ToString() + "]: " + reader.GetValue(3).ToString() + "\n\n";
                    }
                    reader.Close();
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

        private void RdpStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpStudent.Checked == true)
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();

                string sql;
                SqlDataAdapter adapter = new SqlDataAdapter();

                sql = @"Select * from [USER] WHERE UserTypeID = 3";
                Command = new SqlCommand(sql, Connection);

                DataSet ds = new DataSet();

                adapter.SelectCommand = Command;
                adapter.Fill(ds, "[USER]");
                
                //Load data into conversation coombobox
                cmbRecipient.DisplayMember = "FirstName";
                cmbRecipient.ValueMember = "FirstName";
                cmbRecipient.DataSource = ds.Tables["[USER]"];
                //Load into new message combobox:
                cmbReciever.DisplayMember = "FirstName";
                cmbReciever.ValueMember = "FirstName";
                cmbReciever.DataSource = ds.Tables["[USER]"];

                Connection.Close();
            }
            
        }

        private void RdpInstructor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpInstructor.Checked == true)
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();

                string sql;
                SqlDataAdapter adapter = new SqlDataAdapter();

                sql = @"Select * from [USER] WHERE UserTypeID =2";
                Command = new SqlCommand(sql, Connection);

                DataSet ds = new DataSet();

                adapter.SelectCommand = Command;
                adapter.Fill(ds, "[USER]");

                //Load into new message combobox:
                cmbRecipient.DisplayMember = "FirstName";
                cmbRecipient.ValueMember = "FirstName";
                cmbRecipient.DataSource = ds.Tables["[USER]"];
                //Load into new message combobox:
                cmbReciever.DisplayMember = "FirstName";
                cmbReciever.ValueMember = "FirstName";
                cmbReciever.DataSource = ds.Tables["[USER]"];

                Connection.Close();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text == "")
            {
                MessageBox.Show("You did not fill in a messagge");
            }
            else
            {
                string name = cmbReciever.GetItemText(cmbReciever.SelectedItem);//Name of person the mmessage is sent to
                string message = txtMessage.Text;
                int id;

                Connection = new SqlConnection(ConnectionString);
                Connection.Open();

                string getID;
                SqlDataReader reader3;

                if (rdpInstructor.Checked == true)
                {
                    getID = @"Select UserID from [USER]  where FirstName = '" + name + "' AND UserTypeID = 2";
                    SqlCommand command2 = new SqlCommand(getID, Connection);

                    reader3 = command2.ExecuteReader();

                    reader3.Read();
                    id = Convert.ToInt32(reader3.GetValue(0));
                    reader3.Close();

                    //Query:
                    string query = @"INSERT INTO MESSAGE VALUES(@Sender, @Receiver, @MessageText, @Date, @Time)";
                    //INSERT INTO DATABASE
                    SqlCommand comm = new SqlCommand(query, Connection);
                    comm.Parameters.AddWithValue("@Sender", userID);
                    comm.Parameters.AddWithValue("@Receiver", id);
                    comm.Parameters.AddWithValue("@MessageText", message);
                    comm.Parameters.AddWithValue("@Date", DateTime.Now);
                    comm.Parameters.AddWithValue("@Time", DateTime.Now);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Your message was succesfully sent!");
                    txtMessage.Clear();
                }
                else if (rdpStudent.Checked == true)
                {
                    getID = @"Select UserID from [USER] where FirstName = '" + name + "' AND UserTypeID = 3";
                    SqlCommand command2 = new SqlCommand(getID, Connection);

                    reader3 = command2.ExecuteReader();

                    reader3.Read();
                    id = Convert.ToInt32(reader3.GetValue(0));
                    reader3.Close();
                    //Query:
                    string query = @"INSERT INTO MESSAGE VALUES(@Sender, @Receiver, @MessageText, @Date, @Time)";
                    //INSERT INTO DATABASE
                    SqlCommand comm = new SqlCommand(query, Connection);
                    comm.Parameters.AddWithValue("@Sender", userID);
                    comm.Parameters.AddWithValue("@Receiver", id);
                    comm.Parameters.AddWithValue("@MessageText", message);
                    comm.Parameters.AddWithValue("@Date", DateTime.Now);
                    comm.Parameters.AddWithValue("@Time", DateTime.Now);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Your message was succesfully sent!");
                    txtMessage.Clear();
                }
                Connection.Close();
            }
        }

        private void TxtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void RdpAdmin_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
