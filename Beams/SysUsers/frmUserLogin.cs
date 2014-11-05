using System;
using System.Collections.Generic;

namespace Beams.SysUsers
{
    public partial class frmUserLogin : Telerik.WinControls.UI.RadForm
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                errorProvider1.SetError(txtUserName, "Please Enter User Name");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Please Enter Password");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            var frm = new frmLoading();
            frm.txtUserName = txtUserName.Text;
            frm.txtPassword = txtPassword.Text;
            frm.ShowDialog();
            Hide();
        }
    }
}
