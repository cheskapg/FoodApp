using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoodApp.Forms
{
    public partial class FrmOrderList : Form
    {
        public FrmOrderList()
        {
            InitializeComponent();
        }

        private void FrmOrderList_Load(object sender, EventArgs e)
        {
            dgCustomerOrders.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgCustomerOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            LoadCustomerList();
        }
        internal void LoadCustomerList()
        {
            var customer = Customer.GetCustomerOrder();

            foreach (var ListCustomer in customer)
            {
                dgCustomerOrders.Rows.Add(
                    ListCustomer.OrderId,
                    ListCustomer.Firstname,
                    ListCustomer.LastName,
                    ListCustomer.Barangay,
                    ListCustomer.StreetAddress,
                    ListCustomer.ContactNo,
                    ListCustomer.PaymentMethod,
                    ListCustomer.OrderList
                    );
            }
        }

    }
}
