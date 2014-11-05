using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
namespace ExtraWhatsApp.Security
{
   public  class WhatsAppUser
    {
       private dbDataContext db = new dbDataContext();
       public WhatsAppUser()
       {
           this.MemberwiseClone();
       }

       public SystemUser Login(string user,string pwd)
       {
           try
           {
               
                var q = db.SystemUsers.Where(p => p.UserName == user && p.Password == pwd).SingleOrDefault();
                if (q != null)
                {
                    SystemUser u = new SystemUser();
                    u.UserName = q.UserName;
                    u.UserToken = q.UserToken;
                    u.ID = q.ID;
                    u.Person = null; //new Person() { PersonName = q.Person.PersonName };
                    //return u;
                    return q;
                }
                else
                {
                    SystemUser u = new SystemUser();
                    u.UserName = "This User Not Found";
                    u.Password = "This User Not Found";
                    return u;
                }
           }
           catch (Exception e)
           {

               SystemUser u = new SystemUser();
               u.UserName = e.Message;
               u.Password = e.Message;
               return u;
           }
       }

       public  List<UserPermession> GetUserPermession(string UserToken)
       {
           db = new dbDataContext();
           //db.DeferredLoadingEnabled = false;
           //db.ObjectTrackingEnabled = false;
          // var q = db.SystemUsers.Where(p => p.UserToken == UserToken).SingleOrDefault();
           var q = db.UserPermessions.Where(p => p.SystemUser.UserToken == UserToken).ToList();
           foreach (var item in q)
           {
               item.SystemUser = null;
              // item.SystemPermession = null;
               
           }
           return q;//q.UserPermessions.ToList();
       }

    }
}
