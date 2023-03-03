namespace StockExchangeAlert.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlCloseApplication = new System.Windows.Forms.Panel();
            this.pnlCloseApplicationSubMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRunInBackground = new System.Windows.Forms.Button();
            this.btnCloseApplication = new FontAwesome.Sharp.IconButton();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.pnlHelpSubMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlSettingsSubMenu = new System.Windows.Forms.Panel();
            this.btnAllSettings = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.pnlAlert = new System.Windows.Forms.Panel();
            this.pnlAlertSubMenu = new System.Windows.Forms.Panel();
            this.btnActivatedAlerts = new System.Windows.Forms.Button();
            this.btnOnlinePrice = new System.Windows.Forms.Button();
            this.btnShowAllAlert = new System.Windows.Forms.Button();
            this.btnAddNewAlert = new System.Windows.Forms.Button();
            this.btnAlert = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHomeLocation = new System.Windows.Forms.Panel();
            this.lblInternetConnection = new System.Windows.Forms.Label();
            this.iconHomeTitle = new FontAwesome.Sharp.IconPictureBox();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.pnlChildFormPanel = new System.Windows.Forms.Panel();
            this.dgvMarketInfo = new System.Windows.Forms.DataGridView();
            this.lblMainServiceStatus = new System.Windows.Forms.Label();
            this.lblMarketInfoServiceStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bwCoreService = new System.ComponentModel.BackgroundWorker();
            this.niNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.bwMarketInfoService = new System.ComponentModel.BackgroundWorker();
            this.FeatureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            this.pnlCloseApplication.SuspendLayout();
            this.pnlCloseApplicationSubMenu.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.pnlHelpSubMenu.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlSettingsSubMenu.SuspendLayout();
            this.pnlAlert.SuspendLayout();
            this.pnlAlertSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHomeLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHomeTitle)).BeginInit();
            this.pnlChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarketInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pnlLeft.Controls.Add(this.pnlCloseApplication);
            this.pnlLeft.Controls.Add(this.pnlHelp);
            this.pnlLeft.Controls.Add(this.pnlSettings);
            this.pnlLeft.Controls.Add(this.pnlAlert);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(280, 500);
            this.pnlLeft.TabIndex = 10;
            // 
            // pnlCloseApplication
            // 
            this.pnlCloseApplication.AutoSize = true;
            this.pnlCloseApplication.Controls.Add(this.pnlCloseApplicationSubMenu);
            this.pnlCloseApplication.Controls.Add(this.btnCloseApplication);
            this.pnlCloseApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCloseApplication.Location = new System.Drawing.Point(0, 488);
            this.pnlCloseApplication.Name = "pnlCloseApplication";
            this.pnlCloseApplication.Size = new System.Drawing.Size(263, 133);
            this.pnlCloseApplication.TabIndex = 4;
            // 
            // pnlCloseApplicationSubMenu
            // 
            this.pnlCloseApplicationSubMenu.Controls.Add(this.btnExit);
            this.pnlCloseApplicationSubMenu.Controls.Add(this.btnRunInBackground);
            this.pnlCloseApplicationSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCloseApplicationSubMenu.Location = new System.Drawing.Point(0, 39);
            this.pnlCloseApplicationSubMenu.Name = "pnlCloseApplicationSubMenu";
            this.pnlCloseApplicationSubMenu.Size = new System.Drawing.Size(263, 94);
            this.pnlCloseApplicationSubMenu.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(0, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(263, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRunInBackground
            // 
            this.btnRunInBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnRunInBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRunInBackground.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRunInBackground.FlatAppearance.BorderSize = 0;
            this.btnRunInBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnRunInBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnRunInBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunInBackground.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunInBackground.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRunInBackground.Location = new System.Drawing.Point(0, 0);
            this.btnRunInBackground.Name = "btnRunInBackground";
            this.btnRunInBackground.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRunInBackground.Size = new System.Drawing.Size(263, 30);
            this.btnRunInBackground.TabIndex = 4;
            this.btnRunInBackground.Text = "Run in Background";
            this.btnRunInBackground.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunInBackground.UseVisualStyleBackColor = false;
            this.btnRunInBackground.Click += new System.EventHandler(this.btnRunInBackground_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCloseApplication.FlatAppearance.BorderSize = 0;
            this.btnCloseApplication.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCloseApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCloseApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApplication.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCloseApplication.IconColor = System.Drawing.Color.Gold;
            this.btnCloseApplication.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseApplication.IconSize = 28;
            this.btnCloseApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseApplication.Location = new System.Drawing.Point(0, 0);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(263, 39);
            this.btnCloseApplication.TabIndex = 1;
            this.btnCloseApplication.Text = "Close Application";
            this.btnCloseApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // pnlHelp
            // 
            this.pnlHelp.AutoSize = true;
            this.pnlHelp.Controls.Add(this.pnlHelpSubMenu);
            this.pnlHelp.Controls.Add(this.btnHelp);
            this.pnlHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHelp.Location = new System.Drawing.Point(0, 355);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(263, 133);
            this.pnlHelp.TabIndex = 3;
            // 
            // pnlHelpSubMenu
            // 
            this.pnlHelpSubMenu.Controls.Add(this.btnAbout);
            this.pnlHelpSubMenu.Controls.Add(this.btnGuide);
            this.pnlHelpSubMenu.Controls.Add(this.btnSendFeedback);
            this.pnlHelpSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHelpSubMenu.Location = new System.Drawing.Point(0, 39);
            this.pnlHelpSubMenu.Name = "pnlHelpSubMenu";
            this.pnlHelpSubMenu.Size = new System.Drawing.Size(263, 94);
            this.pnlHelpSubMenu.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbout.Location = new System.Drawing.Point(0, 60);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(263, 30);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuide.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuide.Location = new System.Drawing.Point(0, 30);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGuide.Size = new System.Drawing.Size(263, 30);
            this.btnGuide.TabIndex = 5;
            this.btnGuide.Text = "Guide";
            this.btnGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnSendFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSendFeedback.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSendFeedback.FlatAppearance.BorderSize = 0;
            this.btnSendFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnSendFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFeedback.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendFeedback.Location = new System.Drawing.Point(0, 0);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSendFeedback.Size = new System.Drawing.Size(263, 30);
            this.btnSendFeedback.TabIndex = 4;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.HireAHelper;
            this.btnHelp.IconColor = System.Drawing.Color.Gold;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 28;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(263, 39);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoSize = true;
            this.pnlSettings.Controls.Add(this.pnlSettingsSubMenu);
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 254);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(263, 101);
            this.pnlSettings.TabIndex = 2;
            // 
            // pnlSettingsSubMenu
            // 
            this.pnlSettingsSubMenu.Controls.Add(this.btnAllSettings);
            this.pnlSettingsSubMenu.Controls.Add(this.btnAccountManagement);
            this.pnlSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettingsSubMenu.Location = new System.Drawing.Point(0, 39);
            this.pnlSettingsSubMenu.Name = "pnlSettingsSubMenu";
            this.pnlSettingsSubMenu.Size = new System.Drawing.Size(263, 62);
            this.pnlSettingsSubMenu.TabIndex = 3;
            // 
            // btnAllSettings
            // 
            this.btnAllSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnAllSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllSettings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAllSettings.FlatAppearance.BorderSize = 0;
            this.btnAllSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAllSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAllSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSettings.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllSettings.Location = new System.Drawing.Point(0, 30);
            this.btnAllSettings.Name = "btnAllSettings";
            this.btnAllSettings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAllSettings.Size = new System.Drawing.Size(263, 30);
            this.btnAllSettings.TabIndex = 5;
            this.btnAllSettings.Text = "Settings";
            this.btnAllSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllSettings.UseVisualStyleBackColor = false;
            this.btnAllSettings.Click += new System.EventHandler(this.btnAllSettings_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountManagement.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAccountManagement.FlatAppearance.BorderSize = 0;
            this.btnAccountManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAccountManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccountManagement.Location = new System.Drawing.Point(0, 0);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAccountManagement.Size = new System.Drawing.Size(263, 30);
            this.btnAccountManagement.TabIndex = 4;
            this.btnAccountManagement.Text = "Acoount Management";
            this.btnAccountManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSettings.IconColor = System.Drawing.Color.Gold;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 28;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(263, 39);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlAlert
            // 
            this.pnlAlert.AutoSize = true;
            this.pnlAlert.Controls.Add(this.pnlAlertSubMenu);
            this.pnlAlert.Controls.Add(this.btnAlert);
            this.pnlAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlert.Location = new System.Drawing.Point(0, 96);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Size = new System.Drawing.Size(263, 158);
            this.pnlAlert.TabIndex = 1;
            // 
            // pnlAlertSubMenu
            // 
            this.pnlAlertSubMenu.Controls.Add(this.btnActivatedAlerts);
            this.pnlAlertSubMenu.Controls.Add(this.btnOnlinePrice);
            this.pnlAlertSubMenu.Controls.Add(this.btnShowAllAlert);
            this.pnlAlertSubMenu.Controls.Add(this.btnAddNewAlert);
            this.pnlAlertSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlertSubMenu.Location = new System.Drawing.Point(0, 39);
            this.pnlAlertSubMenu.Name = "pnlAlertSubMenu";
            this.pnlAlertSubMenu.Size = new System.Drawing.Size(263, 119);
            this.pnlAlertSubMenu.TabIndex = 3;
            // 
            // btnActivatedAlerts
            // 
            this.btnActivatedAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnActivatedAlerts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivatedAlerts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnActivatedAlerts.FlatAppearance.BorderSize = 0;
            this.btnActivatedAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnActivatedAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnActivatedAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivatedAlerts.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivatedAlerts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivatedAlerts.Location = new System.Drawing.Point(0, 90);
            this.btnActivatedAlerts.Name = "btnActivatedAlerts";
            this.btnActivatedAlerts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnActivatedAlerts.Size = new System.Drawing.Size(263, 30);
            this.btnActivatedAlerts.TabIndex = 7;
            this.btnActivatedAlerts.Text = "Actived Alerts";
            this.btnActivatedAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivatedAlerts.UseVisualStyleBackColor = false;
            this.btnActivatedAlerts.Click += new System.EventHandler(this.btnActivatedAlerts_Click);
            // 
            // btnOnlinePrice
            // 
            this.btnOnlinePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnOnlinePrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOnlinePrice.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOnlinePrice.FlatAppearance.BorderSize = 0;
            this.btnOnlinePrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnOnlinePrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnOnlinePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlinePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlinePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOnlinePrice.Location = new System.Drawing.Point(0, 60);
            this.btnOnlinePrice.Name = "btnOnlinePrice";
            this.btnOnlinePrice.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOnlinePrice.Size = new System.Drawing.Size(263, 30);
            this.btnOnlinePrice.TabIndex = 6;
            this.btnOnlinePrice.Text = "Online Price";
            this.btnOnlinePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnlinePrice.UseVisualStyleBackColor = false;
            this.btnOnlinePrice.Click += new System.EventHandler(this.btnOnlinePrice_Click);
            // 
            // btnShowAllAlert
            // 
            this.btnShowAllAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnShowAllAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAllAlert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowAllAlert.FlatAppearance.BorderSize = 0;
            this.btnShowAllAlert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnShowAllAlert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnShowAllAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllAlert.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAlert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAllAlert.Location = new System.Drawing.Point(0, 30);
            this.btnShowAllAlert.Name = "btnShowAllAlert";
            this.btnShowAllAlert.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowAllAlert.Size = new System.Drawing.Size(263, 30);
            this.btnShowAllAlert.TabIndex = 5;
            this.btnShowAllAlert.Text = "Show All Alert";
            this.btnShowAllAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllAlert.UseVisualStyleBackColor = false;
            this.btnShowAllAlert.Click += new System.EventHandler(this.btnShowAllAlert_Click);
            // 
            // btnAddNewAlert
            // 
            this.btnAddNewAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnAddNewAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewAlert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddNewAlert.FlatAppearance.BorderSize = 0;
            this.btnAddNewAlert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAddNewAlert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAddNewAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAlert.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAlert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewAlert.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewAlert.Name = "btnAddNewAlert";
            this.btnAddNewAlert.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddNewAlert.Size = new System.Drawing.Size(263, 30);
            this.btnAddNewAlert.TabIndex = 4;
            this.btnAddNewAlert.Text = "Add New Alert";
            this.btnAddNewAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewAlert.UseVisualStyleBackColor = false;
            this.btnAddNewAlert.Click += new System.EventHandler(this.btnAddNewAlert_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlert.FlatAppearance.BorderSize = 0;
            this.btnAlert.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAlert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAlert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlert.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnAlert.IconColor = System.Drawing.Color.Gold;
            this.btnAlert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlert.IconSize = 28;
            this.btnAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlert.Location = new System.Drawing.Point(0, 0);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(263, 39);
            this.btnAlert.TabIndex = 0;
            this.btnAlert.Text = "Alert";
            this.btnAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblTitle);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(263, 96);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tehran Stock Exchange Alert";
            // 
            // pnlHomeLocation
            // 
            this.pnlHomeLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.pnlHomeLocation.Controls.Add(this.lblInternetConnection);
            this.pnlHomeLocation.Controls.Add(this.iconHomeTitle);
            this.pnlHomeLocation.Controls.Add(this.lblHomeTitle);
            this.pnlHomeLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeLocation.Location = new System.Drawing.Point(280, 0);
            this.pnlHomeLocation.Name = "pnlHomeLocation";
            this.pnlHomeLocation.Size = new System.Drawing.Size(680, 50);
            this.pnlHomeLocation.TabIndex = 1;
            this.pnlHomeLocation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHomeLocation_MouseDown);
            // 
            // lblInternetConnection
            // 
            this.lblInternetConnection.AutoSize = true;
            this.lblInternetConnection.ForeColor = System.Drawing.Color.Tomato;
            this.lblInternetConnection.Location = new System.Drawing.Point(390, 22);
            this.lblInternetConnection.Name = "lblInternetConnection";
            this.lblInternetConnection.Size = new System.Drawing.Size(0, 12);
            this.lblInternetConnection.TabIndex = 12;
            // 
            // iconHomeTitle
            // 
            this.iconHomeTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.iconHomeTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconHomeTitle.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.iconHomeTitle.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconHomeTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHomeTitle.IconSize = 31;
            this.iconHomeTitle.Location = new System.Drawing.Point(22, 12);
            this.iconHomeTitle.Name = "iconHomeTitle";
            this.iconHomeTitle.Size = new System.Drawing.Size(31, 32);
            this.iconHomeTitle.TabIndex = 1;
            this.iconHomeTitle.TabStop = false;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.Location = new System.Drawing.Point(54, 20);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(39, 16);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Home";
            // 
            // pnlChildFormPanel
            // 
            this.pnlChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.pnlChildFormPanel.Controls.Add(this.dgvMarketInfo);
            this.pnlChildFormPanel.Controls.Add(this.lblMainServiceStatus);
            this.pnlChildFormPanel.Controls.Add(this.lblMarketInfoServiceStatus);
            this.pnlChildFormPanel.Controls.Add(this.lblStatus);
            this.pnlChildFormPanel.Controls.Add(this.label2);
            this.pnlChildFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildFormPanel.Location = new System.Drawing.Point(280, 50);
            this.pnlChildFormPanel.Name = "pnlChildFormPanel";
            this.pnlChildFormPanel.Size = new System.Drawing.Size(680, 450);
            this.pnlChildFormPanel.TabIndex = 11;
            this.pnlChildFormPanel.MouseHover += new System.EventHandler(this.pnlChildFormPanel_MouseHover);
            // 
            // dgvMarketInfo
            // 
            this.dgvMarketInfo.AllowUserToAddRows = false;
            this.dgvMarketInfo.AllowUserToDeleteRows = false;
            this.dgvMarketInfo.AllowUserToResizeColumns = false;
            this.dgvMarketInfo.AllowUserToResizeRows = false;
            this.dgvMarketInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMarketInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.dgvMarketInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarketInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarketInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarketInfo.ColumnHeadersVisible = false;
            this.dgvMarketInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeatureName,
            this.FeatureValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarketInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarketInfo.EnableHeadersVisualStyles = false;
            this.dgvMarketInfo.Location = new System.Drawing.Point(190, 100);
            this.dgvMarketInfo.MultiSelect = false;
            this.dgvMarketInfo.Name = "dgvMarketInfo";
            this.dgvMarketInfo.ReadOnly = true;
            this.dgvMarketInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarketInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarketInfo.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMarketInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMarketInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarketInfo.Size = new System.Drawing.Size(438, 274);
            this.dgvMarketInfo.TabIndex = 11;
            // 
            // lblMainServiceStatus
            // 
            this.lblMainServiceStatus.AutoSize = true;
            this.lblMainServiceStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMainServiceStatus.Location = new System.Drawing.Point(20, 34);
            this.lblMainServiceStatus.Name = "lblMainServiceStatus";
            this.lblMainServiceStatus.Size = new System.Drawing.Size(173, 12);
            this.lblMainServiceStatus.TabIndex = 9;
            this.lblMainServiceStatus.Text = "Main Service is stopped.";
            // 
            // lblMarketInfoServiceStatus
            // 
            this.lblMarketInfoServiceStatus.AutoSize = true;
            this.lblMarketInfoServiceStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMarketInfoServiceStatus.Location = new System.Drawing.Point(20, 14);
            this.lblMarketInfoServiceStatus.Name = "lblMarketInfoServiceStatus";
            this.lblMarketInfoServiceStatus.Size = new System.Drawing.Size(271, 12);
            this.lblMarketInfoServiceStatus.TabIndex = 9;
            this.lblMarketInfoServiceStatus.Text = "Market Information Service is stopped.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(79, 396);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(538, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "اطلاعات بازار:";
            // 
            // bwCoreService
            // 
            this.bwCoreService.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCoreService_DoWork);
            // 
            // niNotification
            // 
            this.niNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niNotification.BalloonTipTitle = "Tehran Stock Exchange Alert";
            this.niNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("niNotification.Icon")));
            this.niNotification.Text = "Tehran Stock Exchange Alert";
            this.niNotification.Visible = true;
            this.niNotification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niNotification_MouseClick);
            // 
            // bwMarketInfoService
            // 
            this.bwMarketInfoService.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMarketInfoService_DoWork);
            // 
            // FeatureName
            // 
            this.FeatureName.DataPropertyName = "FeatureName";
            this.FeatureName.HeaderText = "Feature Name";
            this.FeatureName.Name = "FeatureName";
            this.FeatureName.ReadOnly = true;
            this.FeatureName.Width = 150;
            // 
            // FeatureValue
            // 
            this.FeatureValue.DataPropertyName = "FeatureValue";
            this.FeatureValue.HeaderText = "Feature Value";
            this.FeatureValue.Name = "FeatureValue";
            this.FeatureValue.ReadOnly = true;
            this.FeatureValue.Width = 250;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 500);
            this.Controls.Add(this.pnlChildFormPanel);
            this.Controls.Add(this.pnlHomeLocation);
            this.Controls.Add(this.pnlLeft);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumSize = new System.Drawing.Size(960, 500);
            this.Name = "frmMain";
            this.Text = "Tehran Stock Exchange Alert (TSEA)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlCloseApplication.ResumeLayout(false);
            this.pnlCloseApplicationSubMenu.ResumeLayout(false);
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelpSubMenu.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettingsSubMenu.ResumeLayout(false);
            this.pnlAlert.ResumeLayout(false);
            this.pnlAlertSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlHomeLocation.ResumeLayout(false);
            this.pnlHomeLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHomeTitle)).EndInit();
            this.pnlChildFormPanel.ResumeLayout(false);
            this.pnlChildFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarketInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlHomeLocation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Panel pnlAlert;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlAlertSubMenu;
        private System.Windows.Forms.Button btnOnlinePrice;
        private System.Windows.Forms.Button btnShowAllAlert;
        private System.Windows.Forms.Button btnAddNewAlert;
        private System.Windows.Forms.Panel pnlSettingsSubMenu;
        private System.Windows.Forms.Button btnAllSettings;
        private System.Windows.Forms.Button btnAccountManagement;
        private FontAwesome.Sharp.IconButton btnAlert;
        private System.Windows.Forms.Panel pnlCloseApplication;
        private System.Windows.Forms.Panel pnlCloseApplicationSubMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRunInBackground;
        private FontAwesome.Sharp.IconButton btnCloseApplication;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Panel pnlHelpSubMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnSendFeedback;
        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.Panel pnlSettings;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconPictureBox iconHomeTitle;
        private System.Windows.Forms.Panel pnlChildFormPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActivatedAlerts;
        private System.ComponentModel.BackgroundWorker bwCoreService;
        private System.Windows.Forms.NotifyIcon niNotification;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvMarketInfo;
        private System.ComponentModel.BackgroundWorker bwMarketInfoService;
        private System.Windows.Forms.Label lblMarketInfoServiceStatus;
        private System.Windows.Forms.Label lblInternetConnection;
        private System.Windows.Forms.Label lblMainServiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureValue;
    }
}