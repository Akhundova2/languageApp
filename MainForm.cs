using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.Show();
            this.Hide();
        }

        private void languagesButton1_Click(object sender, EventArgs e)
        {
            Language languageForm = new Language();
            languageForm.Show();
            this.Hide();
        }

        private void feesButton1_Click(object sender, EventArgs e)
        {
            Fee feeForm = new Fee();
            feeForm.Show();
            this.Hide();
        }

        private void teachersButton1_Click(object sender, EventArgs e)
        {
            Teacher teacherForm = new Teacher();
            teacherForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
