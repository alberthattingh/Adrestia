using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrestia
{
    public partial class btnEvents : Form
    {
        public string UserID;
        public string UserType;

        public btnEvents()
        {
            InitializeComponent();
        }

        public btnEvents(string id, string type)
        {
            InitializeComponent();
            this.UserID = id;
            this.UserType = type;
        }

        private void HideAllControls()
        {
            //upcomingEvents1.Visible = false;
            studentLessons1.Visible = false;
            messaging1.Visible = false;
        }

        private void BtnBookLessons_Click(object sender, EventArgs e)
        {
            HideAllControls();
            studentLessons1.Visible = true;
        }

        private void BtnUpcoming_Click(object sender, EventArgs e)
        {
            HideAllControls();
            //studentLessons1.Visible = true;
        }

        private void BtnMessaging_Click(object sender, EventArgs e)
        {
            HideAllControls();
            messaging1.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Messaging1_Load(object sender, EventArgs e)
        {

        }
    }
}
