using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FoodApp.Forms;

namespace FoodApp
{
    public partial class FrmMenu : Form
    {
        public static string save, orderId, firstname, PizzaName, OrderIdNo, qty;

        public string qtyPizza { get; private set; }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pnlPizza.Hide();
            pnlMenu.Show();

            cmbOrderID.DisplayMember = "OrderId" ;
            cmbOrderID.ValueMember = "OrderId";
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = OrderID.GetOrderID();
            cmbOrderID.DataSource = bindingSource1;
            cmbOrderID.SelectedItem = null;
        }



        private void cmbOrderFormat(object sender, ListControlConvertEventArgs e)
        {
            
            orderId = ((OrderID)e.ListItem).OrderId;
             firstname = ((OrderID)e.ListItem).Firstname;
            e.Value = "Order # " + orderId + " Name: " + firstname;
            
        }
        private void btnBacktoMenu_Click(object sender, EventArgs e)
        {
            pnlPizza.Hide();
            pnlMenu.Show();
            pnlMenu.BringToFront();
        }

        private void btnPizzactg_Click(object sender, EventArgs e)
        {
            pnlPizza.Show();
            pnlMenu.Hide();
            pnlPizza.BringToFront();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {


            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();
            }
            else
            {
                string orderPlaced = "Your Order Has been Placed \n        Thank You";
                MessageBox.Show(orderPlaced);
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        /*++++++++++++++++++++++++++++MENU LISTS+++++++++++++++++++++++++++++++++*/



        private void btnMexicano_Click(object sender, EventArgs e)
        {
            PizzaName = "Mexicano";
            qtyPizza += "qty: " + cmbQuantityMexican.SelectedItem + "-" + PizzaName + "\n";
            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();

            }
            else
            {
                save = Model.Customer.InsertOrderList(orderId, qtyPizza);
                MessageBox.Show(save);
            }
        }
        private void btnHamNCheese_Click(object sender, EventArgs e)
        {
            PizzaName = "HamNCheese";
            qtyPizza += "qty: " + cmbQuantityHam.SelectedItem + "-"+ PizzaName + "\n";
            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();

            }
            else
            {
                save = Model.Customer.InsertOrderList(orderId, qtyPizza);
                MessageBox.Show(save);
            }
        }
        private void btnGehalo_Click(object sender, EventArgs e)
        {
            PizzaName = "Gehalo";
            qtyPizza += "qty: " + cmbQuantityGehalo.SelectedItem + "-" + PizzaName + "\n";
            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();

            }
            else
            {
                save = Model.Customer.InsertOrderList(orderId, qtyPizza);
                MessageBox.Show(save);
            }
        }
        private void btnMargherita_Click(object sender, EventArgs e)
        {
            PizzaName = "Margherita";
            qtyPizza += "qty: " + cmbQuantityMargherita.SelectedItem + "-" + PizzaName + "\n";
            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();

            }
            else
            {
                save = Model.Customer.InsertOrderList(orderId, qtyPizza);
                MessageBox.Show(save);
            }
        }

        /*+++++++++++++++++++++MENU LIST END++++++++++++++++++++++++++++++++++++*/

        private void ClearCart()
        {
            cmbQuantityHam.ResetText();
            cmbQuantityHam.SelectedIndex = -1;
            cmbQuantityGehalo.ResetText();
            cmbQuantityGehalo.SelectedIndex = -1;
            cmbQuantityMexican.ResetText();
            cmbQuantityMexican.SelectedIndex = -1;
            cmbQuantityMargherita.ResetText();
            cmbQuantityMargherita.SelectedIndex = -1;
            cmbOrderID.Focus();




        }
    }
}
