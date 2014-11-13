using System;
using System.Collections.Generic;
using System.Linq;
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
    public class XamaWhatsAppService : System.Web.Services.WebService
    {

        #region "Service"


        [WebMethod]
        public string GetServiceStatus()
        {
            var ser = new ServiceController();
            return ser.GetStatus();
        }

        [WebMethod]
        public void StartService()
        {
            var ser = new ServiceController();
            ser.startService();
        }

        [WebMethod]
        public void StopService()
        {
            var ser = new ServiceController();
            ser.StopService();
        }
        #endregion
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        #region"Users"

        [WebMethod]
        public SystemUser UserLogin(string user, string pwd)
        {
            var wp = new WhatsAppUser();
            return wp.Login(user: user, pwd: pwd);
        }

        [WebMethod]
        public List<UserPermession> GetUserPermession(string userToken)
        {
            var cmd = new WhatsAppUser();
            return cmd.GetUserPermession(UserToken: userToken);
        }
        
        
        #endregion


        #region "ID SENDER"

        [WebMethod]
        public bool IDSenderSave(IDSender snd)
        {
            var cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.Save(snd);
        }

        [WebMethod]
        public List<IDSender> IDSenderGetAll()
        {
            var cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.GetAll();
        }

        [WebMethod]
        public int IDSenderGetIDSenderCount()
        {
            var cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.GetAll().Count;
        }

         [WebMethod]
        public List<IDSender> LoadIDSenderToSend(string userToken)
        {
             var cmd = new ExtraWhatsApp.WhatsApp._Command_IDSender();
            return cmd.LoadIDSenderToSend(userToken);
           
        }

        #endregion

       
    }
}
