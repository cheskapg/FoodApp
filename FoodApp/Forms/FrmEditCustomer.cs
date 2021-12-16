using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FoodApp.Model;

namespace FoodApp.Forms
{
    public partial class FrmEditCustomer : Form

    {
        public static string paymentmethod, gcash = "GCASH", cc = "CREDIT CARD";
        private FrmOrderList frmOrderList;
        public FrmEditCustomer()
        {
            InitializeComponent();
        }

        public FrmEditCustomer(Customer editCustomer, FrmOrderList frmOrderList) : this()
        {
            lblOrderId.Text = editCustomer.OrderId.ToString();
            txtFirstName.Text = editCustomer.Firstname;
            txtLastName.Text = editCustomer.LastName;
            cmbBarangayList.Text = editCustomer.Barangay.ToString();
            txtStreetAddress.Text = editCustomer.StreetAddress;
            txtContactNo.Text = editCustomer.ContactNo;
            cmbPaymentMethodList.Text = editCustomer.PaymentMethod.ToString();
            txtOrderList.Text = editCustomer.OrderList;
            this.frmOrderList = frmOrderList;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbPaymentMethodGcashCC(object sender, EventArgs e)
        {

            if ((string)cmbPaymentMethodList.SelectedItem == gcash || (string)cmbPaymentMethodList.SelectedItem == cc)
            {
                txtAccNo.Show();
                lblAccNo.Show();



            }
            else
            {
                txtAccNo.Hide();
                lblAccNo.Hide();
            }
        }

        private void btnSaveDeliveryInfo_Click(object sender, EventArgs e)
        {
            if ((string)cmbPaymentMethodList.SelectedItem == gcash)
            {

                paymentmethod = "Method " + gcash + " Account No: " + txtAccNo.Text;
                cmbPaymentMethodList.Text = paymentmethod;
            }
            else if ((string)cmbPaymentMethodList.SelectedItem == cc)
            {
                paymentmethod = "Method " + cc + " Account No: " + txtAccNo.Text;
                cmbPaymentMethodList.Text = paymentmethod;
            }
            else
            {
                cmbPaymentMethodList.Text = paymentmethod;
                paymentmethod = cmbPaymentMethodList.Text;
            }


            string response = Customer.EditCustomer
                (
                new Customer
                {
                    OrderId = lblOrderId.Text,
                    Firstname = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Barangay = cmbBarangayList.Text,
                    StreetAddress = txtStreetAddress.Text,
                    ContactNo = txtContactNo.Text,
                    PaymentMethod = paymentmethod,
                    OrderList = txtOrderList.Text

                }
                 );
            if (response.Equals("OrderEdit"))
            {
                frmOrderList.Close();
                MessageBox.Show("Data successfully Updated u dumbfuck");

                FrmOrderList frmOrderList1 = new FrmOrderList();
                frmOrderList1.Show();


            }

        }
    }
}
