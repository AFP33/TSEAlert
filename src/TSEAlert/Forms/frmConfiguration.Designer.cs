namespace StockExchangeAlert.Forms
{
    partial class frmConfiguration
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
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblMainServiceRecomend1 = new System.Windows.Forms.Label();
            this.cbChangeServiceStatus = new System.Windows.Forms.CheckBox();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceDurationRecommend = new System.Windows.Forms.Label();
            this.txtServiceDuration = new System.Windows.Forms.NumericUpDown();
            this.lblServiceDuration = new System.Windows.Forms.Label();
            this.cbChangeMarketInfoServiceStatus = new System.Windows.Forms.CheckBox();
            this.cbNotification = new System.Windows.Forms.CheckBox();
            this.lblAlertNotificationRecomed = new System.Windows.Forms.Label();
            this.lblClearOldAlertMessage = new System.Windows.Forms.Label();
            this.lbllblMakeDbLighter = new System.Windows.Forms.Label();
            this.btnClearOldAlertMessage = new System.Windows.Forms.Button();
            this.btnMakeDbLighter = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.gbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Snow;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(620, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMainServiceRecomend1
            // 
            this.lblMainServiceRecomend1.AutoSize = true;
            this.lblMainServiceRecomend1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainServiceRecomend1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMainServiceRecomend1.Location = new System.Drawing.Point(39, 54);
            this.lblMainServiceRecomend1.Name = "lblMainServiceRecomend1";
            this.lblMainServiceRecomend1.Size = new System.Drawing.Size(453, 12);
            this.lblMainServiceRecomend1.TabIndex = 2;
            this.lblMainServiceRecomend1.Text = "> Be aware, if you disable this, Alert Service while be disable.";
            // 
            // cbChangeServiceStatus
            // 
            this.cbChangeServiceStatus.AutoSize = true;
            this.cbChangeServiceStatus.Checked = true;
            this.cbChangeServiceStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChangeServiceStatus.Cursor = System.Windows.Forms.Cursors.No;
            this.cbChangeServiceStatus.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChangeServiceStatus.ForeColor = System.Drawing.Color.White;
            this.cbChangeServiceStatus.Location = new System.Drawing.Point(21, 32);
            this.cbChangeServiceStatus.Name = "cbChangeServiceStatus";
            this.cbChangeServiceStatus.Size = new System.Drawing.Size(242, 19);
            this.cbChangeServiceStatus.TabIndex = 4;
            this.cbChangeServiceStatus.Text = "Active/Disable Main Service";
            this.cbChangeServiceStatus.UseVisualStyleBackColor = true;
            this.cbChangeServiceStatus.CheckedChanged += new System.EventHandler(this.cbChangeServiceStatus_CheckedChanged);
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.label1);
            this.gbServices.Controls.Add(this.lblServiceDurationRecommend);
            this.gbServices.Controls.Add(this.txtServiceDuration);
            this.gbServices.Controls.Add(this.lblServiceDuration);
            this.gbServices.Controls.Add(this.cbChangeMarketInfoServiceStatus);
            this.gbServices.Controls.Add(this.cbChangeServiceStatus);
            this.gbServices.Controls.Add(this.lblMainServiceRecomend1);
            this.gbServices.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServices.ForeColor = System.Drawing.Color.Gold;
            this.gbServices.Location = new System.Drawing.Point(29, 70);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(594, 206);
            this.gbServices.TabIndex = 5;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Services";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(39, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "> Be aware, if you disable this, Market Information Service while be disable.";
            // 
            // lblServiceDurationRecommend
            // 
            this.lblServiceDurationRecommend.AutoSize = true;
            this.lblServiceDurationRecommend.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDurationRecommend.ForeColor = System.Drawing.Color.DarkGray;
            this.lblServiceDurationRecommend.Location = new System.Drawing.Point(39, 117);
            this.lblServiceDurationRecommend.Name = "lblServiceDurationRecommend";
            this.lblServiceDurationRecommend.Size = new System.Drawing.Size(264, 12);
            this.lblServiceDurationRecommend.TabIndex = 10;
            this.lblServiceDurationRecommend.Text = "> Every duration to check the alerts.";
            // 
            // txtServiceDuration
            // 
            this.txtServiceDuration.BackColor = System.Drawing.Color.DimGray;
            this.txtServiceDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceDuration.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtServiceDuration.ForeColor = System.Drawing.Color.White;
            this.txtServiceDuration.Location = new System.Drawing.Point(231, 91);
            this.txtServiceDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtServiceDuration.Name = "txtServiceDuration";
            this.txtServiceDuration.Size = new System.Drawing.Size(98, 23);
            this.txtServiceDuration.TabIndex = 9;
            this.txtServiceDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServiceDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtServiceDuration.Leave += new System.EventHandler(this.txtServiceDuration_Leave);
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.ForeColor = System.Drawing.Color.White;
            this.lblServiceDuration.Location = new System.Drawing.Point(19, 96);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(201, 12);
            this.lblServiceDuration.TabIndex = 8;
            this.lblServiceDuration.Text = "> Service Duration (Second):";
            // 
            // cbChangeMarketInfoServiceStatus
            // 
            this.cbChangeMarketInfoServiceStatus.AutoSize = true;
            this.cbChangeMarketInfoServiceStatus.Checked = true;
            this.cbChangeMarketInfoServiceStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChangeMarketInfoServiceStatus.Cursor = System.Windows.Forms.Cursors.No;
            this.cbChangeMarketInfoServiceStatus.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChangeMarketInfoServiceStatus.ForeColor = System.Drawing.Color.White;
            this.cbChangeMarketInfoServiceStatus.Location = new System.Drawing.Point(21, 151);
            this.cbChangeMarketInfoServiceStatus.Name = "cbChangeMarketInfoServiceStatus";
            this.cbChangeMarketInfoServiceStatus.Size = new System.Drawing.Size(354, 19);
            this.cbChangeMarketInfoServiceStatus.TabIndex = 4;
            this.cbChangeMarketInfoServiceStatus.Text = "Active/Disable Market Information Service";
            this.cbChangeMarketInfoServiceStatus.UseVisualStyleBackColor = true;
            this.cbChangeMarketInfoServiceStatus.CheckedChanged += new System.EventHandler(this.cbChangeMarketInfoServiceStatus_CheckedChanged);
            // 
            // cbNotification
            // 
            this.cbNotification.AutoSize = true;
            this.cbNotification.Checked = true;
            this.cbNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotification.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotification.ForeColor = System.Drawing.Color.White;
            this.cbNotification.Location = new System.Drawing.Point(49, 297);
            this.cbNotification.Name = "cbNotification";
            this.cbNotification.Size = new System.Drawing.Size(298, 19);
            this.cbNotification.TabIndex = 4;
            this.cbNotification.Text = "Active/Disable Alert Notifocations";
            this.cbNotification.UseVisualStyleBackColor = true;
            this.cbNotification.CheckedChanged += new System.EventHandler(this.cbNotification_CheckedChanged);
            // 
            // lblAlertNotificationRecomed
            // 
            this.lblAlertNotificationRecomed.AutoSize = true;
            this.lblAlertNotificationRecomed.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertNotificationRecomed.ForeColor = System.Drawing.Color.Gray;
            this.lblAlertNotificationRecomed.Location = new System.Drawing.Point(68, 319);
            this.lblAlertNotificationRecomed.Name = "lblAlertNotificationRecomed";
            this.lblAlertNotificationRecomed.Size = new System.Drawing.Size(460, 12);
            this.lblAlertNotificationRecomed.TabIndex = 6;
            this.lblAlertNotificationRecomed.Text = "> If you disable this feature, Windows doesn\'t show Alert Message";
            // 
            // lblClearOldAlertMessage
            // 
            this.lblClearOldAlertMessage.AutoSize = true;
            this.lblClearOldAlertMessage.ForeColor = System.Drawing.Color.White;
            this.lblClearOldAlertMessage.Location = new System.Drawing.Point(48, 352);
            this.lblClearOldAlertMessage.Name = "lblClearOldAlertMessage";
            this.lblClearOldAlertMessage.Size = new System.Drawing.Size(187, 12);
            this.lblClearOldAlertMessage.TabIndex = 7;
            this.lblClearOldAlertMessage.Text = "> Clear old alert message:";
            // 
            // lbllblMakeDbLighter
            // 
            this.lbllblMakeDbLighter.AutoSize = true;
            this.lbllblMakeDbLighter.ForeColor = System.Drawing.Color.White;
            this.lbllblMakeDbLighter.Location = new System.Drawing.Point(47, 387);
            this.lbllblMakeDbLighter.Name = "lbllblMakeDbLighter";
            this.lbllblMakeDbLighter.Size = new System.Drawing.Size(201, 12);
            this.lbllblMakeDbLighter.TabIndex = 7;
            this.lbllblMakeDbLighter.Text = "> Make the database lighter:";
            // 
            // btnClearOldAlertMessage
            // 
            this.btnClearOldAlertMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnClearOldAlertMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnClearOldAlertMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOldAlertMessage.ForeColor = System.Drawing.Color.Gold;
            this.btnClearOldAlertMessage.Location = new System.Drawing.Point(252, 347);
            this.btnClearOldAlertMessage.Name = "btnClearOldAlertMessage";
            this.btnClearOldAlertMessage.Size = new System.Drawing.Size(95, 23);
            this.btnClearOldAlertMessage.TabIndex = 8;
            this.btnClearOldAlertMessage.Text = "Click Here";
            this.btnClearOldAlertMessage.UseVisualStyleBackColor = false;
            this.btnClearOldAlertMessage.Click += new System.EventHandler(this.btnClearOldAlertMessage_Click);
            // 
            // btnMakeDbLighter
            // 
            this.btnMakeDbLighter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnMakeDbLighter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnMakeDbLighter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeDbLighter.ForeColor = System.Drawing.Color.Gold;
            this.btnMakeDbLighter.Location = new System.Drawing.Point(252, 382);
            this.btnMakeDbLighter.Name = "btnMakeDbLighter";
            this.btnMakeDbLighter.Size = new System.Drawing.Size(95, 23);
            this.btnMakeDbLighter.TabIndex = 8;
            this.btnMakeDbLighter.Text = "Click Here";
            this.btnMakeDbLighter.UseVisualStyleBackColor = false;
            this.btnMakeDbLighter.Click += new System.EventHandler(this.btnMakeDbLighter_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(47, 420);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnMakeDbLighter);
            this.Controls.Add(this.btnClearOldAlertMessage);
            this.Controls.Add(this.lbllblMakeDbLighter);
            this.Controls.Add(this.lblClearOldAlertMessage);
            this.Controls.Add(this.lblAlertNotificationRecomed);
            this.Controls.Add(this.cbNotification);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.btnClose);
            this.MinimumSize = new System.Drawing.Size(664, 450);
            this.Name = "frmConfiguration";
            this.Text = "frmConfiguration";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.gbServices.ResumeLayout(false);
            this.gbServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label lblMainServiceRecomend1;
        private System.Windows.Forms.CheckBox cbChangeServiceStatus;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.CheckBox cbNotification;
        private System.Windows.Forms.Label lblAlertNotificationRecomed;
        private System.Windows.Forms.Label lblClearOldAlertMessage;
        private System.Windows.Forms.Label lbllblMakeDbLighter;
        private System.Windows.Forms.Button btnClearOldAlertMessage;
        private System.Windows.Forms.Button btnMakeDbLighter;
        private System.Windows.Forms.Label lblServiceDuration;
        private System.Windows.Forms.NumericUpDown txtServiceDuration;
        private System.Windows.Forms.Label lblServiceDurationRecommend;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbChangeMarketInfoServiceStatus;
    }
}