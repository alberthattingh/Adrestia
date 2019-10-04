using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adrestia
{
    public partial class EditEventType : Form
    {
        public EditEventType()
        {
            InitializeComponent();
        }
        public SqlConnection connection;
        public SqlCommand command;
        public string selectedType;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please enter a description!");
                txtDescription.Focus();
            }
            else
            {
                connection = new SqlConnection(Security.ConnectionString);
                connection.Open();
                string sql = "UPDATE EVENT_TYPE SET Description = '" + txtDescription.Text + "' " +
                    "WHERE Description = '" + selectedType + "';";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }
    }
}
