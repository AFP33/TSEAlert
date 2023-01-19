using TSEAlert.Handler;
using System.Data;
using System.Linq;
using System;

namespace StockExchangeAlert.Forms
{
    public partial class frmConfiguration : frmBaseForm
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                cbChangeServiceStatus.Checked = (bool)TSEAlert.Properties.Settings.Default["MainService"];
                cbChangeMarketInfoServiceStatus.Checked = (bool)TSEAlert.Properties.Settings.Default["MarketInfoService"];
                cbNotification.Checked = (bool)TSEAlert.Properties.Settings.Default["Notification"];
                txtServiceDuration.Value = Convert.ToInt32(TSEAlert.Properties.Settings.Default["ServiceDuration"]);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbChangeServiceStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Properties.Settings.Default["MainService"] = cbChangeServiceStatus.Checked;
                TSEAlert.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Changing Main Service status fail.");
            }
        }

        private void cbChangeMarketInfoServiceStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Properties.Settings.Default["MarketInfoService"] = cbChangeMarketInfoServiceStatus.Checked;
                TSEAlert.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Changing Market Info Service status fail.");
            }
        }

        private void cbNotification_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Properties.Settings.Default["Notification"] = cbNotification.Checked;
                TSEAlert.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Changing notification status fail.");
            }
        }

        private void btnClearOldAlertMessage_Click(object sender, EventArgs e)
        {
            try
            {
                var dbHandler = new DbHandler();
                var oldAlertMessages = dbHandler.GetAlertMessages().Where(x => x.Date != DateTime.Today).ToList();
                dbHandler.RemoveAlertMessages(oldAlertMessages);
                ShowSuccessMessage(lblStatus, "Clear old alert messages succeed.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Clear old alert messages fail.");
            }
        }

        private void btnMakeDbLighter_Click(object sender, EventArgs e)
        {
            try
            {
                var dbHandler = new DbHandler();
                var stocks = dbHandler.GetStocks();
                var alerts = dbHandler.GetAlerts();
                foreach (var alert in alerts)
                {
                    var stock = stocks.SingleOrDefault(x => x.Id == alert.Id);
                    stocks.Remove(stock);
                }
                dbHandler.RemoveStock(stocks);
                ShowSuccessMessage(lblStatus, "Make the database lighter succeed.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Make the database lighter fail.");
            }
        }

        private void txtServiceDuration_Leave(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Properties.Settings.Default["ServiceDuration"] = Convert.ToInt32(txtServiceDuration.Value);
                TSEAlert.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Changing service duration fail.");
            }
        }
    }
}
