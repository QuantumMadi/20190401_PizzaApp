using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Pizza Application";
            BackColor = Color.CornflowerBlue;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 600);
            //ForeColor = Color.Red;
            Opacity = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthentificationForm authentificationForm = new AuthentificationForm();
            authentificationForm.Show();
        }
    }
}
