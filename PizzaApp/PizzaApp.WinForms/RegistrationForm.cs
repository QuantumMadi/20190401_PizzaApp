using Models;
using PizzaApp.Services;
using PizzaAppDataAccess;
using Services;
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
    public partial class RegistrationForm : Form
    {
        private TableDataService<User> userDataService;
        private IntoDBRegistration<User> userRegistration;
        private SmsSender smsSender;
        public RegistrationForm()
        {
            InitializeComponent();
            Text = "Pizza Application";
            BackColor = Color.CornflowerBlue;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(800, 600);
            //ForeColor = Color.Red;
            Opacity = 100;       
        }
        public RegistrationForm(MainForm mainForm)
        {
            InitializeComponent();      
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            userDataService = new TableDataService<User>();
            smsSender = new SmsSender();
            userRegistration = new IntoDBRegistration<User>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             var user = new User
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Number = txtNumber.Text,
            };
            userRegistration.SendMessage += (message => smsSender.SendNotification(user.Number));
            userRegistration.ItemRegister(user, userDataService);
            this.Close();
        }   
    }
}
