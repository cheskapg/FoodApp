
namespace FoodApp.Forms
{
    partial class FrmEditCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditCustomer));
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAccNo = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveDeliveryInfo = new System.Windows.Forms.Button();
            this.cmbPaymentMethodList = new System.Windows.Forms.ComboBox();
            this.cmbBarangayList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // lblAccNo
            // 
            resources.ApplyResources(this.lblAccNo, "lblAccNo");
            this.lblAccNo.Name = "lblAccNo";
            // 
            // txtAccNo
            // 
            resources.ApplyResources(this.txtAccNo, "txtAccNo");
            this.txtAccNo.Name = "txtAccNo";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtContactNo
            // 
            resources.ApplyResources(this.txtContactNo, "txtContactNo");
            this.txtContactNo.Name = "txtContactNo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnSaveDeliveryInfo
            // 
            resources.ApplyResources(this.btnSaveDeliveryInfo, "btnSaveDeliveryInfo");
            this.btnSaveDeliveryInfo.Name = "btnSaveDeliveryInfo";
            this.btnSaveDeliveryInfo.UseVisualStyleBackColor = true;
            this.btnSaveDeliveryInfo.Click += new System.EventHandler(this.btnSaveDeliveryInfo_Click);
            // 
            // cmbPaymentMethodList
            // 
            this.cmbPaymentMethodList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPaymentMethodList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethodList.FormattingEnabled = true;
            this.cmbPaymentMethodList.Items.AddRange(new object[] {
            resources.GetString("cmbPaymentMethodList.Items"),
            resources.GetString("cmbPaymentMethodList.Items1"),
            resources.GetString("cmbPaymentMethodList.Items2"),
            resources.GetString("cmbPaymentMethodList.Items3")});
            resources.ApplyResources(this.cmbPaymentMethodList, "cmbPaymentMethodList");
            this.cmbPaymentMethodList.Name = "cmbPaymentMethodList";
            this.cmbPaymentMethodList.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethodGcashCC);
            // 
            // cmbBarangayList
            // 
            this.cmbBarangayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarangayList.FormattingEnabled = true;
            this.cmbBarangayList.Items.AddRange(new object[] {
            resources.GetString("cmbBarangayList.Items"),
            resources.GetString("cmbBarangayList.Items1"),
            resources.GetString("cmbBarangayList.Items2"),
            resources.GetString("cmbBarangayList.Items3"),
            resources.GetString("cmbBarangayList.Items4"),
            resources.GetString("cmbBarangayList.Items5"),
            resources.GetString("cmbBarangayList.Items6"),
            resources.GetString("cmbBarangayList.Items7"),
            resources.GetString("cmbBarangayList.Items8"),
            resources.GetString("cmbBarangayList.Items9"),
            resources.GetString("cmbBarangayList.Items10"),
            resources.GetString("cmbBarangayList.Items11"),
            resources.GetString("cmbBarangayList.Items12"),
            resources.GetString("cmbBarangayList.Items13"),
            resources.GetString("cmbBarangayList.Items14"),
            resources.GetString("cmbBarangayList.Items15"),
            resources.GetString("cmbBarangayList.Items16"),
            resources.GetString("cmbBarangayList.Items17"),
            resources.GetString("cmbBarangayList.Items18"),
            resources.GetString("cmbBarangayList.Items19"),
            resources.GetString("cmbBarangayList.Items20"),
            resources.GetString("cmbBarangayList.Items21"),
            resources.GetString("cmbBarangayList.Items22"),
            resources.GetString("cmbBarangayList.Items23"),
            resources.GetString("cmbBarangayList.Items24"),
            resources.GetString("cmbBarangayList.Items25"),
            resources.GetString("cmbBarangayList.Items26"),
            resources.GetString("cmbBarangayList.Items27"),
            resources.GetString("cmbBarangayList.Items28"),
            resources.GetString("cmbBarangayList.Items29"),
            resources.GetString("cmbBarangayList.Items30"),
            resources.GetString("cmbBarangayList.Items31"),
            resources.GetString("cmbBarangayList.Items32"),
            resources.GetString("cmbBarangayList.Items33"),
            resources.GetString("cmbBarangayList.Items34"),
            resources.GetString("cmbBarangayList.Items35"),
            resources.GetString("cmbBarangayList.Items36"),
            resources.GetString("cmbBarangayList.Items37"),
            resources.GetString("cmbBarangayList.Items38"),
            resources.GetString("cmbBarangayList.Items39"),
            resources.GetString("cmbBarangayList.Items40"),
            resources.GetString("cmbBarangayList.Items41"),
            resources.GetString("cmbBarangayList.Items42"),
            resources.GetString("cmbBarangayList.Items43"),
            resources.GetString("cmbBarangayList.Items44"),
            resources.GetString("cmbBarangayList.Items45"),
            resources.GetString("cmbBarangayList.Items46"),
            resources.GetString("cmbBarangayList.Items47"),
            resources.GetString("cmbBarangayList.Items48"),
            resources.GetString("cmbBarangayList.Items49"),
            resources.GetString("cmbBarangayList.Items50"),
            resources.GetString("cmbBarangayList.Items51"),
            resources.GetString("cmbBarangayList.Items52"),
            resources.GetString("cmbBarangayList.Items53"),
            resources.GetString("cmbBarangayList.Items54"),
            resources.GetString("cmbBarangayList.Items55"),
            resources.GetString("cmbBarangayList.Items56"),
            resources.GetString("cmbBarangayList.Items57"),
            resources.GetString("cmbBarangayList.Items58"),
            resources.GetString("cmbBarangayList.Items59"),
            resources.GetString("cmbBarangayList.Items60"),
            resources.GetString("cmbBarangayList.Items61"),
            resources.GetString("cmbBarangayList.Items62"),
            resources.GetString("cmbBarangayList.Items63"),
            resources.GetString("cmbBarangayList.Items64"),
            resources.GetString("cmbBarangayList.Items65"),
            resources.GetString("cmbBarangayList.Items66"),
            resources.GetString("cmbBarangayList.Items67"),
            resources.GetString("cmbBarangayList.Items68"),
            resources.GetString("cmbBarangayList.Items69"),
            resources.GetString("cmbBarangayList.Items70"),
            resources.GetString("cmbBarangayList.Items71"),
            resources.GetString("cmbBarangayList.Items72"),
            resources.GetString("cmbBarangayList.Items73"),
            resources.GetString("cmbBarangayList.Items74"),
            resources.GetString("cmbBarangayList.Items75"),
            resources.GetString("cmbBarangayList.Items76"),
            resources.GetString("cmbBarangayList.Items77"),
            resources.GetString("cmbBarangayList.Items78"),
            resources.GetString("cmbBarangayList.Items79"),
            resources.GetString("cmbBarangayList.Items80"),
            resources.GetString("cmbBarangayList.Items81"),
            resources.GetString("cmbBarangayList.Items82"),
            resources.GetString("cmbBarangayList.Items83"),
            resources.GetString("cmbBarangayList.Items84"),
            resources.GetString("cmbBarangayList.Items85"),
            resources.GetString("cmbBarangayList.Items86"),
            resources.GetString("cmbBarangayList.Items87"),
            resources.GetString("cmbBarangayList.Items88"),
            resources.GetString("cmbBarangayList.Items89"),
            resources.GetString("cmbBarangayList.Items90"),
            resources.GetString("cmbBarangayList.Items91"),
            resources.GetString("cmbBarangayList.Items92"),
            resources.GetString("cmbBarangayList.Items93"),
            resources.GetString("cmbBarangayList.Items94"),
            resources.GetString("cmbBarangayList.Items95"),
            resources.GetString("cmbBarangayList.Items96"),
            resources.GetString("cmbBarangayList.Items97"),
            resources.GetString("cmbBarangayList.Items98"),
            resources.GetString("cmbBarangayList.Items99"),
            resources.GetString("cmbBarangayList.Items100"),
            resources.GetString("cmbBarangayList.Items101"),
            resources.GetString("cmbBarangayList.Items102"),
            resources.GetString("cmbBarangayList.Items103"),
            resources.GetString("cmbBarangayList.Items104"),
            resources.GetString("cmbBarangayList.Items105"),
            resources.GetString("cmbBarangayList.Items106"),
            resources.GetString("cmbBarangayList.Items107"),
            resources.GetString("cmbBarangayList.Items108"),
            resources.GetString("cmbBarangayList.Items109"),
            resources.GetString("cmbBarangayList.Items110"),
            resources.GetString("cmbBarangayList.Items111"),
            resources.GetString("cmbBarangayList.Items112"),
            resources.GetString("cmbBarangayList.Items113"),
            resources.GetString("cmbBarangayList.Items114"),
            resources.GetString("cmbBarangayList.Items115"),
            resources.GetString("cmbBarangayList.Items116"),
            resources.GetString("cmbBarangayList.Items117"),
            resources.GetString("cmbBarangayList.Items118"),
            resources.GetString("cmbBarangayList.Items119"),
            resources.GetString("cmbBarangayList.Items120"),
            resources.GetString("cmbBarangayList.Items121"),
            resources.GetString("cmbBarangayList.Items122"),
            resources.GetString("cmbBarangayList.Items123"),
            resources.GetString("cmbBarangayList.Items124"),
            resources.GetString("cmbBarangayList.Items125"),
            resources.GetString("cmbBarangayList.Items126"),
            resources.GetString("cmbBarangayList.Items127"),
            resources.GetString("cmbBarangayList.Items128"),
            resources.GetString("cmbBarangayList.Items129"),
            resources.GetString("cmbBarangayList.Items130"),
            resources.GetString("cmbBarangayList.Items131"),
            resources.GetString("cmbBarangayList.Items132"),
            resources.GetString("cmbBarangayList.Items133"),
            resources.GetString("cmbBarangayList.Items134"),
            resources.GetString("cmbBarangayList.Items135"),
            resources.GetString("cmbBarangayList.Items136"),
            resources.GetString("cmbBarangayList.Items137"),
            resources.GetString("cmbBarangayList.Items138"),
            resources.GetString("cmbBarangayList.Items139"),
            resources.GetString("cmbBarangayList.Items140"),
            resources.GetString("cmbBarangayList.Items141"),
            resources.GetString("cmbBarangayList.Items142"),
            resources.GetString("cmbBarangayList.Items143"),
            resources.GetString("cmbBarangayList.Items144"),
            resources.GetString("cmbBarangayList.Items145"),
            resources.GetString("cmbBarangayList.Items146"),
            resources.GetString("cmbBarangayList.Items147"),
            resources.GetString("cmbBarangayList.Items148"),
            resources.GetString("cmbBarangayList.Items149"),
            resources.GetString("cmbBarangayList.Items150"),
            resources.GetString("cmbBarangayList.Items151"),
            resources.GetString("cmbBarangayList.Items152"),
            resources.GetString("cmbBarangayList.Items153"),
            resources.GetString("cmbBarangayList.Items154"),
            resources.GetString("cmbBarangayList.Items155"),
            resources.GetString("cmbBarangayList.Items156"),
            resources.GetString("cmbBarangayList.Items157"),
            resources.GetString("cmbBarangayList.Items158"),
            resources.GetString("cmbBarangayList.Items159"),
            resources.GetString("cmbBarangayList.Items160"),
            resources.GetString("cmbBarangayList.Items161"),
            resources.GetString("cmbBarangayList.Items162"),
            resources.GetString("cmbBarangayList.Items163"),
            resources.GetString("cmbBarangayList.Items164"),
            resources.GetString("cmbBarangayList.Items165"),
            resources.GetString("cmbBarangayList.Items166"),
            resources.GetString("cmbBarangayList.Items167"),
            resources.GetString("cmbBarangayList.Items168"),
            resources.GetString("cmbBarangayList.Items169"),
            resources.GetString("cmbBarangayList.Items170"),
            resources.GetString("cmbBarangayList.Items171"),
            resources.GetString("cmbBarangayList.Items172"),
            resources.GetString("cmbBarangayList.Items173"),
            resources.GetString("cmbBarangayList.Items174"),
            resources.GetString("cmbBarangayList.Items175"),
            resources.GetString("cmbBarangayList.Items176"),
            resources.GetString("cmbBarangayList.Items177"),
            resources.GetString("cmbBarangayList.Items178"),
            resources.GetString("cmbBarangayList.Items179"),
            resources.GetString("cmbBarangayList.Items180")});
            resources.ApplyResources(this.cmbBarangayList, "cmbBarangayList");
            this.cmbBarangayList.Name = "cmbBarangayList";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtStreetAddress
            // 
            resources.ApplyResources(this.txtStreetAddress, "txtStreetAddress");
            this.txtStreetAddress.Name = "txtStreetAddress";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtOrderList);
            this.panel1.Controls.Add(this.lblOrderTitle);
            this.panel1.Controls.Add(this.lblOrderId);
            this.panel1.Controls.Add(this.lblAccNo);
            this.panel1.Controls.Add(this.txtAccNo);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSaveDeliveryInfo);
            this.panel1.Controls.Add(this.cmbPaymentMethodList);
            this.panel1.Controls.Add(this.cmbBarangayList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStreetAddress);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtOrderList
            // 
            this.txtOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtOrderList, "txtOrderList");
            this.txtOrderList.Name = "txtOrderList";
            // 
            // lblOrderTitle
            // 
            resources.ApplyResources(this.lblOrderTitle, "lblOrderTitle");
            this.lblOrderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTitle.Name = "lblOrderTitle";
            // 
            // lblOrderId
            // 
            resources.ApplyResources(this.lblOrderId, "lblOrderId");
            this.lblOrderId.Name = "lblOrderId";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodApp.Properties.Resources.only_milktea_v2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // FrmEditCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FrmEditCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveDeliveryInfo;
        private System.Windows.Forms.ComboBox cmbPaymentMethodList;
        private System.Windows.Forms.ComboBox cmbBarangayList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.TextBox txtOrderList;
    }
}