using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Beams.xamaX;
using System.IO;
using System.Drawing.Imaging;

namespace Beams.WhatsAppEx.IDSender
{
    public partial class frmRegisterIDSender : Telerik.WinControls.UI.RadForm
    {
        public frmRegisterIDSender()
        {
            InitializeComponent();
        }
        private string _phonenumber;
        public string phonenumber
        {
            get
            {
                return _phonenumber;
            }
        }
        public string password = string.Empty;
        public string identity;

        public void SetNumber(string phonenumber)
        {
            _phonenumber = phonenumber;
            whatsAppIDSenderRadTextBox.Text = phonenumber;
        }

        private void btnOky_Click(object sender, EventArgs e)
        {
            _phonenumber = whatsAppIDSenderRadTextBox.Text;
            if (!string.IsNullOrEmpty(phonenumber))
            {
                identity = WhatsAppApi.Register.WhatsRegisterV2.GenerateIdentity(phonenumber);
                var method = "sms";
                var response = string.Empty;
                var requerst = string.Empty;
               // WhatsAppApi.Register.WhatsRegisterV2.RequestCode(phonenumber, out password,out requerst, out response, method,identity);


                if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(phonenumber, out password, out response, method, identity))
                {
                   
                    paskeyRadTextBox.Text = password;
                    if (paskeyRadTextBox.Text == string.Empty)
                    {
                        var reg2 = new frmVeryfy();
                        reg2.identity = identity;
                        reg2.phonenumber = whatsAppIDSenderRadTextBox.Text;
                        reg2.ShowDialog();
                       
                            paskeyRadTextBox.Text = reg2.password;
                            if (reg2.password!= null)
                            {
                                Application.DoEvents();
                                SaveIDSender();
                            }
                           
                       
                    }
                    else
                    {
                        SaveIDSender();
                    }
                }
                else
                {
                    RadMessageBox.ThemeName = ThemeName;
                    RadMessageBox.Show(String.Format("Could not request code:\r\n{0}", response));
                }
            }
        }

        private void SaveIDSender()
        {
            txtMsg.Text = "Saveing Id Sender Now ..  ";
            Application.DoEvents();
            SaveIDSenderToDataBase();
            txtMsg.Text = string.Empty;
            ClearTexBoxs();
            frmRegisterIDSender_Load(null, null);
            var counter = (int.Parse(Beams.SysUsers.LoginInfo.IdSenderCounter) + 1);
            Beams.SysUsers.LoginInfo.IdSenderCounter = counter.ToString();
            RadCounter.Text = string.Format("Register To Now {0}", counter);
            whatsAppIDSenderRadTextBox.Focus();
        }

        private void ClearTexBoxs()
        {
            foreach (Control item in radGroupBox1.Controls)
            {
                if (item is Telerik.WinControls.UI.RadTextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void SaveIDSenderToDataBase()
        {
            Cursor = Cursors.WaitCursor;

            var proxy = new XamaWhatsAppServiceSoapClient();
            byte[] img;
            var mo = new MemoryStream();
            try
            {
                whatsAppImgPictureBox.Image.Save(mo, ImageFormat.Png);
                img = mo.ToArray();
            }
            catch (System.NullReferenceException ex1)
            {
                img = null;
            }

            var AutoReply = autoReplayMsgRadTextBox.Text;
            var whatsStatus = whatsAppStatusRadTextBox.Text;
            var passkey = paskeyRadTextBox.Text;

            var id = new xamaX.IDSender()
            { AutoReplayMsg = AutoReply,
                IDSenderStatus = "Active",
                WhatsAppStatus = whatsStatus,
                WhatsAppIDSender = whatsAppIDSenderRadTextBox.Text,
                whatsAppImg = img,
                
                Paskey = passkey,
                User_ID = Beams.SysUsers.LoginInfo.UserID

            };

            if (proxy.IDSenderSave(id))
            {
                DevComponents.DotNetBar.ToastNotification.Show(this, "Saved Successfully", DevComponents.DotNetBar.eToastPosition.MiddleCenter);
            }
            Cursor = Cursors.Default;
        }

        private void whatsAppImgPictureBox_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            op.ShowDialog();
            whatsAppImgPictureBox.Image = Image.FromFile(op.FileName);
        }

        private void frmRegisterIDSender_Load(object sender, EventArgs e)
        {
        
            RadCounter.Text = string.Format("Register To Now {0}", Beams.SysUsers.LoginInfo.IdSenderCounter);

            foreach (var item in Beams.SysUsers.LoginInfo.permession)
            {
                if (item.SystemPermession.PermessionName == "AutoReplay")
                {
                    autoReplayMsgRadTextBox.Enabled = bool.Parse(item.PermessionValue);
                }
                if (item.SystemPermession.PermessionName == "Passkey")
                {
                    paskeyRadTextBox.Enabled = bool.Parse(item.PermessionValue);
                }
                if (item.SystemPermession.PermessionName == "WhatsAppStatusControl")
                {
                    whatsAppStatusRadTextBox.Enabled = bool.Parse(item.PermessionValue);
                }
                if (item.SystemPermession.PermessionName == "WhatsAppImg")
                {
                    whatsAppImgPictureBox.Visible = bool.Parse(item.PermessionValue);
                }
                if (item.SystemPermession.PermessionName == "WhatsAppStatusMessage")
                {
                    whatsAppStatusRadTextBox.Text  = (item.PermessionValue);
                    whatsAppStatusRadTextBox.Refresh();
                }
                if (item.SystemPermession.PermessionName == "AutoReplayMessage")
                {
                    autoReplayMsgRadTextBox.Text = (item.PermessionValue);
                    whatsAppStatusRadTextBox.Refresh();
                }
                if (item.SystemPermession.PermessionName == "ShowRegisterIDSender")
                {
                    if (item.PermessionValue == "False")
                    {
                        RadMessageBox.Show("You have't To Access This Form");
                        Close();
                    }
                }
            }
        }
    }
}
