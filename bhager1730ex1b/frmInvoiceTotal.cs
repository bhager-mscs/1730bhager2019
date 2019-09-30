using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhager1730ex1b
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Text =    
                (Convert.ToDecimal(txtSubtotal.Text)    
                * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");

            txtTotal.Text = 
                (Convert.ToDecimal(txtSubtotal.Text)    
                - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
