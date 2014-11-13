namespace Beams
{
    partial class MainForm
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
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.txtServiceStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.pgs = new Telerik.WinControls.UI.RadProgressBarElement();
            this.txtServiceState = new Telerik.WinControls.UI.RadLabelElement();
            this.TxtUserLogin = new Telerik.WinControls.UI.RadLabelElement();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.btnRegisterIDSender = new Telerik.WinControls.UI.RadMenuItem();
            this.BtnEditIDSender = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManageIDSender = new Telerik.WinControls.UI.RadMenuItem();
            this.radOffice2007ScreenTipElement1 = new Telerik.WinControls.UI.RadOffice2007ScreenTipElement();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.btnPhoneNumberAdd = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManagePhoneNumber = new Telerik.WinControls.UI.RadMenuItem();
            this.btnPhoneNumberGroup = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManageGroup = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.BtnSendPanal = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.txtServiceStatus,
            this.pgs,
            this.txtServiceState,
            this.TxtUserLogin});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 342);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(516, 21);
            this.radStatusStrip1.TabIndex = 0;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2010Blue";
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.AccessibleDescription = "Checking Service Status";
            this.txtServiceStatus.AccessibleName = "Checking Service Status";
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.radStatusStrip1.SetSpring(this.txtServiceStatus, false);
            this.txtServiceStatus.Text = "Checking Service Status";
            this.txtServiceStatus.TextWrap = true;
            this.txtServiceStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // pgs
            // 
            this.pgs.GradientStyle = Telerik.WinControls.GradientStyles.Radial;
            this.pgs.Name = "pgs";
            this.pgs.SeparatorColor1 = System.Drawing.Color.White;
            this.pgs.SeparatorColor2 = System.Drawing.Color.White;
            this.pgs.SeparatorColor3 = System.Drawing.Color.White;
            this.pgs.SeparatorColor4 = System.Drawing.Color.White;
            this.pgs.SeparatorGradientAngle = 0;
            this.pgs.SeparatorGradientPercentage1 = 0.4F;
            this.pgs.SeparatorGradientPercentage2 = 0.6F;
            this.pgs.SeparatorNumberOfColors = 2;
            this.radStatusStrip1.SetSpring(this.pgs, false);
            this.pgs.StepWidth = 14;
            this.pgs.SweepAngle = 90;
            this.pgs.Value1 = 50;
            this.pgs.Value2 = 0;
            this.pgs.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // txtServiceState
            // 
            this.txtServiceState.AccessibleDescription = "radLabelElement1";
            this.txtServiceState.AccessibleName = "radLabelElement1";
            this.txtServiceState.Name = "txtServiceState";
            this.radStatusStrip1.SetSpring(this.txtServiceState, false);
            this.txtServiceState.Text = "radLabelElement1";
            this.txtServiceState.TextWrap = true;
            this.txtServiceState.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // TxtUserLogin
            // 
            this.TxtUserLogin.Name = "TxtUserLogin";
            this.radStatusStrip1.SetSpring(this.TxtUserLogin, false);
            this.TxtUserLogin.Text = "";
            this.TxtUserLogin.TextWrap = true;
            this.TxtUserLogin.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "ID Sender";
            this.radMenuItem1.AccessibleName = "ID Sender";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnRegisterIDSender,
            this.BtnEditIDSender,
            this.btnManageIDSender});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "ID Sender";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnRegisterIDSender
            // 
            this.btnRegisterIDSender.AccessibleDescription = "Register ID Sender";
            this.btnRegisterIDSender.AccessibleName = "Register ID Sender";
            this.btnRegisterIDSender.Name = "btnRegisterIDSender";
            this.btnRegisterIDSender.Text = "Register ID Sender";
            this.btnRegisterIDSender.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRegisterIDSender.Click += new System.EventHandler(this.btnRegisterIDSender_Click);
            // 
            // BtnEditIDSender
            // 
            this.BtnEditIDSender.AccessibleDescription = "radMenuItem2";
            this.BtnEditIDSender.AccessibleName = "radMenuItem2";
            this.BtnEditIDSender.Name = "BtnEditIDSender";
            this.BtnEditIDSender.Text = "Edit ID Sender";
            this.BtnEditIDSender.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.BtnEditIDSender.Click += new System.EventHandler(this.BtnEditIDSender_Click);
            // 
            // btnManageIDSender
            // 
            this.btnManageIDSender.AccessibleDescription = "Manage ID Sender";
            this.btnManageIDSender.AccessibleName = "Manage ID Sender";
            this.btnManageIDSender.Name = "btnManageIDSender";
            this.btnManageIDSender.Text = "Manage ID Sender";
            this.btnManageIDSender.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radOffice2007ScreenTipElement1
            // 
            this.radOffice2007ScreenTipElement1.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTipElement1.Name = "radOffice2007ScreenTipElement1";
            this.radOffice2007ScreenTipElement1.TemplateType = null;
            this.radOffice2007ScreenTipElement1.TipSize = new System.Drawing.Size(210, 50);
            this.radOffice2007ScreenTipElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "PhoneNumbers";
            this.radMenuItem2.AccessibleName = "PhoneNumbers";
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnPhoneNumberAdd,
            this.btnManagePhoneNumber,
            this.btnPhoneNumberGroup,
            this.btnManageGroup});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "PhoneNumbers";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnPhoneNumberAdd
            // 
            this.btnPhoneNumberAdd.AccessibleDescription = "Add Phone Number";
            this.btnPhoneNumberAdd.AccessibleName = "Add Phone Number";
            this.btnPhoneNumberAdd.Name = "btnPhoneNumberAdd";
            this.btnPhoneNumberAdd.Text = "Add Phone Number";
            this.btnPhoneNumberAdd.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnManagePhoneNumber
            // 
            this.btnManagePhoneNumber.AccessibleDescription = "Manage Phone Number";
            this.btnManagePhoneNumber.AccessibleName = "Manage Phone Number";
            this.btnManagePhoneNumber.Name = "btnManagePhoneNumber";
            this.btnManagePhoneNumber.Text = "Manage Phone Number";
            this.btnManagePhoneNumber.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnPhoneNumberGroup
            // 
            this.btnPhoneNumberGroup.AccessibleDescription = "Add Group";
            this.btnPhoneNumberGroup.AccessibleName = "Add Group";
            this.btnPhoneNumberGroup.Name = "btnPhoneNumberGroup";
            this.btnPhoneNumberGroup.Text = "Add Group";
            this.btnPhoneNumberGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnManageGroup
            // 
            this.btnManageGroup.AccessibleDescription = "Manage Group";
            this.btnManageGroup.AccessibleName = "Manage Group";
            this.btnManageGroup.Name = "btnManageGroup";
            this.btnManageGroup.Text = "Manage Group";
            this.btnManageGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.BtnSendPanal});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(516, 21);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "Office2010Blue";
            // 
            // BtnSendPanal
            // 
            this.BtnSendPanal.AccessibleDescription = "Send Panal";
            this.BtnSendPanal.AccessibleName = "Send Panal";
            this.BtnSendPanal.Name = "BtnSendPanal";
            this.BtnSendPanal.Text = "Send Panal";
            this.BtnSendPanal.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.BtnSendPanal.Click += new System.EventHandler(this.BtnSendPanal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 363);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra V1.0.0.0";
            this.ThemeName = "Office2010Blue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem btnRegisterIDSender;
        private Telerik.WinControls.UI.RadLabelElement txtServiceStatus;
        private Telerik.WinControls.UI.RadProgressBarElement pgs;
        private Telerik.WinControls.UI.RadOffice2007ScreenTipElement radOffice2007ScreenTipElement1;
        private Telerik.WinControls.UI.RadLabelElement txtServiceState;
        private Telerik.WinControls.UI.RadLabelElement TxtUserLogin;
        private Telerik.WinControls.UI.RadMenuItem BtnEditIDSender;
        private Telerik.WinControls.UI.RadMenuItem btnManageIDSender;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem btnPhoneNumberAdd;
        private Telerik.WinControls.UI.RadMenuItem btnManagePhoneNumber;
        private Telerik.WinControls.UI.RadMenuItem btnPhoneNumberGroup;
        private Telerik.WinControls.UI.RadMenuItem btnManageGroup;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem BtnSendPanal;

    }
}
