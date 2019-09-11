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
    public partial class Form2 : Form
    {
        public string UserID;
        public string UserType;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string id, string type)
        {
            InitializeComponent();
            this.UserID = id;
            this.UserType = type;
        }

        private void LessonsInstructor1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lessonsInstructor1.UserID = int.Parse(this.UserID);
            messaging1.userID = int.Parse(this.UserID);
            messaging1.userType = int.Parse(this.UserType);
            
    }

        private void Messaging1_Load(object sender, EventArgs e)
        {

        }
    }
}
