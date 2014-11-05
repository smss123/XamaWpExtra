using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using Xprema;
namespace ExtraWhatsApp.WhatsApp
{
   public class _Command_IDSender
    {
       public _Command_IDSender() { }

       public bool Save(IDSender Sender)
       {
           try
           {
                dbDataContext db = new dbDataContext();
                db.IDSenders.InsertOnSubmit(Sender);
                db.SubmitChanges();
                return true;
           }
           catch (Exception e )
           {

               XpremaException ex = new XpremaException();
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
           dbDataContext db = new dbDataContext();
           db.DeferredLoadingEnabled = false;
           return db.IDSenders.ToList();
       }
    }
}
