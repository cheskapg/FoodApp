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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer editCustomer = new Customer
            {
                OrderId = (string)dgCustomerOrders.CurrentRow.Cells["colOrderId"].Value,
                Firstname = (string)dgCustomerOrders.CurrentRow.Cells["colFirstName"].Value,
                LastName = (string)dgCustomerOrders.CurrentRow.Cells["colLastName"].Value,
                Barangay = (string)dgCustomerOrders.CurrentRow.Cells["colBaranggay"].Value,
                StreetAddress = (string)dgCustomerOrders.CurrentRow.Cells["colStreetAddress"].Value,
                ContactNo = (string)dgCustomerOrders.CurrentRow.Cells["colContactNo"].Value,
                PaymentMethod = (string)dgCustomerOrders.CurrentRow.Cells["colPaymentMethod"].Value,
                OrderList = (string)dgCustomerOrders.CurrentRow.Cells["colOrderList"].Value
            };
            FrmEditCustomer frmEditCustomer = new FrmEditCustomer(editCustomer,this);
            frmEditCustomer.ShowDialog();   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           String OrderId = (string)dgCustomerOrders.CurrentRow.Cells["colOrderId"].Value;
            

           
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Order ID " + OrderId +"?" , "Confirm Delete", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                string delete = Customer.DeleteOrder(OrderId);
                MessageBox.Show(delete);
                this.Close();
                FrmOrderList frmOrderList1 = new FrmOrderList();
                frmOrderList1.Show();

            }
            
            

        }
    }
}


    




