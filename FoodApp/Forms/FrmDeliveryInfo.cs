using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FoodApp.Model;

namespace FoodApp
{
    public partial class FrmDeliveryInfo : Form
    {
        public static string paymentmethod, gcash = "GCASH", cc = "CREDIT CARD";
  
        public FrmDeliveryInfo()
        {
            InitializeComponent();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelClear();
            this.Close();

        }
/*
        private void cmbPaymentMethodFormat(object sender, ListControlConvertEventArgs e)
        {
            if ((string)cmbPaymentMethodList.SelectedItem == gcash || (string)cmbPaymentMethodList.SelectedItem == cc)
            {

                paymentmethod = ((PaymentMethod)e.ListItem).paymentAcc;

                e.Value = paymentmethod + " Account No: " + txtAccNo.Text;
            }
        }*/

        private void btnSaveDeliveryInfo_Click(object sender, EventArgs e)
        {
            if ((string)cmbPaymentMethodList.SelectedItem == gcash )
            {
                
                paymentmethod = "Method " + gcash+ " Account No: " + txtAccNo.Text;
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

            string save = Model.Customer.InsertDeliveryInfo(txtFirstName.Text, txtLastName.Text, cmbBarangayList.Text, txtStreetAddress.Text, txtContactNo.Text , paymentmethod, txtOrderList.Text);
            DialogResult dialogResult = MessageBox.Show(save);

           
                if (dialogResult == DialogResult.OK)
            {
                this.Close();
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
            }


        }
/*        private bool FieldCheck()
        {
            
            bool firstnamecheck =false;
            bool lastnamecheck = false;
            bool barangaycheck = false;
            bool streetaddresscheck = false;
            bool contactcheck = false;
            bool paymentmethodcheck = false;

        
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.Focus();
                errorProvider1.SetIconAlignment(txtFirstName, ErrorIconAlignment.MiddleLeft);
                errorProvider1.SetError(txtFirstName, "First Name should not be left blank");
            }
            else
            {
                firstnamecheck = true;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.Focus();
                errorProvider2.SetIconAlignment(txtLastName, ErrorIconAlignment.MiddleLeft);
                errorProvider2.SetError(txtLastName, "Last Name should not be left blank");
            }
            else
            {
                lastnamecheck = true;
            }

            if (string.IsNullOrWhiteSpace(cmbBarangayList.Text))
            {
                cmbBarangayList.Focus();
                errorProvider3.SetIconAlignment(cmbBarangayList, ErrorIconAlignment.MiddleLeft);
                errorProvider3.SetError(cmbBarangayList, "Please Choose your Baranggay");
            }
            else
            {
                barangaycheck = true;
            }

            if (string.IsNullOrWhiteSpace(txtStreetAddress.Text))
            {
                txtStreetAddress.Focus();
                errorProvider4.SetIconAlignment(txtStreetAddress, ErrorIconAlignment.MiddleLeft);
                errorProvider4.SetError(txtStreetAddress, "Address should not be left blank");
            }
            else
            {
                streetaddresscheck = true;
            }

            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                txtContactNo.Focus();
                errorProvider5.SetIconAlignment(txtContactNo, ErrorIconAlignment.MiddleLeft);
                errorProvider5.SetError(txtContactNo, "Name should not be left blank!");
            }
            else
            {
                contactcheck = true;
            }

            if (string.IsNullOrWhiteSpace(cmbPaymentMethodList.Text))
            {
                cmbPaymentMethodList.Focus();
                errorProvider6.SetIconAlignment(cmbPaymentMethodList, ErrorIconAlignment.MiddleLeft);
                errorProvider6.SetError(cmbPaymentMethodList, "Please Choose a Payment Method");
            }
            else
            {
                paymentmethodcheck = true;
            }

             
            if (firstnamecheck != true && lastnamecheck != true && contactcheck != true && barangaycheck != true as&& paymentmethodcheck != true && streetaddresscheck != true)
            {
                
                return true;
            }
            else
            {
               
                return  false;
                
            }
        }*/

    
        private void CancelClear()
        {
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtContactNo.ResetText();
            txtStreetAddress.ResetText();
            cmbBarangayList.SelectedIndex = -1;
            cmbPaymentMethodList.SelectedIndex = -1;
            txtFirstName.Focus();
        }

        private void FrmDeliveryInfo_Load(object sender, EventArgs e)
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = PaymentMethod.GetPaymentMethod();
        }


        private void cmbPaymentMethodGcashCC(object sender, EventArgs e)
        {

            if ((string)cmbPaymentMethodList.SelectedItem == gcash ||(string)cmbPaymentMethodList.SelectedItem == cc) 
            {
                txtAccNo.Show();
                lblAccNo.Show();

            

            }
            else
            {
                txtAccNo.Hide();
            }
        }

      
    }
}
    

