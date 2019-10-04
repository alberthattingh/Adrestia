﻿using System;
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

        private void HideAllControls()
        {
            messaging1.Visible = false;
            specialEvents1.Visible = false;
            lessonsInstructor1.Visible = false;
        }

        private void BtnMessaging_Click(object sender, EventArgs e)
        {
            HideAllControls();
            messaging1.Visible = true;
        }

        private void BtnLessons_Click(object sender, EventArgs e)
        {
            HideAllControls();
            lessonsInstructor1.Visible = true;
        }

        private void BtnSpecialEvents_Click(object sender, EventArgs e)
        {
            HideAllControls();
            specialEvents1.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            specialEvents1.userID = this.UserID;
            HideAllControls();
        }
    }
}
