using System.Windows.Forms;
using StockExchangeAlert;
using TSEAlert.Handler;
using System.Drawing;
using System;

namespace TSEAlert.Forms
{
    public partial class frmActivatedAlerts : frmBaseForm
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public frmActivatedAlerts()
        {
            InitializeComponent();
        }

        private void frmActivatedAlerts_Load(object sender, EventArgs e)
        {
            try
            {
                BindingToListView();
                lblStatus.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                this.Close();
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            try
            {
                new MessageHandler().RemoveAll();
                BindingToListView();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Remove activated alerts fail.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbAlertMessages_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var item = lbAlertMessages.Items[e.Index] as Models.Message;
                if (item != null)
                {
                    if (item.Date == DateTime.Today)
                    {
                        e.Graphics.DrawString(
                        item.Content,
                        e.Font,
                        new SolidBrush(Color.GreenYellow),
                        e.Bounds, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                    }
                    else
                    {
                        e.Graphics.DrawString(
                        item.Content,
                        e.Font,
                        new SolidBrush(Color.White),
                        e.Bounds, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading activated alerts fail.");
            }
        }

        private void BindingToListView()
        {
            try
            {
                var alertMessages = new MessageHandler().Get();
                lbAlertMessages.DataSource = alertMessages;
                lbAlertMessages.DisplayMember = "Message";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
