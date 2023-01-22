using System.Collections.Generic;
using System.Windows.Forms;
using TSEAlert.Handler;
using TSEAlert.Network;
using TSEAlert.Forms;
using System;

namespace StockExchangeAlert.Forms
{
    public partial class frmShowAllAlert : frmBaseForm
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public frmShowAllAlert()
        {
            InitializeComponent();
        }

        private void frmShowAllAlert_Load(object sender, EventArgs e)
        {
            try
            {
                BindingToDgv();
                lblStatus.Text = string.Empty;
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

        private void dgvShowAlert_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dgvShowAlert.CurrentCell = clickedCell;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Table loading fail.");
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Models.Alert alert = GetClickSelection();
                new AlertHandler().Remove(alert);
                BindingToDgv();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Remove the Alert fail.");
            }
        }

        private void changePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Models.Alert alert = GetClickSelection();
                if (alert == null)
                    return;

                var form = new frmChangePrice();
                form.ShowDialog();

                if (form.Price == Convert.ToInt32(alert.Price))
                    return;

                alert.Price = form.Price.ToString();
                new AlertHandler().Update(alert);
                BindingToDgv();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Change Price fail.");
            }
        }

        private void activeDeactiveAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Models.Alert alert = GetClickSelection();
                if (alert == null)
                    return;
                alert.Status = !alert.Status;
                new AlertHandler().Update(alert);
                BindingToDgv();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Change the Alert status fail.");
            }
        }

        private void getOnlinePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Models.Alert alert = GetClickSelection();
                if (alert == null)
                    return;
                var lastPrice = new StockTransactionInformation(alert.TseCode).GetLastTransactionPrice();
                new frmShowPrice(lastPrice).ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Get online price fail.");
            }
        }

        private void goToTsetmcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Models.Alert alert = GetClickSelection();
                if (alert == null)
                    return;
                var address = string.Format(Address.GetTsetmcAddress(), alert.TseCode);
                System.Diagnostics.Process.Start(address);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Open browser fail.");
            }
        }

        private void goToCodalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TSEAlert.Models.Alert alert = GetClickSelection();
                if (alert == null)
                    return;
                var address = string.Format(Address.GetCodalAddress(), alert.Symbol);
                System.Diagnostics.Process.Start(address);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Open browser fail.");
            }
        }

        private void BindingToDgv()
        {
            try
            {
                var alerts = new AlertHandler().Get();

                dgvShowAlert.DataSource = GenerateList(alerts);
                this.dgvShowAlert.Columns["alertId"].Visible = false;

                this.dgvShowAlert.Columns["StockName"].DisplayIndex = 0;
                this.dgvShowAlert.Columns["AlertPrice"].DisplayIndex = 1;
                this.dgvShowAlert.Columns["Status"].DisplayIndex = 2;
                this.dgvShowAlert.Columns["AlertType"].DisplayIndex = 3;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<ShowAlertsBindingObject> GenerateList(List<TSEAlert.Models.Alert> alerts)
        {
            try
            {
                List<ShowAlertsBindingObject> bindingObjects = new List<ShowAlertsBindingObject>();
                foreach (var item in alerts)
                {
                    ShowAlertsBindingObject bo = new ShowAlertsBindingObject()
                    {
                        alertId = item.Id,
                        StockName = item.Symbol,
                        AlertPrice = item.Price,
                        Status = item.Status,
                        AlertType = TSEAlert.Handler.AlertType.GetString(item.AlertType)
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

        private TSEAlert.Models.Alert GetClickSelection()
        {
            try
            {
                var entity = dgvShowAlert.SelectedRows[0].DataBoundItem as ShowAlertsBindingObject;
                var alert = new AlertHandler().Get(entity.alertId);
                if (alert == null)
                    throw new Exception("Alert Not Found.");
                return alert;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    internal class ShowAlertsBindingObject
    {
        public int alertId { get; set; }
        public string StockName { get; set; }
        public string AlertPrice { get; set; }
        public bool Status { get; set; }
        public string AlertType { get; set; }

    }
}
