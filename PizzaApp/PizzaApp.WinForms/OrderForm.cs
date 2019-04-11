using Models;
using PizzaAppDataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaApp.WinForms
{
    public partial class OrderForm : Form
    {       
        private int _userId = 0;
        private int totalPrice = 0;
        private List<Pizza> pizzaList = new List<Pizza>();
        private List<Pizza> orderList = new List<Pizza>();
        private TableDataService<Order> orderDataService;
        public OrderForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            Text = "Pizza Application";
            BackColor = Color.CornflowerBlue;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(850, 500);
            //ForeColor = Color.Red;
            Opacity = 100;
        }

        private void lstPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPizza = lstPizzas.SelectedIndex;
            lstOrder.Items.Add(pizzaList[selectedPizza].Name);
            totalPrice += pizzaList[selectedPizza].Price;
            orderList.Add(pizzaList[selectedPizza]);
            lblPrice2.Text = "";
            lblPrice2.Text = totalPrice.ToString();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {            
            orderDataService = new TableDataService<Order>();
            TableDataService<Pizza> tableData = new TableDataService<Pizza>();        
            foreach(var pizza in tableData.GetAll())
            {
                lstPizzas.Items.Add($"{(pizza as Pizza).Name}  {(pizza as Pizza).Composition}  {(pizza as Pizza).Price}");               
                pizzaList.Add(pizza as Pizza);
            }
        }     

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Order order = new Order(orderList, _userId);          
            orderDataService.Add(order);
            MessageBox.Show("Your order has been accepted");
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItem!=null) {
                totalPrice -= pizzaList[lstOrder.SelectedIndex].Price;
                lblPrice2.Text = "";
                orderList.RemoveAt(lstOrder.SelectedIndex);
                lblPrice2.Text = totalPrice.ToString();
                lstOrder.Items.Remove(lstOrder.SelectedItem);
            }        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
    }
}
