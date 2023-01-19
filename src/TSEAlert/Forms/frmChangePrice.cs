using System.Windows.Forms;
using System;

namespace TSEAlert.Forms
{
    public partial class frmChangePrice : Form
    {
        private int price { get; set; }
        public int Price 
        {
            get
            {
                return price;
            }
        }

        public frmChangePrice()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == string.Empty || txtPrice.Text.Length == 0)
                txtPrice.Text = "0";
            this.price = Convert.ToInt32(txtPrice.Text);
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
