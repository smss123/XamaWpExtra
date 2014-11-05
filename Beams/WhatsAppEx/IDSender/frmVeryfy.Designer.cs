namespace Beams.WhatsAppEx.IDSender
{
    partial class frmVeryfy
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
            this.txtAcitvationCode = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcitvationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAcitvationCode
            // 
            this.txtAcitvationCode.Location = new System.Drawing.Point(81, 48);
            this.txtAcitvationCode.Name = "txtAcitvationCode";
            this.txtAcitvationCode.NullText = "Enter Activation Code Here";
            this.txtAcitvationCode.Size = new System.Drawing.Size(200, 20);
            this.txtAcitvationCode.TabIndex = 0;
            this.txtAcitvationCode.ThemeName = "Office2010Blue";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(239, 96);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(103, 44);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Ok";
            this.radButton1.ThemeName = "Office2010Blue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // frmVeryfy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 147);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtAcitvationCode);
            this.Name = "frmVeryfy";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veryfy";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.frmVeryfy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAcitvationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtAcitvationCode;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
