
namespace FoodApp
{
    partial class FrmDeliveryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOrderList = new System.Windows.Forms.Label();
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.txtOrderList);
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
            this.panel1.Location = new System.Drawing.Point(-8, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 483);
            this.panel1.TabIndex = 1;
            // 
            // txtOrderList
            // 
            this.txtOrderList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOrderList.Location = new System.Drawing.Point(30, 420);
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.Size = new System.Drawing.Size(140, 44);
            this.txtOrderList.TabIndex = 20;
            this.txtOrderList.Text = "OrderList";
            this.txtOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOrderList.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(368, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(157, 321);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(349, 27);
            this.txtContactNo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contact Number: ";
            // 
            // btnSaveDeliveryInfo
            // 
            this.btnSaveDeliveryInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDeliveryInfo.Location = new System.Drawing.Point(209, 428);
            this.btnSaveDeliveryInfo.Name = "btnSaveDeliveryInfo";
            this.btnSaveDeliveryInfo.Size = new System.Drawing.Size(94, 29);
            this.btnSaveDeliveryInfo.TabIndex = 16;
            this.btnSaveDeliveryInfo.Text = "Save";
            this.btnSaveDeliveryInfo.UseVisualStyleBackColor = true;
            this.btnSaveDeliveryInfo.Click += new System.EventHandler(this.btnSaveDeliveryInfo_Click);
            // 
            // cmbPaymentMethodList
            // 
            this.cmbPaymentMethodList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPaymentMethodList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethodList.FormattingEnabled = true;
            this.cmbPaymentMethodList.Items.AddRange(new object[] {
            "None",
            "GCASH",
            "CASH ON DELIVERY",
            "CREDIT CARD"});
            this.cmbPaymentMethodList.Location = new System.Drawing.Point(156, 384);
            this.cmbPaymentMethodList.Name = "cmbPaymentMethodList";
            this.cmbPaymentMethodList.Size = new System.Drawing.Size(349, 28);
            this.cmbPaymentMethodList.TabIndex = 15;
            // 
            // cmbBarangayList
            // 
            this.cmbBarangayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarangayList.FormattingEnabled = true;
            this.cmbBarangayList.Items.AddRange(new object[] {
            "Agdao",
            "Alambre",
            "Alejandra Navarro (Lasang)",
            "Alfonso Angliongto Sr.",
            "Angalan",
            "Atan-Awe",
            "Baganihan",
            "Bago Aplaya",
            "Bago Gallera",
            "Bago Oshiro",
            "Baguio",
            "Balengaeng",
            "Baliok",
            "Bangkas Heights",
            "Bantol",
            "Baracatan",
            "Barangay 10-A",
            "Barangay 11-B",
            "Barangay 12-B",
            "Barangay 13-B",
            "Barangay 14-B",
            "Barangay 15-B",
            "Barangay 16-B",
            "Barangay 17-B",
            "Barangay 18-B",
            "Barangay 19-B",
            "Barangay 1-A",
            "Barangay 20-B",
            "Barangay 21-C",
            "Barangay 22-C",
            "Barangay 23-C",
            "Barangay 24-C",
            "Barangay 25-C",
            "Barangay 26-C",
            "Barangay 27-C",
            "Barangay 28-C",
            "Barangay 29-C",
            "Barangay 2-A",
            "Barangay 30-C",
            "Barangay 31-D",
            "Barangay 32-D",
            "Barangay 33-D",
            "Barangay 34-D",
            "Barangay 35-D",
            "Barangay 36-D",
            "Barangay 37-D",
            "Barangay 38-D",
            "Barangay 39-D",
            "Barangay 3-A",
            "Barangay 40-D",
            "Barangay 4-A",
            "Barangay 5-A",
            "Barangay 6-A",
            "Barangay 7-A",
            "Barangay 8-A",
            "Barangay 9-A",
            "Bato",
            "Bayabas",
            "Biao Escuela",
            "Biao Guianga",
            "Biao Joaquin",
            "Binugao",
            "Bucana",
            "Buda",
            "Buhangin",
            "Bunawan",
            "Cabantian",
            "Cadalian",
            "Calinan",
            "Callawa",
            "Camansi",
            "Carmen",
            "Catalunan Grande",
            "Catalunan Pequeño",
            "Catigan",
            "Cawayan",
            "Centro (San Juan)",
            "Colosas",
            "Communal",
            "Crossing Bayabas",
            "Dacudao",
            "Dalag",
            "Dalagdag",
            "Daliao",
            "Daliaon Plantation",
            "Datu Salumay",
            "Dominga",
            "Dumoy",
            "Eden",
            "Fatima (Benowang)",
            "Gatungan",
            "Gov. Paciano Bangoy",
            "Gov. Vicente Duterte",
            "Gumalang",
            "Gumitan",
            "Ilang",
            "Inayangan",
            "Indangan",
            "Kap. Tomas Monteverde Sr.",
            "Kilate",
            "Lacson",
            "Lamanan",
            "Lampianao",
            "Langub",
            "Lapu-lapu",
            "Leon Garcia Sr.",
            "Lizada",
            "Los Amigos",
            "Lubogan",
            "Lumiad",
            "Ma-a",
            "Mabuhay",
            "Magsaysay",
            "Magtuod",
            "Mahayag",
            "Malabog",
            "Malagos",
            "Malamba",
            "Manambulan",
            "Mandug",
            "Manuel Guianga",
            "Mapula",
            "Marapangi",
            "Marilog",
            "Matina Aplaya",
            "Matina Biao",
            "Matina Crossing",
            "Matina Pangi",
            "Megkawayan",
            "Mintal",
            "Mudiang",
            "Mulig",
            "New Carmen",
            "New Valencia",
            "Pampanga",
            "Panacan",
            "Panalum",
            "Pandaitan",
            "Pangyan",
            "Paquibato",
            "Paradise Embak",
            "Rafael Castillo",
            "Riverside",
            "Salapawan",
            "Salaysay",
            "Saloy",
            "San Antonio",
            "San Isidro (Licanan)",
            "Santo Niño",
            "Sasa",
            "Sibulan",
            "Sirawan",
            "Sirib",
            "Suawan (Tuli)",
            "Subasta",
            "Sumimao",
            "Tacunan",
            "Tagakpan",
            "Tagluno",
            "Tagurano",
            "Talandang",
            "Talomo",
            "Talomo River",
            "Tamayong",
            "Tambobong",
            "Tamugan",
            "Tapak",
            "Tawan-Tawan",
            "Tibuloy",
            "Tibungco",
            "Tigatto",
            "Toril",
            "Tugbok",
            "Tungakalan",
            "Ubalde",
            "Ula",
            "Vicente Hizon Sr.",
            "Waan",
            "Wangan",
            "Wilfredo Aquino",
            "Wines"});
            this.cmbBarangayList.Location = new System.Drawing.Point(157, 206);
            this.cmbBarangayList.Name = "cmbBarangayList";
            this.cmbBarangayList.Size = new System.Drawing.Size(349, 28);
            this.cmbBarangayList.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "Payment Method:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baranggay: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Street Address: ";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(157, 245);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(349, 50);
            this.txtStreetAddress.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 160);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(349, 27);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 122);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(349, 27);
            this.txtFirstName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // FrmDeliveryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 475);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDeliveryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Information";
            this.Load += new System.EventHandler(this.FrmDeliveryInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveDeliveryInfo;
        private System.Windows.Forms.ComboBox cmbPaymentMethodList;
        private System.Windows.Forms.ComboBox cmbBarangayList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtOrderList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}