using FoodApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class FrmWelcomeScreen : Form
    {
        public FrmWelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
            
        private void btnDeliveryInfo_Click(object sender, EventArgs e)
        {
            FrmDeliveryInfo frmDeliveryInfo = new FrmDeliveryInfo();
            frmDeliveryInfo.Show();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            FrmOrderList frmOrderList = new FrmOrderList();
            frmOrderList.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
