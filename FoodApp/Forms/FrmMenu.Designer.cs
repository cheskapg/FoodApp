
namespace FoodApp
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.l = new System.Windows.Forms.Label();
            this.btnMilkteactg = new System.Windows.Forms.Button();
            this.ctgMilkteaIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPizzactg = new System.Windows.Forms.Button();
            this.ctgPizzaIcon = new System.Windows.Forms.PictureBox();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.cmbQuantityMexican = new System.Windows.Forms.ComboBox();
            this.cmbQuantityHam = new System.Windows.Forms.ComboBox();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMargherita = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGehalo = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMexicano = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHamNCheese = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.cmbQuantityGehalo = new System.Windows.Forms.ComboBox();
            this.cmbQuantityMargherita = new System.Windows.Forms.ComboBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctgMilkteaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctgPizzaIcon)).BeginInit();
            this.pnlPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlMenu.Controls.Add(this.l);
            this.pnlMenu.Controls.Add(this.btnMilkteactg);
            this.pnlMenu.Controls.Add(this.ctgMilkteaIcon);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnPizzactg);
            this.pnlMenu.Controls.Add(this.ctgPizzaIcon);
            this.pnlMenu.Location = new System.Drawing.Point(-1, -1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(633, 522);
            this.pnlMenu.TabIndex = 1;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(219, 175);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(58, 20);
            this.l.TabIndex = 5;
            this.l.Text = "Milktea";
            // 
            // btnMilkteactg
            // 
            this.btnMilkteactg.Location = new System.Drawing.Point(201, 205);
            this.btnMilkteactg.Name = "btnMilkteactg";
            this.btnMilkteactg.Size = new System.Drawing.Size(94, 29);
            this.btnMilkteactg.TabIndex = 4;
            this.btnMilkteactg.Text = "Choose";
            this.btnMilkteactg.UseVisualStyleBackColor = true;
            // 
            // ctgMilkteaIcon
            // 
            this.ctgMilkteaIcon.Image = ((System.Drawing.Image)(resources.GetObject("ctgMilkteaIcon.Image")));
            this.ctgMilkteaIcon.Location = new System.Drawing.Point(196, 63);
            this.ctgMilkteaIcon.Name = "ctgMilkteaIcon";
            this.ctgMilkteaIcon.Size = new System.Drawing.Size(103, 105);
            this.ctgMilkteaIcon.TabIndex = 3;
            this.ctgMilkteaIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza";
            // 
            // btnPizzactg
            // 
            this.btnPizzactg.Location = new System.Drawing.Point(32, 205);
            this.btnPizzactg.Name = "btnPizzactg";
            this.btnPizzactg.Size = new System.Drawing.Size(94, 29);
            this.btnPizzactg.TabIndex = 1;
            this.btnPizzactg.Text = "Choose";
            this.btnPizzactg.UseVisualStyleBackColor = true;
            this.btnPizzactg.Click += new System.EventHandler(this.btnPizzactg_Click);
            // 
            // ctgPizzaIcon
            // 
            this.ctgPizzaIcon.Image = ((System.Drawing.Image)(resources.GetObject("ctgPizzaIcon.Image")));
            this.ctgPizzaIcon.Location = new System.Drawing.Point(27, 63);
            this.ctgPizzaIcon.Name = "ctgPizzaIcon";
            this.ctgPizzaIcon.Size = new System.Drawing.Size(103, 105);
            this.ctgPizzaIcon.TabIndex = 0;
            this.ctgPizzaIcon.TabStop = false;
            // 
            // pnlPizza
            // 
            this.pnlPizza.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlPizza.Controls.Add(this.cmbQuantityMargherita);
            this.pnlPizza.Controls.Add(this.cmbQuantityGehalo);
            this.pnlPizza.Controls.Add(this.btnCancelOrder);
            this.pnlPizza.Controls.Add(this.btnPlaceOrder);
            this.pnlPizza.Controls.Add(this.label10);
            this.pnlPizza.Controls.Add(this.cmbOrderID);
            this.pnlPizza.Controls.Add(this.cmbQuantityMexican);
            this.pnlPizza.Controls.Add(this.cmbQuantityHam);
            this.pnlPizza.Controls.Add(this.btnBacktoMenu);
            this.pnlPizza.Controls.Add(this.label8);
            this.pnlPizza.Controls.Add(this.btnMargherita);
            this.pnlPizza.Controls.Add(this.pictureBox5);
            this.pnlPizza.Controls.Add(this.label9);
            this.pnlPizza.Controls.Add(this.btnGehalo);
            this.pnlPizza.Controls.Add(this.pictureBox6);
            this.pnlPizza.Controls.Add(this.label6);
            this.pnlPizza.Controls.Add(this.label5);
            this.pnlPizza.Controls.Add(this.label2);
            this.pnlPizza.Controls.Add(this.btnMexicano);
            this.pnlPizza.Controls.Add(this.pictureBox1);
            this.pnlPizza.Controls.Add(this.label3);
            this.pnlPizza.Controls.Add(this.btnHamNCheese);
            this.pnlPizza.Controls.Add(this.pictureBox2);
            this.pnlPizza.Location = new System.Drawing.Point(0, 0);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(612, 516);
            this.pnlPizza.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Customer List ";
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(128, 414);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(363, 28);
            this.cmbOrderID.TabIndex = 23;
            this.cmbOrderID.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbOrderFormat);
            // 
            // cmbQuantityMexican
            // 
            this.cmbQuantityMexican.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantityMexican.FormattingEnabled = true;
            this.cmbQuantityMexican.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbQuantityMexican.Location = new System.Drawing.Point(490, 114);
            this.cmbQuantityMexican.Name = "cmbQuantityMexican";
            this.cmbQuantityMexican.Size = new System.Drawing.Size(85, 28);
            this.cmbQuantityMexican.TabIndex = 22;
            // 
            // cmbQuantityHam
            // 
            this.cmbQuantityHam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantityHam.FormattingEnabled = true;
            this.cmbQuantityHam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbQuantityHam.Location = new System.Drawing.Point(233, 114);
            this.cmbQuantityHam.Name = "cmbQuantityHam";
            this.cmbQuantityHam.Size = new System.Drawing.Size(85, 28);
            this.cmbQuantityHam.TabIndex = 21;
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBacktoMenu.Location = new System.Drawing.Point(490, 459);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(108, 39);
            this.btnBacktoMenu.TabIndex = 20;
            this.btnBacktoMenu.Text = "Back to Menu";
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.btnBacktoMenu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pizza Margherita";
            // 
            // btnMargherita
            // 
            this.btnMargherita.Location = new System.Drawing.Point(368, 379);
            this.btnMargherita.Name = "btnMargherita";
            this.btnMargherita.Size = new System.Drawing.Size(94, 29);
            this.btnMargherita.TabIndex = 15;
            this.btnMargherita.Text = "Add to Cart";
            this.btnMargherita.UseVisualStyleBackColor = true;
            this.btnMargherita.Click += new System.EventHandler(this.btnMargherita_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(365, 248);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 105);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Pizza Gehalo";
            // 
            // btnGehalo
            // 
            this.btnGehalo.Location = new System.Drawing.Point(102, 379);
            this.btnGehalo.Name = "btnGehalo";
            this.btnGehalo.Size = new System.Drawing.Size(94, 29);
            this.btnGehalo.TabIndex = 12;
            this.btnGehalo.Text = "Add to Cart";
            this.btnGehalo.UseVisualStyleBackColor = true;
            this.btnGehalo.Click += new System.EventHandler(this.btnGehalo_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(98, 248);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 105);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(222, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "16 inches - 12 slices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Family Standard Size Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(363, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pizza Mexicano";
            // 
            // btnMexicano
            // 
            this.btnMexicano.Location = new System.Drawing.Point(372, 209);
            this.btnMexicano.Name = "btnMexicano";
            this.btnMexicano.Size = new System.Drawing.Size(94, 29);
            this.btnMexicano.TabIndex = 4;
            this.btnMexicano.Text = "Add to Cart";
            this.btnMexicano.UseVisualStyleBackColor = true;
            this.btnMexicano.Click += new System.EventHandler(this.btnMexicano_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 105);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pizza Ham el Queso";
            // 
            // btnHamNCheese
            // 
            this.btnHamNCheese.Location = new System.Drawing.Point(101, 204);
            this.btnHamNCheese.Name = "btnHamNCheese";
            this.btnHamNCheese.Size = new System.Drawing.Size(94, 29);
            this.btnHamNCheese.TabIndex = 1;
            this.btnHamNCheese.Text = "Add to Cart";
            this.btnHamNCheese.UseVisualStyleBackColor = true;
            this.btnHamNCheese.Click += new System.EventHandler(this.btnHamNCheese_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 105);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(253, 454);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(109, 49);
            this.btnPlaceOrder.TabIndex = 25;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelOrder.Location = new System.Drawing.Point(12, 454);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(113, 49);
            this.btnCancelOrder.TabIndex = 26;
            this.btnCancelOrder.Text = "Clear Cart";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // cmbQuantityGehalo
            // 
            this.cmbQuantityGehalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantityGehalo.FormattingEnabled = true;
            this.cmbQuantityGehalo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbQuantityGehalo.Location = new System.Drawing.Point(233, 296);
            this.cmbQuantityGehalo.Name = "cmbQuantityGehalo";
            this.cmbQuantityGehalo.Size = new System.Drawing.Size(85, 28);
            this.cmbQuantityGehalo.TabIndex = 27;
            // 
            // cmbQuantityMargherita
            // 
            this.cmbQuantityMargherita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantityMargherita.FormattingEnabled = true;
            this.cmbQuantityMargherita.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbQuantityMargherita.Location = new System.Drawing.Point(490, 296);
            this.cmbQuantityMargherita.Name = "cmbQuantityMargherita";
            this.cmbQuantityMargherita.Size = new System.Drawing.Size(85, 28);
            this.cmbQuantityMargherita.TabIndex = 28;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 520);
            this.Controls.Add(this.pnlPizza);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctgMilkteaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctgPizzaIcon)).EndInit();
            this.pnlPizza.ResumeLayout(false);
            this.pnlPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox ctgPizzaIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPizzactg;
        private System.Windows.Forms.PictureBox ctgMilkteaIcon;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnMilkteactg;
        private System.Windows.Forms.Panel pnlPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMexicano;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHamNCheese;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMargherita;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGehalo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBacktoMenu;
        private System.Windows.Forms.ComboBox cmbQuantityHam;
        private System.Windows.Forms.ComboBox cmbQuantityMexican;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ComboBox cmbQuantityMargherita;
        private System.Windows.Forms.ComboBox cmbQuantityGehalo;
    }
}