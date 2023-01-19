namespace StockExchangeAlert.Forms
{
    partial class frmShowAllAlert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShowAlert = new System.Windows.Forms.DataGridView();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AlertType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activeDeactiveAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getOnlinePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.goToTsetmcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToCodalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAlert)).BeginInit();
            this.cmsRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowAlert
            // 
            this.dgvShowAlert.AllowUserToAddRows = false;
            this.dgvShowAlert.AllowUserToDeleteRows = false;
            this.dgvShowAlert.AllowUserToResizeColumns = false;
            this.dgvShowAlert.AllowUserToResizeRows = false;
            this.dgvShowAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvShowAlert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.dgvShowAlert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowAlert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShowAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAlert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockName,
            this.AlertPrice,
            this.Status,
            this.AlertType});
            this.dgvShowAlert.ContextMenuStrip = this.cmsRightClick;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowAlert.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvShowAlert.EnableHeadersVisualStyles = false;
            this.dgvShowAlert.Location = new System.Drawing.Point(33, 68);
            this.dgvShowAlert.MultiSelect = false;
            this.dgvShowAlert.Name = "dgvShowAlert";
            this.dgvShowAlert.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowAlert.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvShowAlert.RowHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgvShowAlert.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvShowAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowAlert.Size = new System.Drawing.Size(597, 341);
            this.dgvShowAlert.TabIndex = 3;
            this.dgvShowAlert.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowAlert_CellMouseDown);
            // 
            // StockName
            // 
            this.StockName.DataPropertyName = "StockName";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.StockName.DefaultCellStyle = dataGridViewCellStyle9;
            this.StockName.HeaderText = "Stock Name";
            this.StockName.Name = "StockName";
            this.StockName.ReadOnly = true;
            this.StockName.Width = 150;
            // 
            // AlertPrice
            // 
            this.AlertPrice.DataPropertyName = "AlertPrice";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.AlertPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.AlertPrice.HeaderText = "Alert Price";
            this.AlertPrice.Name = "AlertPrice";
            this.AlertPrice.ReadOnly = true;
            this.AlertPrice.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AlertType
            // 
            this.AlertType.DataPropertyName = "AlertType";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AlertType.DefaultCellStyle = dataGridViewCellStyle11;
            this.AlertType.HeaderText = "Alert Type";
            this.AlertType.Name = "AlertType";
            this.AlertType.ReadOnly = true;
            // 
            // cmsRightClick
            // 
            this.cmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.changePriceToolStripMenuItem,
            this.toolStripSeparator2,
            this.activeDeactiveAlertToolStripMenuItem,
            this.getOnlinePriceToolStripMenuItem,
            this.toolStripSeparator3,
            this.goToTsetmcToolStripMenuItem,
            this.goToCodalToolStripMenuItem});
            this.cmsRightClick.Name = "contextMenuStrip1";
            this.cmsRightClick.Size = new System.Drawing.Size(186, 148);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::TSEAlert.Properties.Resources.dustbin;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.removeToolStripMenuItem.Text = "Remove Alert";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // changePriceToolStripMenuItem
            // 
            this.changePriceToolStripMenuItem.Image = global::TSEAlert.Properties.Resources.tag;
            this.changePriceToolStripMenuItem.Name = "changePriceToolStripMenuItem";
            this.changePriceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changePriceToolStripMenuItem.Text = "Change Price";
            this.changePriceToolStripMenuItem.Click += new System.EventHandler(this.changePriceToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // activeDeactiveAlertToolStripMenuItem
            // 
            this.activeDeactiveAlertToolStripMenuItem.Image = global::TSEAlert.Properties.Resources.exchange;
            this.activeDeactiveAlertToolStripMenuItem.Name = "activeDeactiveAlertToolStripMenuItem";
            this.activeDeactiveAlertToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.activeDeactiveAlertToolStripMenuItem.Text = "Active/Deactive Alert";
            this.activeDeactiveAlertToolStripMenuItem.Click += new System.EventHandler(this.activeDeactiveAlertToolStripMenuItem_Click);
            // 
            // getOnlinePriceToolStripMenuItem
            // 
            this.getOnlinePriceToolStripMenuItem.Image = global::TSEAlert.Properties.Resources.online;
            this.getOnlinePriceToolStripMenuItem.Name = "getOnlinePriceToolStripMenuItem";
            this.getOnlinePriceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.getOnlinePriceToolStripMenuItem.Text = "Get Online Price";
            this.getOnlinePriceToolStripMenuItem.Click += new System.EventHandler(this.getOnlinePriceToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // goToTsetmcToolStripMenuItem
            // 
            this.goToTsetmcToolStripMenuItem.Image = global::TSEAlert.Properties.Resources.TSETMC_300x300_1;
            this.goToTsetmcToolStripMenuItem.Name = "goToTsetmcToolStripMenuItem";
            this.goToTsetmcToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.goToTsetmcToolStripMenuItem.Text = "Go to TSETMC";
            this.goToTsetmcToolStripMenuItem.Click += new System.EventHandler(this.goToTsetmcToolStripMenuItem_Click);
            // 
            // goToCodalToolStripMenuItem
            // 
            this.goToCodalToolStripMenuItem.Image = global::TSEAlert.Properties.Resources.Codal;
            this.goToCodalToolStripMenuItem.Name = "goToCodalToolStripMenuItem";
            this.goToCodalToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.goToCodalToolStripMenuItem.Text = "Go to Codal";
            this.goToCodalToolStripMenuItem.Click += new System.EventHandler(this.goToCodalToolStripMenuItem_Click);
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
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(51, 418);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // frmShowAllAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvShowAlert);
            this.Controls.Add(this.btnClose);
            this.MinimumSize = new System.Drawing.Size(664, 450);
            this.Name = "frmShowAllAlert";
            this.Text = "frmShowAllAlert";
            this.Load += new System.EventHandler(this.frmShowAllAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAlert)).EndInit();
            this.cmsRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.DataGridView dgvShowAlert;
        private System.Windows.Forms.ContextMenuStrip cmsRightClick;
        private System.Windows.Forms.ToolStripMenuItem activeDeactiveAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getOnlinePriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem goToTsetmcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToCodalToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
    }
}