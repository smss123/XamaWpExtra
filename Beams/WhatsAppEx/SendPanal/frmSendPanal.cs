using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Beams.xamaX;
using Beams.SysUsers;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
namespace Beams.WhatsAppEx.SendPanal
{
    public partial class frmSendPanal : Telerik.WinControls.UI.RadForm
    {
        private XamaWhatsAppServiceSoapClient proxy = new XamaWhatsAppServiceSoapClient();
        Thread th;
        public frmSendPanal()
        {
            InitializeComponent();
        }

        private void frmSendPanal_Load(object sender, EventArgs e)
        {
            th = new Thread(LoadIDSender);
            th.Start();
        }

        public void LoadIDSender()
        {
            Invoke((MethodInvoker)delegate {

                lblIDSender.Text = string.Format("[{0}]", "Loading from Server");
                lblReadyIDSender.Text = string.Format("[{0}]", "Loading from Server");
                lblFailedIDSender.Text = lblIDSender.Text = string.Format("[{0}]", "Loading from Server");
            });
           
            var q = proxy.LoadIDSenderToSend(LoginInfo.UserToken.ToString());

            Invoke((MethodInvoker)delegate
            {

                lblIDSender.Text = string.Format("[{0}]", q.Count.ToString());
                lblReadyIDSender.Text = string.Format("[{0}]", q.Count.ToString());
                lblFailedIDSender.Text = lblIDSender.Text = string.Format("[{0}]", 0);
            });
           

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private  void LoadPhoneNumber()
        {
            var op = new OpenFileDialog();
            StreamReader reader = null;
            var lst = new List<string>();
            this.Invoke((MethodInvoker)delegate
            {
                op.Title = "select file";
                op.ShowDialog();
                pgs.Text = "Loading Numbers ....";
                pgs.Value2 = 0;
                pgs.Maximum = 0;
                //pictureBox1.Visible = true;
                lblPhoneNumber.Text = "Please Wait..";
            });
            try
            {
                reader = new StreamReader(File.OpenRead(op.FileName));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    lst.Add(values[0]);
                }
                var t = Task.Factory.StartNew(() => this.Invoke((MethodInvoker)delegate
                {
                    lblPhoneNumber.Text = string.Empty;
                }));
                t.Wait();
            }
            catch (System.ArgumentException ex)
            {
                var t = Task.Factory.StartNew(() => this.Invoke((MethodInvoker)delegate
                {
                    RadMessageBox.ThemeName = this.ThemeName;
                  RadMessageBox.Show( ex.Message);
                }));
                t.Wait();
            }

            foreach (var item in lst)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pgs.Maximum = lst.Count;
                    lstPhoneNumber.Items.Add(item);
                    pgs.Value1 += 1;
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                //Status1.Text = "Number is Loaded compelete..";
                lblPhoneNumber.Text = lstPhoneNumber.Items.Count.ToString();
              //  pictureBox1.Visible = false;
            });
        }

        private void loadPhoneNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(this.LoadPhoneNumber);
            th.Start();
        }
    }
}
