using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Beams.WhatsAppEx.IDSender
{
    public partial class frmVeryfy : Telerik.WinControls.UI.RadForm
    {
        public frmVeryfy()
        {
            InitializeComponent();
        }
        public string password;
        public string phonenumber;
        public string identity;

        private void frmVeryfy_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtAcitvationCode.Text) && this.txtAcitvationCode.Text.Length == 6)
            {
                try
                {
                    this.password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(this.phonenumber, this.txtAcitvationCode.Text, this.identity);
                    if (!string.IsNullOrEmpty(this.password))
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Verification code not accepted");
                    }
                }
                catch (Exception ex)
                {

                    RadMessageBox.ThemeName = this.ThemeName;
                    RadMessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
