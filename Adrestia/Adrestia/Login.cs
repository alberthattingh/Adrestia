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
    public partial class Login : Form
    {
        private string ConnectionString = Security.ConnectionString;
        private SqlConnection Connection;
        private SqlDataReader Reader;
        private SqlCommand Command;

        public string UserID;
        public string UserType;

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (BothBoxesEmpty())
            {
                MessageBox.Show("Please enter your user ID and password to login.");
                txtUserID.Focus();
            }
            else if (EmptyPassword())
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
            }
            else if (EmptyID())
            {
                MessageBox.Show("Please enter your user ID.");
                txtUserID.Focus();
            }
            else
            {
                LoginUser(txtUserID.Text, txtPassword.Text);
            }
        }

        private void LoginUser(string userID, string password)
        {
            Connection.Open();
            string hashedPassword = Security.GetSHA1Hash(password);
            string sql = "SELECT * FROM [USER]";
            Command = new SqlCommand(sql, Connection);

            string user, pass;
            bool validUser = false;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                user = Reader.GetValue(0).ToString();
                pass = Reader.GetValue(1).ToString();

                if (user.Equals(userID) && pass.Equals(hashedPassword))
                {
                    this.UserType = Reader.GetValue(2).ToString();
                    this.UserID = userID;
                    validUser = true;
                    break;
                }
            }
            Connection.Close();

            if (validUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();                
            }
            else
            {
                MessageBox.Show("User ID or password is incorrect. Please try again.");
                txtUserID.Clear();
                txtPassword.Clear();
                txtUserID.Focus();
            }
        }

        private bool BothBoxesEmpty()
        {
            if (EmptyPassword() && EmptyID())
                return true;
            else
                return false;
        }

        private bool EmptyID()
        {
            if (txtUserID.Text == "" || txtUserID.Text == null)
                return true;
            else
                return false;
        }

        private bool EmptyPassword()
        {
            if (txtPassword.Text == "" || txtPassword.Text == null)
                return true;
            else
                return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }
    }
}
