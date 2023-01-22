using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Windows.Forms;
using TSEAlert.Service;
using TSEAlert.Handler;
using TSEAlert.Forms;
using System;

namespace StockExchangeAlert.Forms
{
    public partial class frmMain : frmBaseForm
    {
        private Form activeForm = null;

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public frmMain()
        {
            try
            {
                InitializeComponent();
                using (frmLoading loading = new frmLoading(LoadingFormWorker))
                    loading.ShowDialog(this);
                CustomizeDesign();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                MessageBox.Show("Running Main form fail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblMainServiceStatus.Text = string.Empty;
                lblMarketInfoServiceStatus.Text = string.Empty;
                this.bwMarketInfoService.RunWorkerAsync();
                this.bwCoreService.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Running main service fail.");
            }
        }

        #region Movable Forms
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        protected void MouseDownEvent(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        private void pnlHomeLocation_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                MouseDownEvent(sender, e);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }
        #endregion

        #region MainMenu

        private void CustomizeDesign()
        {
            try
            {
                pnlAlertSubMenu.Visible = false;
                pnlSettingsSubMenu.Visible = false;
                pnlHelpSubMenu.Visible = false;
                pnlCloseApplicationSubMenu.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HideSubMenu()
        {
            try
            {
                if (pnlAlertSubMenu.Visible == true)
                    pnlAlertSubMenu.Visible = false;
                if (pnlSettingsSubMenu.Visible == true)
                    pnlSettingsSubMenu.Visible = false;
                if (pnlHelpSubMenu.Visible == true)
                    pnlHelpSubMenu.Visible = false;
                if (pnlCloseApplicationSubMenu.Visible == true)
                    pnlCloseApplicationSubMenu.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ShowSubMenu(Panel panel)
        {
            try
            {
                if (panel.Visible == false)
                {
                    HideSubMenu();
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            try
            {
                ShowSubMenu(pnlAlertSubMenu);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                ShowSubMenu(pnlSettingsSubMenu);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                ShowSubMenu(pnlHelpSubMenu);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            try
            {
                ShowSubMenu(pnlCloseApplicationSubMenu);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }
        #endregion

        #region SubMenu
        private void btnAddNewAlert_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Alert/Add New Alert";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.Bell;
                OpenChildForm(new frmAddNewAlert());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Add New Alert' page fail.");
            }
        }

        private void btnShowAllAlert_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Alert/Show All Alert";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.Bell;
                OpenChildForm(new frmShowAllAlert());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Show All Alert' page fail.");
            }
        }

        private void btnOnlinePrice_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Alert/Online Price";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.InternetExplorer;
                OpenChildForm(new frmOnlinePrice());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Show Online Price' page fail.");
            }
        }

        private void btnActivatedAlerts_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Alert/Activated Alerts";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.Cpanel;
                OpenChildForm(new frmActivatedAlerts());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Show Activated Alerts' page fail.");
            }
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Settings/Account Management";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.Cogs;
                OpenChildForm(new frmAccountManagement());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Account Management' page fail.");
            }
        }

        private void btnAllSettings_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Settings/Configuration Settings";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.Cogs;
                OpenChildForm(new frmConfiguration());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Settings' page fail.");
            }
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Help/Send Feedback";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
                OpenChildForm(new frmSendFeedback());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Send Feedback' page fail.");
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Help/Guid";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
                OpenChildForm(new frmGuide());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'Guid' page fail.");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Help/About us";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
                OpenChildForm(new frmAbout());
                //...
                // Your Code Hear
                //...
                HideSubMenu();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Loading 'About us' page fail.");
            }
        }

        private void btnRunInBackground_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                WindowState = FormWindowState.Minimized;
                niNotification.Icon = this.Icon;
                this.ShowInTaskbar = false;
                niNotification.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                ShowErrorMessage(lblStatus, "Run in background fail.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void bwCoreService_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var mainService = new Core(lblMainServiceStatus);
                mainService.Run();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                lblStatus.Invoke(new Action(() => 
                { 
                    ShowErrorMessage(lblStatus, "The main service was forcibly stopped.\n\nPlease check your connection and restart the program."); 
                }));
            }
        }

        private void bwMarketInfoService_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var marketService = new MarketInfo(dgvMarketInfo, lblMarketInfoServiceStatus);
                marketService.Run();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                lblStatus.Invoke(new Action(() => 
                { 
                    ShowErrorMessage(lblStatus, "The market info service was forcibly stopped.\nPlease check your connection and restart the program."); 
                }));
            }
        }

        private void pnlChildFormPanel_MouseHover(object sender, EventArgs e)
        {
            try
            {
                lblHomeTitle.Text = "Home";
                iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
                if (!IsConnectedToInternet())
                    lblInternetConnection.Text = "No Internet Access.";
                else
                    lblInternetConnection.Text = "";
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        private void niNotification_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.ShowInTaskbar = true;
                this.Visible = true;

                WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (activeForm != null)
                    activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                pnlChildFormPanel.Controls.Add(childForm);
                pnlChildFormPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadingFormWorker()
        {
            try
            {
                new AlertHandler();
                new MessageHandler();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool IsConnectedToInternet()
        {
            string host = "google.com";
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}