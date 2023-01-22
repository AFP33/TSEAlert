using System.Windows.Forms;
using TSEAlert.Handler;
using TSEAlert.Models;
using System;

namespace StockExchangeAlert.Forms
{
    public partial class frmAddNewAlert : frmBaseForm
    {
        private Stock SelectedStock { get; set; }
        private Tuple<TSEAlert.Models.AlertType, string> SelectedAlertType { get; set; }

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public frmAddNewAlert()
        {
            InitializeComponent();
        }

        private void frmAddNewAlert_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSearchBox.Text = "";
                SelectedStock = null;
                SelectedAlertType = null;

                var alertType = TSEAlert.Handler.AlertType.GetAlertType();
                cmbAlertType.DataSource = alertType;
                cmbAlertType.DisplayMember = "Item2";

                lblStatus.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                this.Close();
            }
        }

        private void cmbAlertType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAlertType.SelectedItem == null)
                    return;

                var selectedItem = (Tuple<TSEAlert.Models.AlertType, string>)cmbAlertType.SelectedItem;
                if (selectedItem != null)
                    SelectedAlertType = selectedItem;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Select alert type fail.");
            }
        }

        private void cmbSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    var stocks = new SearchStock().Find(cmbSearchBox.Text);
                    cmbSearchBox.DisplayMember = "Symbol";
                    cmbSearchBox.DataSource = stocks;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Searching stock fail.");
            }
        }

        private void cmbSearchBox_Enter(object sender, EventArgs e)
        {
            try
            {
                ComboBox cbo = sender as ComboBox;
                cbo.DroppedDown = true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Searching stock fail.");
            }

        }

        private void cmbSearchBox_Format(object sender, ListControlConvertEventArgs e)
        {
            try
            {
                string name = ((Stock)e.ListItem).Name;
                string symbol = ((Stock)e.ListItem).Symbol;
                e.Value = name + "-" + symbol;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Searching stock fail.");
            }
        }

        private void cmbSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchBox.SelectedItem == null)
                    return;

                var stock = (Stock)cmbSearchBox.SelectedItem;
                if (stock != null)
                    SelectedStock = stock;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Searching stock fail.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation())
                    return;

                var dbHandler = new AlertHandler();
                dbHandler.Add(new Alert()
                {
                    Name = SelectedStock.Name,
                    Symbol = SelectedStock.Symbol,
                    TseCode = SelectedStock.TseCode,
                    Price = txtPrice.Text,
                    AlertType = SelectedAlertType.Item1,
                    Status = true,
                });
                ShowSuccessMessage(lblStatus, "New Alert add successfully.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "We have some Error to saving data in database.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validation()
        {
            try
            {
                if (SelectedStock == null)
                {
                    ShowErrorMessage(lblStatus, "Stock Name is require.");
                    return false;
                }
                else if (SelectedAlertType == null)
                {
                    ShowErrorMessage(lblStatus, "Alert Type is require.");
                    return false;
                }
                else if (txtPrice.Text == string.Empty || string.IsNullOrEmpty(txtPrice.Text))
                {
                    ShowErrorMessage(lblStatus, "Alert Price is require.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
