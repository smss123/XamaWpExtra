using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Beams.XamaService;
using System.IO;
using System.Drawing.Imaging;
using Telerik.WinControls.UI;
namespace Beams.WhatsAppEx.IDSender
{
    public partial class frmRegisterIDSender : Telerik.WinControls.UI.RadForm
    {
        public frmRegisterIDSender()
        {
            InitializeComponent();
        }


        private string[] methods = { "sms", "voice" };
        private string _phonenumber;
        public string phonenumber
        {
            get
            {
                return this._phonenumber;
            }
        }
        public string password = string.Empty;
        public string identity;

        public void SetNumber(string phonenumber)
        {
            this._phonenumber = phonenumber;
            this.whatsAppIDSenderRadTextBox.Text = phonenumber;
        }

        private void btnOky_Click(object sender, EventArgs e)
        {


            this._phonenumber = this.whatsAppIDSenderRadTextBox.Text;
            if (!string.IsNullOrEmpty(this.phonenumber))
            {

                this.identity = WhatsAppApi.Register.WhatsRegisterV2.GenerateIdentity(this.phonenumber);
                string method = "sms";
                string response = string.Empty;
                if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(this.phonenumber, out this.password, out response, method, this.identity))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    paskeyRadTextBox.Text = this.password;
                    if (paskeyRadTextBox.Text == "")
                    {
                        frmVeryfy reg2 = new frmVeryfy();
                        reg2.identity = this.identity;
                        reg2.phonenumber = whatsAppIDSenderRadTextBox.Text;

                        if (reg2.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(reg2.password))
                        {

                            paskeyRadTextBox.Text = reg2.password;

                            Application.DoEvents();
                            //success!
                            SaveIDSender();
                        }//end if show veryfy form
                    }//end if check if password not found
                    else
                    {
                        SaveIDSender();
                    }
                }//end if request code
                else
                {
                    RadMessageBox.ThemeName = this.ThemeName;
                    RadMessageBox.Show(String.Format("Could not request code:\r\n{0}", response));
                }

            }// if  phone number not found







          
          
        }

        private void SaveIDSender()
        {
            
            txtMsg.Text = "Saveing Id Sender Now ..  ";
            Application.DoEvents();
            SaveIDSenderToDataBase();
            txtMsg.Text = "";
            ClearTexBoxs();
            frmRegisterIDSender_Load(null, null);
            int counter = (int.Parse(Beams.SysUsers.LoginInfo.IdSenderCounter) + 1);
            Beams.SysUsers.LoginInfo.IdSenderCounter = counter.ToString();
            RadCounter.Text = string.Format("Register To Now {0}", counter);
            whatsAppIDSenderRadTextBox.Focus();
        }

        private void ClearTexBoxs()
        {
            foreach (Control item in this.radGroupBox1.Controls)
            {
                if (item is Telerik.WinControls.UI.RadTextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void SaveIDSenderToDataBase()
        {
            
            this.Cursor = Cursors.WaitCursor;

            XamaWhatsAppServiceSoapClient proxy = new XamaWhatsAppServiceSoapClient();
            byte[] img;
            MemoryStream mo = new MemoryStream();
            try
            {
                whatsAppImgPictureBox.Image.Save(mo, ImageFormat.Png);
                img = mo.ToArray();
            }
            catch (System.NullReferenceException ex1)
            {

                //RadMessageBox.ThemeName = this.ThemeName;
                //RadMessageBox.Show(ex1.Message , "Error in Saved Picture",MessageBoxButtons.OK,null);
                img = null;
            }

            string AutoReply = autoReplayMsgRadTextBox.Text;
            string whatsStatus = whatsAppStatusRadTextBox.Text;
            string passkey = paskeyRadTextBox.Text;

            XamaService.IDSender id = new XamaService.IDSender()
            {
                AutoReplayMsg = AutoReply,
                IDSenderStatus = "Active",
                WhatsAppStatus = whatsStatus,
                WhatsAppIDSender = whatsAppIDSenderRadTextBox.Text,
                whatsAppImg = img,
                Company = null,
                Paskey = passkey,
                User_ID = Beams.SysUsers.LoginInfo.UserID

            };

            if (proxy.IDSenderSave(id))
            {

                DevComponents.DotNetBar.ToastNotification.Show(this, "Saved Successfully", DevComponents.DotNetBar.eToastPosition.MiddleCenter);
            }
            this.Cursor = Cursors.Default;
           
        }

        private void whatsAppImgPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            whatsAppImgPictureBox.Image = Image.FromFile(op.FileName);
           
        }

        private void frmRegisterIDSender_Load(object sender, EventArgs e)
        {
            PermessionManager.ApplyPermession(this);
            RadCounter.Text = string.Format("Register To Now {0}", Beams.SysUsers.LoginInfo.IdSenderCounter);

            ////WhatsAppStatusControl
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
                //AutoReplayMessage
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
                        this.Close();
                    }
                }
            }
        }
    }
}
