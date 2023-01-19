
namespace TSEAlert.Forms
{
    partial class frmActivatedAlerts
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
            this.lbAlertMessages = new System.Windows.Forms.ListBox();
            this.btnClearList = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAlertMessages
            // 
            this.lbAlertMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.lbAlertMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAlertMessages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbAlertMessages.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAlertMessages.ForeColor = System.Drawing.Color.White;
            this.lbAlertMessages.FormattingEnabled = true;
            this.lbAlertMessages.HorizontalScrollbar = true;
            this.lbAlertMessages.ItemHeight = 20;
            this.lbAlertMessages.Items.AddRange(new object[] {
            "- هشدار کمتر شدن سهم غکورش از قیمت 1100 فعال شده است (تاریخ 1401/10/28)"});
            this.lbAlertMessages.Location = new System.Drawing.Point(30, 52);
            this.lbAlertMessages.Name = "lbAlertMessages";
            this.lbAlertMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbAlertMessages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbAlertMessages.Size = new System.Drawing.Size(544, 300);
            this.lbAlertMessages.TabIndex = 0;
            this.lbAlertMessages.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbAlertMessages_DrawItem);
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearList.FlatAppearance.BorderSize = 0;
            this.btnClearList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnClearList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearList.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClearList.IconColor = System.Drawing.Color.White;
            this.btnClearList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearList.IconSize = 25;
            this.btnClearList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearList.Location = new System.Drawing.Point(245, 358);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(150, 37);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Snow;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(620, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(61, 408);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // frmActivatedAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbAlertMessages);
            this.Name = "frmActivatedAlerts";
            this.Text = "frmModernPanel";
            this.Load += new System.EventHandler(this.frmActivatedAlerts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlertMessages;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconButton btnClearList;
        private System.Windows.Forms.Label lblStatus;
    }
}