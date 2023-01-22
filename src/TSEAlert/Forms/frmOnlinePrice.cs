using System.Collections.Generic;
using TSEAlert.Handler;
using TSEAlert.Forms;
using System;

namespace StockExchangeAlert.Forms
{
    public partial class frmOnlinePrice : frmBaseForm
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public frmOnlinePrice()
        {
            InitializeComponent();
        }

        private void frmOnlinePrice_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                BindingToDgv();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                this.Close();
            }
        }

        private void btnFetchOnlinePrice_Click(object sender, EventArgs e)
        {
            try
            {
                BindingToDgv();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Get online price fail.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindingToDgv()
        {
            try
            {
                var alerts = new AlertHandler().Get();

                List<OnlinePriceBindingObject> bindingObjects = new List<OnlinePriceBindingObject>();
                using (frmLoading loading = new frmLoading(delegate () { bindingObjects = GenerateList(alerts); }))
                    loading.ShowDialog(this);

                dgvStocks.DataSource = bindingObjects;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<OnlinePriceBindingObject> GenerateList(List<TSEAlert.Models.Alert> alerts)
        {
            
            try
            {
                List<OnlinePriceBindingObject> bindingObjects = new List<OnlinePriceBindingObject>();
                foreach (var item in alerts)
                {
                    OnlinePriceBindingObject bo = new OnlinePriceBindingObject()
                    {
                        StockName = item.Symbol,
                        AlertPrice = item.Price,
                        CurrentPrice = new StockTransactionInformation(item.TseCode).GetLastTransactionPrice().ToString()
                    };
                    bindingObjects.Add(bo);
                }
                return bindingObjects;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    internal class OnlinePriceBindingObject
    {
        public string StockName { get; set; }
        public string CurrentPrice { get; set; }
        public string AlertPrice { get; set; }
    }
}
