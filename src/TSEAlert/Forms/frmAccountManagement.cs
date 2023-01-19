using System;

namespace StockExchangeAlert.Forms
{
    public partial class frmAccountManagement : frmBaseForm
    {
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
