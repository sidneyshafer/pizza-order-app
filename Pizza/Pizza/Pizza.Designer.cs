namespace Pizza
{
    partial class frmPizza
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
            this.lblMaxAmount = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkGreenOlives = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblToppingsPrice = new System.Windows.Forms.Label();
            this.lblSubtotalPrice = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.grpPayment.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.AutoSize = true;
            this.lblMaxAmount.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxAmount.Location = new System.Drawing.Point(155, 208);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(67, 19);
            this.lblMaxAmount.TabIndex = 12;
            this.lblMaxAmount.Text = "Max (10)";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbQuantity.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuantity.Location = new System.Drawing.Point(99, 205);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(47, 27);
            this.cmbQuantity.TabIndex = 11;
            this.cmbQuantity.Text = "0";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMushrooms.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMushrooms.Location = new System.Drawing.Point(151, 130);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(108, 23);
            this.chkMushrooms.TabIndex = 8;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHamburger.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHamburger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkHamburger.Location = new System.Drawing.Point(151, 159);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(107, 23);
            this.chkHamburger.TabIndex = 9;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnion.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOnion.Location = new System.Drawing.Point(151, 72);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(71, 23);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPineapple.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPineapple.Location = new System.Drawing.Point(151, 43);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(97, 23);
            this.chkPineapple.TabIndex = 5;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHam.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkHam.Location = new System.Drawing.Point(151, 101);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(63, 23);
            this.chkHam.TabIndex = 7;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkGreenOlives
            // 
            this.chkGreenOlives.AutoSize = true;
            this.chkGreenOlives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGreenOlives.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenOlives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkGreenOlives.Location = new System.Drawing.Point(16, 130);
            this.chkGreenOlives.Name = "chkGreenOlives";
            this.chkGreenOlives.Size = new System.Drawing.Size(114, 23);
            this.chkGreenOlives.TabIndex = 3;
            this.chkGreenOlives.Text = "Green Olives";
            this.chkGreenOlives.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(12, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 19);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTax.Location = new System.Drawing.Point(12, 145);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(35, 19);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubtotal.Location = new System.Drawing.Point(12, 108);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 19);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToppings.Location = new System.Drawing.Point(12, 71);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(74, 19);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantity.Location = new System.Drawing.Point(20, 208);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 19);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.cmbPayment);
            this.grpPayment.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpPayment.Location = new System.Drawing.Point(774, 290);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(251, 81);
            this.grpPayment.TabIndex = 2;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment";
            // 
            // cmbPayment
            // 
            this.cmbPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPayment.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Visa",
            "Mastercard",
            "American Express"});
            this.cmbPayment.Location = new System.Drawing.Point(16, 37);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(208, 27);
            this.cmbPayment.TabIndex = 0;
            this.cmbPayment.Text = "Cash";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizza.Location = new System.Drawing.Point(12, 35);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(46, 19);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizza:";
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBlackOlives.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBlackOlives.Location = new System.Drawing.Point(16, 159);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(110, 23);
            this.chkBlackOlives.TabIndex = 4;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // grpPricing
            // 
            this.grpPricing.Controls.Add(this.lblTotalAmount);
            this.grpPricing.Controls.Add(this.lblTaxAmount);
            this.grpPricing.Controls.Add(this.lblSubtotalPrice);
            this.grpPricing.Controls.Add(this.lblToppingsPrice);
            this.grpPricing.Controls.Add(this.lblPrice);
            this.grpPricing.Controls.Add(this.lblTotal);
            this.grpPricing.Controls.Add(this.lblTax);
            this.grpPricing.Controls.Add(this.lblSubtotal);
            this.grpPricing.Controls.Add(this.lblToppings);
            this.grpPricing.Controls.Add(this.lblPizza);
            this.grpPricing.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPricing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpPricing.Location = new System.Drawing.Point(774, 398);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(251, 225);
            this.grpPricing.TabIndex = 3;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "Pricing";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(324, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 39);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnClose);
            this.grpActions.Controls.Add(this.btnReset);
            this.grpActions.Controls.Add(this.btnAccept);
            this.grpActions.Controls.Add(this.btnPrice);
            this.grpActions.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpActions.Location = new System.Drawing.Point(423, 641);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(602, 88);
            this.grpActions.TabIndex = 4;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(473, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(170, 30);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(102, 39);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrice.ForeColor = System.Drawing.Color.White;
            this.btnPrice.Location = new System.Drawing.Point(24, 30);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(102, 39);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.lblDate.Location = new System.Drawing.Point(33, 676);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.cmbState);
            this.grpCustomerInfo.Controls.Add(this.mtbZip);
            this.grpCustomerInfo.Controls.Add(this.lblZipcode);
            this.grpCustomerInfo.Controls.Add(this.lblState);
            this.grpCustomerInfo.Controls.Add(this.txtCity);
            this.grpCustomerInfo.Controls.Add(this.lblCity);
            this.grpCustomerInfo.Controls.Add(this.txtAddr2);
            this.grpCustomerInfo.Controls.Add(this.lblAddress2);
            this.grpCustomerInfo.Controls.Add(this.txtAddr1);
            this.grpCustomerInfo.Controls.Add(this.lblAddress1);
            this.grpCustomerInfo.Controls.Add(this.txtName);
            this.grpCustomerInfo.Controls.Add(this.mtbPhone);
            this.grpCustomerInfo.Controls.Add(this.lblName);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpCustomerInfo.Location = new System.Drawing.Point(50, 106);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(349, 376);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";
            // 
            // cmbState
            // 
            this.cmbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbState.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(103, 277);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(108, 27);
            this.cmbState.TabIndex = 11;
            this.cmbState.Text = "MN";
            // 
            // mtbZip
            // 
            this.mtbZip.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbZip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtbZip.Location = new System.Drawing.Point(103, 324);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(108, 27);
            this.mtbZip.TabIndex = 13;
            this.mtbZip.Leave += new System.EventHandler(this.mtxtZipcode_Leave);
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZipcode.Location = new System.Drawing.Point(15, 327);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(67, 19);
            this.lblZipcode.TabIndex = 12;
            this.lblZipcode.Text = "Zipcode:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblState.Location = new System.Drawing.Point(15, 280);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 19);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCity.Location = new System.Drawing.Point(103, 229);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(168, 27);
            this.txtCity.TabIndex = 9;
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCity.Location = new System.Drawing.Point(15, 232);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 19);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddr2.Location = new System.Drawing.Point(103, 181);
            this.txtAddr2.MaxLength = 25;
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(225, 27);
            this.txtAddr2.TabIndex = 7;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress2.Location = new System.Drawing.Point(15, 184);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(73, 19);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address2:";
            // 
            // txtAddr1
            // 
            this.txtAddr1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddr1.Location = new System.Drawing.Point(103, 132);
            this.txtAddr1.MaxLength = 25;
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(225, 27);
            this.txtAddr1.TabIndex = 5;
            this.txtAddr1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress1.Location = new System.Drawing.Point(15, 135);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(73, 19);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address1:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(103, 86);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 27);
            this.txtName.TabIndex = 3;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtbPhone.Location = new System.Drawing.Point(103, 42);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.ShortcutsEnabled = false;
            this.mtbPhone.Size = new System.Drawing.Size(108, 27);
            this.mtbPhone.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(15, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhone.Location = new System.Drawing.Point(15, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 19);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPepperoni.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPepperoni.Location = new System.Drawing.Point(16, 101);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(99, 23);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(42, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 45);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Pizza Planet";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.grpSize);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumber);
            this.grpOrderInfo.Controls.Add(this.grpToppings);
            this.grpOrderInfo.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpOrderInfo.Location = new System.Drawing.Point(423, 106);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(326, 517);
            this.grpOrderInfo.TabIndex = 1;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoLarge);
            this.grpSize.Controls.Add(this.rdoMedium);
            this.grpSize.Controls.Add(this.rdoSmall);
            this.grpSize.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpSize.Location = new System.Drawing.Point(24, 74);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(277, 141);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLarge.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLarge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoLarge.Location = new System.Drawing.Point(27, 104);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(67, 23);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMedium.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedium.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoMedium.Location = new System.Drawing.Point(27, 64);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(85, 23);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSmall.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoSmall.Location = new System.Drawing.Point(29, 26);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(67, 23);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrderNumber.Location = new System.Drawing.Point(20, 42);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(115, 19);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.lblMaxAmount);
            this.grpToppings.Controls.Add(this.cmbQuantity);
            this.grpToppings.Controls.Add(this.lblQuantity);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkHamburger);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkBlackOlives);
            this.grpToppings.Controls.Add(this.chkGreenOlives);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.grpToppings.Location = new System.Drawing.Point(24, 232);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(277, 251);
            this.grpToppings.TabIndex = 2;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSausage.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSausage.Location = new System.Drawing.Point(16, 72);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(86, 23);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCheese.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCheese.Location = new System.Drawing.Point(16, 43);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(78, 23);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // lblUnderline
            // 
            this.lblUnderline.AutoSize = true;
            this.lblUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline.Location = new System.Drawing.Point(42, 47);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(254, 46);
            this.lblUnderline.TabIndex = 23;
            this.lblUnderline.Text = "------------------";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(33, 710);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(277, 19);
            this.lblPublisher.TabIndex = 21;
            this.lblPublisher.Text = "Application Developed by Sidney Shafer";
            // 
            // picPizza
            // 
            this.picPizza.Image = global::Pizza.Properties.Resources.PizzaPlanet;
            this.picPizza.Location = new System.Drawing.Point(774, 47);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(251, 213);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPizza.TabIndex = 25;
            this.picPizza.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(118, 35);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(17, 19);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "$";
            // 
            // lblToppingsPrice
            // 
            this.lblToppingsPrice.AutoSize = true;
            this.lblToppingsPrice.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToppingsPrice.Location = new System.Drawing.Point(118, 71);
            this.lblToppingsPrice.Name = "lblToppingsPrice";
            this.lblToppingsPrice.Size = new System.Drawing.Size(17, 19);
            this.lblToppingsPrice.TabIndex = 6;
            this.lblToppingsPrice.Text = "$";
            // 
            // lblSubtotalPrice
            // 
            this.lblSubtotalPrice.AutoSize = true;
            this.lblSubtotalPrice.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubtotalPrice.Location = new System.Drawing.Point(118, 108);
            this.lblSubtotalPrice.Name = "lblSubtotalPrice";
            this.lblSubtotalPrice.Size = new System.Drawing.Size(17, 19);
            this.lblSubtotalPrice.TabIndex = 7;
            this.lblSubtotalPrice.Text = "$";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaxAmount.Location = new System.Drawing.Point(118, 145);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTaxAmount.TabIndex = 8;
            this.lblTaxAmount.Text = "$";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalAmount.Location = new System.Drawing.Point(118, 185);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(18, 19);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "$";
            // 
            // frmPizza
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1076, 757);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpPricing);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.lblUnderline);
            this.Controls.Add(this.lblPublisher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Planet Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPizza_FormClosing);
            this.Load += new System.EventHandler(this.frmPizza_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxAmount;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkGreenOlives;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.GroupBox grpPricing;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblToppingsPrice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblSubtotalPrice;
    }
}

