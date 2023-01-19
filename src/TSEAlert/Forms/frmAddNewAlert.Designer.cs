namespace StockExchangeAlert.Forms
{
    partial class frmAddNewAlert
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
            this.cmbSearchBox = new System.Windows.Forms.ComboBox();
            this.lblStockSelectedNotification = new System.Windows.Forms.Label();
            this.cmbAlertType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbSearchBox
            // 
            this.cmbSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.cmbSearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSearchBox.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSearchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbSearchBox.FormattingEnabled = true;
            this.cmbSearchBox.Location = new System.Drawing.Point(171, 92);
            this.cmbSearchBox.Name = "cmbSearchBox";
            this.cmbSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchBox.Size = new System.Drawing.Size(390, 28);
            this.cmbSearchBox.TabIndex = 3;
            this.cmbSearchBox.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBox_SelectedIndexChanged);
            this.cmbSearchBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbSearchBox_Format);
            this.cmbSearchBox.Enter += new System.EventHandler(this.cmbSearchBox_Enter);
            this.cmbSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSearchBox_KeyPress);
            // 
            // lblStockSelectedNotification
            // 
            this.lblStockSelectedNotification.AutoSize = true;
            this.lblStockSelectedNotification.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStockSelectedNotification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockSelectedNotification.Location = new System.Drawing.Point(245, 66);
            this.lblStockSelectedNotification.Name = "lblStockSelectedNotification";
            this.lblStockSelectedNotification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStockSelectedNotification.Size = new System.Drawing.Size(256, 23);
            this.lblStockSelectedNotification.TabIndex = 4;
            this.lblStockSelectedNotification.Text = "بعد از نوشتن اسم سهم، کلید Enter را بزنید.";
            // 
            // cmbAlertType
            // 
            this.cmbAlertType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.cmbAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlertType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAlertType.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbAlertType.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbAlertType.FormattingEnabled = true;
            this.cmbAlertType.Location = new System.Drawing.Point(412, 170);
            this.cmbAlertType.Name = "cmbAlertType";
            this.cmbAlertType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAlertType.Size = new System.Drawing.Size(149, 28);
            this.cmbAlertType.TabIndex = 5;
            this.cmbAlertType.SelectedIndexChanged += new System.EventHandler(this.cmbAlertType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(567, 171);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوع هشدار:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(567, 245);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "مقدار/قیمت:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.txtPrice.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Location = new System.Drawing.Point(412, 245);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(149, 27);
            this.txtPrice.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegister.IconColor = System.Drawing.Color.White;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(233, 318);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(212, 37);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(570, 95);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "جستجو:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(48, 384);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(215, 12);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status: Stock name is require.";
            // 
            // frmAddNewAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbAlertType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStockSelectedNotification);
            this.Controls.Add(this.cmbSearchBox);
            this.Controls.Add(this.btnClose);
            this.MinimumSize = new System.Drawing.Size(664, 450);
            this.Name = "frmAddNewAlert";
            this.Text = "frmAddNewAlert";
            this.Load += new System.EventHandler(this.frmAddNewAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.ComboBox cmbSearchBox;
        private System.Windows.Forms.Label lblStockSelectedNotification;
        private System.Windows.Forms.ComboBox cmbAlertType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private FontAwesome.Sharp.IconButton btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
    }
}