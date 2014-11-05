using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using Xprema;

namespace ExtraWhatsApp
{
    public   class ServiceController
    {
        private dbDataContext db = new dbDataContext();
        public ServiceController()
        {
        }
        public string  ServiceMessage { get; set; }
        public bool GetServiceStatus()
        {
            var q = db.XSettings.Where(p => p.SettingName.Contains("ServiceStatus")).SingleOrDefault();
            if (q != null)
            {
                if (q.SettingValue.Contains("Stop"))
                {
                    return false;
                }
                else
                {
                    if (q.SettingValue.Contains("Start"))
                    {
                        return true ;
                    }
                    else
                    {
                        return false ;
                    }
                }
            }
            else
            {
                throw new XpremaException("Error in Get Status From Setting");
            }
        }

        public void startService()
        {
            if (!GetServiceStatus())
            {
                var q = db.XSettings.Where(p => p.SettingName.Contains("ServiceStatus")).SingleOrDefault();
                if (q != null)
                {
                    q.SettingValue = "Start";
                    db.SubmitChanges();
                }
            }
        }

        public string GetStatus()
        {
            var q = db.XSettings.Where(p => p.SettingName.Contains("ServiceStatus")).SingleOrDefault();
            if (q != null)
            {
                return q.SettingValue;
            }
            else
            {
                return "Error";
            }
        }

        public void  StopService()
        {
            if (GetServiceStatus())
            {
                var q = db.XSettings.Where(p => p.SettingName.Contains("ServiceStatus")).SingleOrDefault();
                if (q != null)
                {
                    q.SettingValue = "Stop";
                    db.SubmitChanges();
                }
            }
        }

        public void SetMessage(string msg)
        {
        }
    }
}
