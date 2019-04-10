using Models;
using PizzaAppDataAccess;
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
    public partial class AuthentificationForm : Form
    {
        
        private TableDataService<User> tableDataService;
        public AuthentificationForm()
        {
            InitializeComponent();
            Text = "Pizza Application";
            BackColor = Color.CornflowerBlue;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 600);
            //ForeColor = Color.Red;
            Opacity = 100;
        }
         private void AuthentificationForm_Load(object sender, EventArgs e)
         {
              tableDataService = new TableDataService<User>();
         }
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (var user in tableDataService.GetAll())
            {
                if (((User)user).Number == txtNumber.Text)
                {
                    MessageBox.Show("Successful");
                    var referenceToOrder = new OrderForm((user as User).Id);                    
                    referenceToOrder.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("No such user");
                }
            }
            this.Close();
        }
    }
}
