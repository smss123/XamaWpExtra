using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Beams
{
   public class PermessionManager
    {
       public PermessionManager() { }
       public static void ApplyPermession(  RadForm frm)
       {
           foreach (var prmession in Beams.SysUsers.LoginInfo.permession)
           {
               if (prmession.SystemPermession.PermessionDescription.Contains("TextBox"))
               {
                   foreach (var item in frm.Controls)
                   {
                       if (item is RadGroupBox)
                       {
                           foreach (var cntrl in ((RadGroupBox)item).Controls)
                           {
                                if (item is RadTextBox)
                                {
                                     ((RadTextBox)item).Enabled = bool.Parse(prmession.PermessionValue);
                                }
                           }
                       }
                   }
               }
           }
       }

       internal static void ApplyPermession(Control.ControlCollection controlCollection)
       {
           foreach (var prmession in Beams.SysUsers.LoginInfo.permession)
           {
               if (prmession.SystemPermession.PermessionDescription.Contains("TextBox"))
               {
                   foreach (var item in controlCollection)
                   {
                       if (item is RadGroupBox)
                       {
                           foreach (var cntrl in ((RadGroupBox)item).Controls)
                           {
                               if (item is RadTextBox)
                               {
                                   ((RadTextBox)item).Enabled = bool.Parse(prmession.PermessionValue);
                               }
                           }
                       }
                   }
               }
           }
       }
    }
}
