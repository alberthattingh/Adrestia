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
    public partial class Form1 : Form
    {
        public string UserID;
        public string UserType;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string id, string type)
        {
            InitializeComponent();
            this.UserID = id;
            this.UserType = type;
        }

        private void HideAllControls()
        {
            instructors1.Visible = false;
            students1.Visible = false;
            //messaging1.Visible = false;
            reporting1.Visible = false;
            ticketSales1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllControls();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            HideAllControls();
            students1.Visible = true;
        }

        private void BtnInstructors_Click(object sender, EventArgs e)
        {
            HideAllControls();
            instructors1.Visible = true;
        }

        private void BtnTicketSales_Click(object sender, EventArgs e)
        {
            HideAllControls();
            ticketSales1.Visible = true;
        }

        private void BtnMessaging_Click(object sender, EventArgs e)
        {
            HideAllControls();
            //messaging1.Visible = true;
        }

        private void BtnReporting_Click(object sender, EventArgs e)
        {
            HideAllControls();
            reporting1.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
