namespace Beams.WhatsAppEx.IDSender
{
    partial class frmEdit_IDSender
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnOky = new Telerik.WinControls.UI.RadButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reActivateNotAothoraizedNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBlockedNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.radGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.FieldName = "ID";
            gridViewTextBoxColumn7.HeaderImage = global::Beams.Properties.Resources.ic_lock_idle_low_battery;
            gridViewTextBoxColumn7.HeaderText = "ID";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            gridViewTextBoxColumn7.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gridViewTextBoxColumn7.Name = "ColID";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            gridViewTextBoxColumn7.Width = 105;
            gridViewTextBoxColumn8.FieldName = "WhatsAppIDSender";
            gridViewTextBoxColumn8.HeaderText = "ID Sender";
            gridViewTextBoxColumn8.Name = "ColIDSender";
            gridViewTextBoxColumn8.Width = 179;
            gridViewTextBoxColumn9.FieldName = "Paskey";
            gridViewTextBoxColumn9.HeaderText = "Passkey";
            gridViewTextBoxColumn9.Name = "ColPasskey";
            gridViewTextBoxColumn9.Width = 160;
            gridViewTextBoxColumn10.FieldName = "WhatsAppStatus";
            gridViewTextBoxColumn10.HeaderText = "WhatsAppStatus";
            gridViewTextBoxColumn10.Name = "ColWhatsAppStatus";
            gridViewTextBoxColumn10.Width = 217;
            gridViewTextBoxColumn11.FieldName = "AutoReplayMsg";
            gridViewTextBoxColumn11.HeaderText = "AutoReplaymessage";
            gridViewTextBoxColumn11.Name = "ColAutoReplaymessage";
            gridViewTextBoxColumn11.Width = 119;
            gridViewTextBoxColumn12.FieldName = "IDSenderStatus";
            gridViewTextBoxColumn12.HeaderText = "Status";
            gridViewTextBoxColumn12.Name = "ColStatus";
            gridViewTextBoxColumn12.Width = 44;
            gridViewCommandColumn2.DefaultText = "Edit";
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Name = "ColOk";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 48;
            gridViewCommandColumn2.WrapText = true;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewCommandColumn2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(887, 424);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Office2010Blue";
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            // 
            // btnOky
            // 
            this.btnOky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOky.Location = new System.Drawing.Point(789, 443);
            this.btnOky.Name = "btnOky";
            this.btnOky.Size = new System.Drawing.Size(110, 40);
            this.btnOky.TabIndex = 1;
            this.btnOky.Text = "Ok";
            this.btnOky.ThemeName = "Office2010Blue";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reActivateNotAothoraizedNumbersToolStripMenuItem,
            this.deleteBlockedNumbersToolStripMenuItem,
            this.checkNumbersToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(273, 92);
            // 
            // reActivateNotAothoraizedNumbersToolStripMenuItem
            // 
            this.reActivateNotAothoraizedNumbersToolStripMenuItem.Name = "reActivateNotAothoraizedNumbersToolStripMenuItem";
            this.reActivateNotAothoraizedNumbersToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.reActivateNotAothoraizedNumbersToolStripMenuItem.Text = "ReActivate Not Aothoraized Numbers";
            // 
            // deleteBlockedNumbersToolStripMenuItem
            // 
            this.deleteBlockedNumbersToolStripMenuItem.Name = "deleteBlockedNumbersToolStripMenuItem";
            this.deleteBlockedNumbersToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.deleteBlockedNumbersToolStripMenuItem.Text = "Delete Blocked Numbers";
            // 
            // checkNumbersToolStripMenuItem
            // 
            this.checkNumbersToolStripMenuItem.Name = "checkNumbersToolStripMenuItem";
            this.checkNumbersToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.checkNumbersToolStripMenuItem.Text = "Check Numbers";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // frmEdit_IDSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 495);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnOky);
            this.Controls.Add(this.radGridView1);
            this.Name = "frmEdit_IDSender";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit ID Sender";
            this.ThemeName = "Office2010Blue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEdit_IDSender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnOky;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reActivateNotAothoraizedNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBlockedNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}
