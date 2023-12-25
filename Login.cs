using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using com.sun.org.apache.xerces.@internal.impl.xs.opti;

namespace LanguageApp2
{


    public partial class Login : Form
    {
        private Label? lblValidationMessage;

        public Login()
        {
            InitializeComponent();

        }


        void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(loginUsernameTable.Text) && string.IsNullOrWhiteSpace(loginPasswordTable.Text))
            {
                MessageBox.Show("Username and Password cannot be empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
              if (string.IsNullOrWhiteSpace(loginUsernameTable.Text))
            {
                MessageBox.Show("Username cannot be empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
              if (string.IsNullOrWhiteSpace(loginPasswordTable.Text))
            {
                MessageBox.Show("Password cannot be empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
              if (string.IsNullOrWhiteSpace(loginUsernameTable.Text) && string.IsNullOrWhiteSpace(loginPasswordTable.Text))
            {
                MessageBox.Show("Username and Password cannot be empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainForm mainpart = new MainForm();
                mainpart.Show();
                this.Hide();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginUsernameTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
