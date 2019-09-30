using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhager1C1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //start with small changes and test along the way, easier to debug and pinpoint mistakes.   
            //99m converts from string to decimal.


            txtHotDogsSubtotal.Text = (
                    4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");

            //copy and paste and change names to match hamburgers and change values 4 becomes 5.

            txtHamburgersSubtotal.Text = (
                   5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");

            txtPretaxTotal.Text = (
               Convert.ToDecimal(txtHotDogsSubtotal.Text)
               + Convert.ToDecimal(txtHamburgersSubtotal.Text)
               ).ToString("0.00");
            //sales tax = .06875

            txtTax.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) * 0.06875m
                ).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }
    }
}
