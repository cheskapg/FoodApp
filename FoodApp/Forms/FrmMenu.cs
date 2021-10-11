using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class FrmMenu : Form
    {
        public static string PizzaName, OrderIdNo, qty;

        public string qtyPizza { get; private set; }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {   
            pnlPizza.Hide();
            pnlMenu.Show();

        }

        private void btnPizzactg_Click(object sender, EventArgs e)
        {
            pnlPizza.Show();

            pnlMenu.Hide();
            pnlPizza.BringToFront();
        }

        private void btnHamNCheese_Click(object sender, EventArgs e)
        {
            PizzaName = "HamNCheese";
            qtyPizza = "qty" + cmbQuantityHam.SelectedItem + " "+ PizzaName;
            
            int id = 16;

            string save = Model.Customer.InsertOrderList( id , qtyPizza);
            MessageBox.Show(save);
        }

    }
}
