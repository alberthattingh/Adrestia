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
        private string ConnectionString = Security.ConnectionString;
        private SqlConnection Connection;
        private SqlDataReader Reader;
        private SqlCommand Command;

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
            // List all controls that should be hidden here, and hide them, e.g. students control, instructors control, etc.
            // Not buttons on side panel
            //students1.Visible = false;
            //lessonsInstructor1.Visible = false;
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            // Hide all controls
            HideAllControls();

            // Make students control visible
            //students1.Visible = true;

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            // Hide all controls
            HideAllControls();

            // Make home control visible
            // home1.Visible = true;
        }

        private void Students1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)

        {

            HideAllControls();

            //lessonsInstructor1.UserID = this.UserID;

            //lessonsInstructor1.Visible = true;

        }



        private void LessonsInstructor1_Load(object sender, EventArgs e)

        {



        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
