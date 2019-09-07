using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrestia
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show login form -- will only close if login is successful or exit button is used
            Login loginForm = new Login();
            loginForm.ShowDialog();

            // If login is successful (not when exit button is pressed)
            if (loginForm.DialogResult == DialogResult.OK)
            {
                // Run the main application
                // if-statement to open specific form, based on UserType
                //          Admin - Form1
                //          Instructor - Form2
                //          Student - Form3

                if (loginForm.UserType.Equals("1"))
                    Application.Run(new Form1(loginForm.UserID, loginForm.UserType));
                else if (loginForm.UserType.Equals("2"))
                    Application.Run(new Form2(loginForm.UserID, loginForm.UserType));
                else if (loginForm.UserType.Equals("3"))
                    Application.Run(new Form3(loginForm.UserID, loginForm.UserType));
                else
                {
                    MessageBox.Show("An unknown error occured. The program will now be terminated.");
                    Application.Exit();
                }
            }
            else
            {
                // Close the entire application, because the exit button was pressed
                Application.Exit();
            }
            
        }
    }
}
