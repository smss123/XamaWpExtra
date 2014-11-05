using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;

namespace ExtraWhatsApp.Security
{
    public  class WhatsAppUser
    {
        private dbDataContext db = new dbDataContext();
        public WhatsAppUser()
        {
            MemberwiseClone();
        }

        public SystemUser Login(string user, string pwd)
        {
            try
            {
                var q = db.SystemUsers.Where(p => p.UserName == user && p.Password == pwd).SingleOrDefault();
                if (q != null)
                {
                    var u = new SystemUser();
                    u.UserName = q.UserName;
                    u.UserToken = q.UserToken;
                    u.ID = q.ID;
                    u.Person = null;
                    return q;
                }
                else
                {
                    var u = new SystemUser();
                    u.UserName = "This User Not Found";
                    u.Password = "This User Not Found";
                    return u;
                }
            }
            catch (Exception e)
            {
                var u = new SystemUser();
                u.UserName = e.Message;
                u.Password = e.Message;
                return u;
            }
        }

        public  List<UserPermession> GetUserPermession(string UserToken)
        {
            db = new dbDataContext();
            var q = db.UserPermessions.Where(p => p.SystemUser.UserToken == UserToken).ToList();
            foreach (var item in q)
            {
                item.SystemUser = null;
            }
            return q;
        }
    }
}
