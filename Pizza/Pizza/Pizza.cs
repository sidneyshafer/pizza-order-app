using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza
{
    public partial class frmPizza : Form
    {
        Single sngPizzaPrice = 0.0f;
        Single sngToppingsPrice = 0.0f;
        Single sngPrice = 0.0f;
        Single sngTaxRate = 0.07f;
        bool blnPhone = false;

        public frmPizza()
        {
            InitializeComponent();

            Random random = new Random();
            int num = random.Next(1000);
            lblOrderNumber.Text = "Order Number: " + num;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = dateTime.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void Reset()
        {
            mtbPhone.Clear();
            txtName.Clear();
            txtAddr1.Clear();
            txtAddr2.Clear();
            txtCity.Clear();
            cmbState.Text = "MN";
            mtbZip.Clear();

            rdoSmall.Checked = false;
            rdoMedium.Checked = false;
            rdoLarge.Checked = false;

            chkBlackOlives.Checked = false;
            chkCheese.Checked = true;
            chkGreenOlives.Checked = false;
            chkHam.Checked = false;
            chkHamburger.Checked = false;
            chkMushrooms.Checked = false;
            chkOnion.Checked = false;
            chkPepperoni.Checked = false;
            chkPineapple.Checked = false;
            chkSausage.Checked = false;

            cmbQuantity.SelectedIndex = 1;

            cmbPayment.SelectedIndex = 0;

            lblPrice.Text = "$";
            lblToppingsPrice.Text = "$";
            lblSubtotalPrice.Text = "$";
            lblTaxAmount.Text = "$";
            lblTotalAmount.Text = "$";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void GetPrice()
        {
            // Deterime pizza size and base price
            if (rdoSmall.Checked == true)
            { sngPizzaPrice = 5.0f; }
            else if (rdoMedium.Checked == true)
            { sngPizzaPrice = 10.0f; }
            else
            { sngPizzaPrice = 15.0f; }

            // Deterime toppings
            if (chkBlackOlives.Checked) { sngToppingsPrice += 0.5f; }
            if (chkCheese.Checked) { sngToppingsPrice += 1.0f; }
            if (chkGreenOlives.Checked) { sngToppingsPrice += 0.5f; }
            if (chkHam.Checked) { sngToppingsPrice += 1.75f; }
            if (chkHamburger.Checked) { sngToppingsPrice += 1.75f; }
            if (chkMushrooms.Checked) { sngToppingsPrice += 1.5f; }
            if (chkOnion.Checked) { sngToppingsPrice += 0.5f; }
            if (chkPepperoni.Checked) { sngToppingsPrice += 1.5f; }
            if (chkPineapple.Checked) { sngToppingsPrice += 1.0f; }
            if (chkSausage.Checked) { sngToppingsPrice += 1.75f; }

            sngPrice = sngPizzaPrice + sngToppingsPrice;
            sngPrice *= Convert.ToSingle(cmbQuantity.SelectedItem);

            Single sngTax;
            sngTax = sngPrice * sngTaxRate;
            Single sngTotal = sngPrice + sngTax;

            lblPrice.Text = sngPizzaPrice.ToString("c");
            lblToppingsPrice.Text = sngToppingsPrice.ToString("c");
            lblSubtotalPrice.Text = sngPrice.ToString("c");
            lblTaxAmount.Text = sngTax.ToString("c");
            lblTotalAmount.Text = sngTotal.ToString("c");

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            GetPrice();
        }

        private void frmPizza_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult digResult;
            digResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (digResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPizza_Load(object sender, EventArgs e)
        {
            // rdoSmall.Checked = true;
            timer1.Start();
            string strFilePath = Application.StartupPath + "/../../States.txt";
            string strState;

            try
            {
                FileStream fsState = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
                StreamReader srStates = new StreamReader(fsState);

                while (!srStates.EndOfStream)
                {
                    strState = srStates.ReadLine();
                    cmbState.Items.Add(strState);
                }
            }
            catch
            {
                MessageBox.Show("Error Reading States File!");
            }

            cmbState.SelectedItem = "MN";
            cmbPayment.SelectedIndex = 0;
            cmbQuantity.SelectedIndex = 1;
            chkCheese.Checked = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 3) 
            { 
                txtName.ForeColor = Color.Black;
            }
            else 
            { 
                txtName.ForeColor = Color.Red;
                txtName.BackColor = Color.Silver;
            }
        }

        private void txtAddress1_Leave(object sender, EventArgs e)
        {
            if (txtAddr1.Text.Length >= 5)
            {
                txtAddr1.ForeColor = Color.Black;
            }
            else
            {
                txtAddr1.ForeColor = Color.Red;
                txtAddr1.BackColor = Color.Silver;
            }
        }

        private void mtxtZipcode_Leave(object sender, EventArgs e)
        {
            if (mtbZip.Text.Length == 5 || mtbZip.Text.Length == 10)
            {
                mtbZip.ForeColor = Color.Black;
            }
            else
            {
                mtbZip.ForeColor = Color.Red;
                mtbZip.BackColor = Color.Silver;
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Length >= 5)
            {
                txtCity.ForeColor = Color.Black;
            }
            else
            {
                txtCity.ForeColor = Color.Red;
                txtCity.BackColor = Color.Silver;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Customer customer;
            customer = new Customer(mtbPhone.Text, txtName.Text, txtAddr1.Text, txtAddr2.Text,
                txtCity.Text, cmbState.Text, mtbZip.Text);

            string customerInfo = customer.Display();

            MessageBox.Show(customerInfo, "Customer Information", MessageBoxButtons.OK);

            string filePath = Application.StartupPath + "/../../PizzaLog.txt";

            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(customerInfo);
            }
        }
    }
}
