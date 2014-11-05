using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ExtraWhatsApp;
using DataLayer;
using ExtraWhatsApp.Security;
namespace ServiceXama
{
    /// <summary>
    /// Summary description for XamaWhatsAppService
    /// </summary>
    [WebService(Namespace = "http://xprema.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class XamaWhatsAppService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        #region "ServiceOperation"
        [WebMethod]
        public string GetServiceStatus()
        {

            ServiceController ser = new ServiceController();
            return ser.GetStatus();
        }

        [WebMethod]
        public void StartService()
        {
            ServiceController ser = new ServiceController();
            ser.startService();
        }

        [WebMethod]
        public void StopService()
        {
            ServiceController ser = new ServiceController();
            ser.StopService();
        }
        #endregion

        #region"User Managment"

        [WebMethod]
        public SystemUser Login(string user, string pwd)
        {
            WhatsAppUser wp = new WhatsAppUser();
            return wp.Login(user: user, pwd: pwd);
        }

        [WebMethod]
        public List<UserPermession> GetUserPermession(string userToken)
        {
            ExtraWhatsApp.Security.WhatsAppUser cmd = new WhatsAppUser();
         return cmd.GetUserPermession(UserToken: userToken);
        }
        #endregion

        #region "ID Sender "

        [WebMethod]
        public bool IDSenderSave(IDSender snd)
        {
            ExtraWhatsApp.WhatsApp._Command_IDSender cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.Save(snd);
        }

        [WebMethod]
        public List<IDSender> IDSenderGetAll()
        {
            ExtraWhatsApp.WhatsApp._Command_IDSender cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.GetAll();
        }

        [WebMethod]
        public int IDSender()
        {
            ExtraWhatsApp.WhatsApp._Command_IDSender cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.GetAll().Count;
        }

        #endregion

    }
}
