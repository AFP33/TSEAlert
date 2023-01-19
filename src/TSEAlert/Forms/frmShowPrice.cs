using System.Windows.Forms;
using System;

namespace TSEAlert.Forms
{
    public partial class frmShowPrice : Form
    {
        private int Price { get; }
        public frmShowPrice(int price)
        {
            InitializeComponent();
            Price = price;
        }

        private void frmShowPrice_Load(object sender, EventArgs e)
        {
            txtPrice.Text = Price.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
