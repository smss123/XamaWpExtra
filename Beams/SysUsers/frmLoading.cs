using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Beams.SysUsers
{
    public partial class frmLoading : Telerik.WinControls.UI.RadForm
    {
        public string  txtUserName { get; set; }
        public string  txtPassword { get; set; }
        public string  LoginCaption { get; set; }
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
        }
        public void Dowork()
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {


                    Cursor = Cursors.WaitCursor;
                    Application.DoEvents();
                    radProgressBar1.Value2 = 30;
                    radProgressBar1.Text = "Connecting..";
                });

                var proxy = new XamaService.XamaWhatsAppServiceSoapClient();

                Invoke((MethodInvoker)delegate
                {


                    radProgressBar1.Value1 = 30;
                    radProgressBar1.Value2 = 60;
                    radProgressBar1.Text = "Loging Npw ..";

                });
                var q = proxy.Login(txtUserName, txtPassword);

                Invoke((MethodInvoker)delegate
                {


                    radProgressBar1.Value1 = 60;
                    radProgressBar1.Value2 = 90;
                    Cursor = Cursors.Default;

                });


                if (q != null)
                {
                    if (q.UserName == "This User Not Found")
                    {
                        LoginCaption = "Login";
                        RadMessageBox.ThemeName = ThemeName;
                        RadMessageBox.Show(q.UserName, "Can't Login");
                        return;
                    }
                    LoginInfo.UserName = q.UserName;
                    LoginInfo.UserToken = q.UserToken;
                    LoginInfo.UserID = q.ID;

                    Invoke((MethodInvoker)delegate
                    {


                        radProgressBar1.Value1 = 90;
                        radProgressBar1.Value2 = 100;
                        radProgressBar1.Text = "Loading Permession Now ..";

                    });
                    LoginInfo.permession = proxy.GetUserPermession(q.UserToken);
                    LoginInfo.IdSenderCounter = proxy.IDSenderGetAll().Count.ToString();
                    var frm = new MainForm();

                    frm.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.ToastNotification.DefaultToastGlowColor = DevComponents.DotNetBar.eToastGlowColor.Red;
                DevComponents.DotNetBar.ToastNotification.Show(this, ex.Message, DevComponents.DotNetBar.eToastPosition.MiddleCenter);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Dowork();
        }

        private void frmLoading_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
