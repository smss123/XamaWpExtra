using System;
using System.Collections.Generic;
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
            if (!String.IsNullOrEmpty(txtAcitvationCode.Text) && txtAcitvationCode.Text.Length == 6)
            {
                try
                {
                    password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(phonenumber, txtAcitvationCode.Text, identity);
                    if (!string.IsNullOrEmpty(password))
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Verification code not accepted");
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.ThemeName = ThemeName;
                    RadMessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
