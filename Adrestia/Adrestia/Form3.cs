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
    public partial class Form3 : Form
    {
        public string UserID;
        public string UserType;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string id, string type)
        {
            InitializeComponent();
            this.UserID = id;
            this.UserType = type;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
