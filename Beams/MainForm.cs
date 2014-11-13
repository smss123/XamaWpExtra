using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Beams.xamaX;
using System.Threading;
using Beams.WhatsAppEx.SendPanal;

namespace Beams
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private XamaWhatsAppServiceSoapClient proxy = new XamaWhatsAppServiceSoapClient();
        private Thread th;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            th = new Thread(() =>
            {

                BeginInvoke((MethodInvoker)delegate
                {
                    pgs.Value1 = 50;
                    txtServiceState.Text = proxy.InnerChannel.State.ToString();
                    Cursor = Cursors.WaitCursor;
                    txtServiceStatus.Text = proxy.GetServiceStatus();
                    Cursor = Cursors.Default;
                    pgs.Value1 = 100;
                });
            });
            th.Start();
        }

        private void btnRegisterIDSender_Click(object sender, EventArgs e)
        {
            var frm = new WhatsAppEx.IDSender.frmRegisterIDSender();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TxtUserLogin.Text = SysUsers.LoginInfo.UserName + "/" + SysUsers.LoginInfo.UserToken;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEditIDSender_Click(object sender, EventArgs e)
        {
            var frm = new WhatsAppEx.IDSender.frmEdit_IDSender();
            frm.ShowDialog();
        }

        private void BtnSendPanal_Click(object sender, EventArgs e)
        {
            frmSendPanal frm = new frmSendPanal();
            frm.ShowDialog();
 
        }
    }
}
