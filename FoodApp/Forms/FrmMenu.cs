using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FoodApp
{
    public partial class FrmMenu : Form
    {
        public static string save, orderId, firstname, MilkteaName, OrderIdNo, qty;

        public string qtyMilktea { get; private set; }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pnlMilktea.Show();
         /*   pnlMenu.Show();*/

            cmbOrderID.DisplayMember = "OrderId" ;
            cmbOrderID.ValueMember = "OrderId";
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = OrderID.GetOrderID();
            cmbOrderID.DataSource = bindingSource1;
            cmbOrderID.SelectedItem = null;


            /*
                        dgMenuOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dgMenuOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;*/
            //LoadOrderList();


        }


        int TaroTotal, ChocoTotal, GreenTotal, JavaTotal, TotalPrice;
        

                          
        private void cmbOrderFormat(object sender, ListControlConvertEventArgs e)
        {
            
            orderId = ((OrderID)e.ListItem).OrderId;
            firstname = ((OrderID)e.ListItem).Firstname;
            e.Value = "Order # " + orderId + " Name: " + firstname;
            
        }
        private void btnBacktoMenu_Click(object sender, EventArgs e) 
        {

            this.Close();



        }

/*        private void btnPizzactg_Click(object sender, EventArgs e)
        {
            pnlMilktea.Show();
            pnlMenu.Hide();
            pnlMilktea.BringToFront();
        }*/

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            ClearCart();

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            qtyMilktea = lblOrderList.Text;
            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();
            }
            else
            {
                save = Model.Customer.InsertOrderList(orderId, qtyMilktea);
                string orderPlaced = "Your Order Has been Placed \n        Thank You";
                MessageBox.Show(orderPlaced);
            }
        }


        private void btnFinal_Click(object sender, EventArgs e)
        {
            /* if (cmbQuantityGreen.SelectedItem == null || cmbQuantityChoco.SelectedItem == null || cmbQuantityJava.SelectedItem || null && cmbQuantityTaro.SelectedItem == null)
             {
                 MessageBox.Show("Please Input Quantity");
             }*//*

            if (chkTaroPrl.Checked && cmbQuantityTaro.SelectedIndex != -1)
            {
                MilkteaName = "TaroPEARL";
                TaroTotal = int.Parse(cmbQuantityTaro.SelectedItem.ToString()) * 45;
                lblPrice.Text = TaroTotal.ToString();
                qtyMilktea += "qty: " + cmbQuantityTaro.SelectedItem + "-" + MilkteaName + "\n";
                
            }
            if (chkTaroPrl.Checked == false && cmbQuantityTaro.SelectedIndex != -1)
            {
                MilkteaName = "TaroNOPRL";
                TaroTotal = int.Parse(cmbQuantityTaro.SelectedItem.ToString()) * 30;
                lblPrice.Text = TaroTotal.ToString();
                qtyMilktea += "qty: " + cmbQuantityTaro.SelectedItem + "-" + MilkteaName + "\n";
              
            }

                *//* Green*//*
            if (chkGreenPrl.Checked && cmbQuantityGreen.SelectedIndex!= -1)
            {
                GreenTotal = int.Parse(cmbQuantityGreen.SelectedItem.ToString()) * 55;
                lblPrice.Text = GreenTotal.ToString();
                MilkteaName = "GreenPEARL";
                qtyMilktea += "qty: " + cmbQuantityGreen.SelectedItem + "-" + MilkteaName + "\n";
                

            }
            if (chkGreenPrl.Checked == false && cmbQuantityGreen.SelectedIndex != -1)
            {
                MilkteaName = "GreenAppleNOPRL";
*//*                GreenTotal = int.Parse(cmbQuantityGreen.SelectedItem.ToString()) * 40;
*//*                lblPrice.Text = GreenTotal.ToString();
                qtyMilktea += "qty: " + cmbQuantityGreen.SelectedItem + "-" + MilkteaName + "\n";
            
            }

            if (chkChocoPrl.Checked && cmbQuantityChoco.SelectedIndex!= -1)
            {
                ChocoTotal = int.Parse(cmbQuantityChoco.SelectedItem.ToString()) * 65;
                lblPrice.Text = ChocoTotal.ToString();
                MilkteaName = "ChocomaltPEARL";
                qtyMilktea += "qty: " + cmbQuantityChoco.SelectedItem + "-" + MilkteaName + "\n";
   
            }
            if (chkChocoPrl.Checked = false && cmbQuantityChoco.SelectedIndex != -1)
            {
                MilkteaName = "ChocomaltNOPRL";
                ChocoTotal = int.Parse(cmbQuantityChoco.SelectedItem.ToString()) * 50;
                lblPrice.Text += ChocoTotal.ToString();
                qtyMilktea += "qty: " + cmbQuantityChoco.SelectedItem + "-" + MilkteaName + "\n";
       
        
            }
            if (chkJavaPrl.Checked && cmbQuantityJava.SelectedIndex != -1)
            {
                JavaTotal = int.Parse(cmbQuantityJava.SelectedItem.ToString()) * 75;
                lblPrice.Text = JavaTotal.ToString();
                MilkteaName = "JavaPEARL";
                qtyMilktea += "qty: " + cmbQuantityJava.SelectedItem + "-" + MilkteaName + "\n";
  
            }
            if (chkJavaPrl.Checked == false && cmbQuantityJava.SelectedIndex != -1)
            {
                MilkteaName = "JavaNOPRL";
                JavaTotal = int.Parse(cmbQuantityJava.SelectedItem.ToString()) * 60;
                lblPrice.Text = JavaTotal.ToString();
                qtyMilktea = "qty: " + cmbQuantityJava.SelectedItem + "-" + MilkteaName + "\n";
        
            }

*/

            /*final cart */
            /*            lblOrderList.Text = qtyMilktea + " \n";
                        TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                        lblPrice.Text = TotalPrice.ToString();*/




            /*-------------------SELECT CUSTOMER ----------------------------*/


            /*            if (cmbOrderID.SelectedItem == null)
                        {
                            string OrderError = "Please Select Customer from List";
                            MessageBox.Show(OrderError);
                            cmbOrderID.Focus();


                            TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                            lblPrice.Text = TotalPrice.ToString();


                        }
                        else
                        {

                            MessageBox.Show(save);
                        }
                    }
                */
        }


        /*++++++++++++++++++++++++++++MENU LISTS+++++++++++++++++++++++++++++++++*/



        private void btnTaro_Click(object sender, EventArgs e)
        {

            if (chkTaroPrl.Checked && cmbQuantityTaro.SelectedIndex != -1)
            {   
                MilkteaName = "TaroPEARL";
                TaroTotal += int.Parse(cmbQuantityTaro.SelectedItem.ToString()) * 45;
                qtyMilktea = "qty: " + cmbQuantityTaro.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();
               

                Refresh();


            }
            if (chkTaroPrl.Checked == false  && cmbQuantityTaro.SelectedIndex != -1)
            {
                MilkteaName = "TaroNOPRL";
                TaroTotal += int.Parse(cmbQuantityTaro.SelectedItem.ToString()) * 30;
                qtyMilktea = "qty: " + cmbQuantityTaro.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();
                Refresh();

            }
/*            if (cmbOrderID.SelectedItem == null)
            {
                string OrderError = "Please Select Customer from List";
                MessageBox.Show(OrderError);
                cmbOrderID.Focus();
                Refresh();

            }
            else
            {
                save = Model.Customer.InsertOrderList(orderId, qtyMilktea);
                MessageBox.Show(save);
            }*/
        }


        private void btnChocoMalt_Click(object sender, EventArgs e)
        {

            
            if (chkChocoPrl.Checked && cmbQuantityChoco.SelectedIndex != -1)
            {
               

                ChocoTotal += int.Parse(cmbQuantityChoco.SelectedItem.ToString()) * 75;
              
                MilkteaName = "ChocomaltPEARL";
                qtyMilktea = "qty: " + cmbQuantityChoco.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();
               
                Refresh();

            }
            if (chkChocoPrl.Checked == false && cmbQuantityChoco.SelectedIndex != -1)
            {
                MilkteaName = "ChocomaltNOPRL";
                ChocoTotal += int.Parse(cmbQuantityChoco.SelectedItem.ToString()) * 60;
                qtyMilktea = "qty: " + cmbQuantityChoco.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();
                Refresh();

            }

        }
        private void btnJava_Click(object sender, EventArgs e)
        {

            if (chkJavaPrl.Checked && cmbQuantityJava.SelectedIndex!= -1)
            {
                JavaTotal += int.Parse(cmbQuantityJava.SelectedItem.ToString()) * 65;
                MilkteaName = "JavaPEARL";
                qtyMilktea = "qty: " + cmbQuantityJava.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();

                Refresh();



            }
            if (chkJavaPrl.Checked == false && cmbQuantityJava.SelectedIndex != -1)
            {
                MilkteaName = "JavaNOPRL";
                JavaTotal += int.Parse(cmbQuantityJava.SelectedItem.ToString()) * 50;
                qtyMilktea = "qty: " + cmbQuantityJava.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();

                Refresh();

            }

        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (chkGreenPrl.Checked && cmbQuantityGreen.SelectedIndex != -1)
            {

                GreenTotal += int.Parse(cmbQuantityGreen.SelectedItem.ToString()) * 55;
                MilkteaName = "GreenPEARL";
                qtyMilktea = "qty: " + cmbQuantityGreen.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();


                Refresh();


            }
            if (chkGreenPrl.Checked == false && cmbQuantityGreen.SelectedIndex != -1)

            {
                MilkteaName = "GreenAppleNOPRL";
                GreenTotal += int.Parse(cmbQuantityGreen.SelectedItem.ToString()) * 40; 
                qtyMilktea = "qty: " + cmbQuantityGreen.SelectedItem + "-" + MilkteaName + "\n";
                lblOrderList.Text += qtyMilktea;
                TotalPrice = GreenTotal + JavaTotal + ChocoTotal + TaroTotal;
                lblPrice.Text = TotalPrice.ToString();


                Refresh();

            }

        }

        /*+++++++++++++++++++++MENU LIST END++++++++++++++++++++++++++++++++++++*/

        private void ClearCart()
        {
            cmbQuantityChoco.ResetText();
            cmbQuantityChoco.SelectedIndex = -1;
            cmbQuantityJava.ResetText();
            cmbQuantityJava.SelectedIndex = -1;
            cmbQuantityTaro.ResetText();
            cmbQuantityTaro.SelectedIndex = -1;
            cmbQuantityGreen.ResetText();
            cmbQuantityGreen.SelectedIndex = -1;
            cmbOrderID.Focus();

            lblPrice.Text = "0";
            lblOrderList.Text = null;
            qtyMilktea = null;
            save = Model.Customer.InsertOrderList(orderId, qtyMilktea);
            MessageBox.Show("Cart Cleared");

        }

        //internal void LoadOrderList()
        //{
        //    dgMenuOrder.DataSource = MenuOrderList.GetMenuOrder();
        //}
    }
}
