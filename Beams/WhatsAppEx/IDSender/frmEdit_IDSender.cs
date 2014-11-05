using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Beams.XamaService;
namespace Beams.WhatsAppEx.IDSender
{
    public partial class frmEdit_IDSender : Telerik.WinControls.UI.RadForm
    {
        public frmEdit_IDSender()
        {
            InitializeComponent();
        }

        private void frmEdit_IDSender_Load(object sender, EventArgs e)
        {
            foreach (var item in Beams.SysUsers.LoginInfo.permession)
            {
                if (item.SystemPermession.PermessionName == "ShowEditIDSender")
                {
                    if (item.PermessionValue == "False")
                    {
                        RadMessageBox.Show("You have't To Access This Form");
                        this.Close();
                    }
                }
            }
            this.Cursor = Cursors.WaitCursor;
            
            try
            {
                XamaWhatsAppServiceSoapClient proxy = new XamaWhatsAppServiceSoapClient();
                List<XamaService.IDSender> ls = proxy.IDSenderGetAll();
                radGridView1.DataSource = ls   ;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.Cursor = Cursors.Default;
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Beams.XamaService.IDSender idx = (Beams.XamaService.IDSender)radGridView1.Rows[e.RowIndex].DataBoundItem;
                frmEdit_IDSender_Details frm = new frmEdit_IDSender_Details();
                frm.whatsAppIDSenderRadTextBox.Text = idx.WhatsAppIDSender;
                frm.paskeyRadTextBox.Text = idx.Paskey;
                frm.whatsAppStatusRadTextBox.Text = idx.WhatsAppStatus;
                frm.autoReplayMsgRadTextBox.Text  = idx.AutoReplayMsg;
                frm.IdSenderStatus.Text = idx.IDSenderStatus;
               
                try
                {
                    System.IO.MemoryStream mo = new System.IO.MemoryStream(idx.whatsAppImg);
                    Image img = Image.FromStream(mo);
                    frm.whatsAppImgPictureBox.Image = img;
              
                }
                catch (System.ArgumentNullException ex1)
                {
                    
                    
                }
                 
                frm.ShowDialog();
            }
        }
    }
}
