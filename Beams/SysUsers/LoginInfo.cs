using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Beams.XamaService;
namespace Beams.SysUsers
{
  internal class LoginInfo
    {
        public static string  UserName { get; set; }
        public static string   UserToken { get; set; }
        public static string  FullName { get; set; }
        public static int UserID;
        public static List<UserPermession> permession = new List<UserPermession>();
        public static string  IdSenderCounter { get; set; }
    }
}
