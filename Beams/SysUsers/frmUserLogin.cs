using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

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
            if (txtUserName.Text=="")
            {
                errorProvider1.SetError(txtUserName, "Please Enter User Name");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Please Enter Password");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            frmLoading frm = new frmLoading();
            frm.txtUserName = txtUserName.Text;
            frm.txtPassword = txtPassword.Text;
            frm.ShowDialog();
            this.Hide();
        }
    }
}
