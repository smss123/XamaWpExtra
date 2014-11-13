using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using Xprema;

namespace ExtraWhatsApp.WhatsApp
{
    public class _Command_IDSender
    {
        public _Command_IDSender()
        {
        }

        public bool Save(IDSender Sender)
        {
            try
            {
                var db = new dbDataContext();
                db.IDSenders.InsertOnSubmit(Sender);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e )
            {
                var ex = new XpremaException();
                ex.CodeNumber = 0;
                ex.UserDescription = "error in Save ID Sender";
                ex.UserDescriptionArabic = " حدث خطأ اثناء علمية الحفظ ";
                ex.XpremaMessage = e.ToString();
                ex.OtherDescription = e.Message;
                throw ex;
            }
        }

        public List<IDSender> GetAll()
        {
            var db = new dbDataContext();
            db.DeferredLoadingEnabled = false;
            return db.IDSenders.ToList();
        }


        public List<IDSender> LoadIDSenderToSend(string UserToken )
        {
            try
            {
                var db = new dbDataContext();
                var q = db.IDSenders.Where(p => p.SystemUser.UserToken == UserToken && p.IDSenderStatus=="Active").ToList();
                List<IDSender> ls = new List<IDSender>();
                foreach (var item in q)
                {
                    ls.Add(new IDSender() { ID = item.ID, WhatsAppIDSender = item.WhatsAppIDSender, Paskey = item.Paskey }); 
                }
                return ls;
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
    }
}
