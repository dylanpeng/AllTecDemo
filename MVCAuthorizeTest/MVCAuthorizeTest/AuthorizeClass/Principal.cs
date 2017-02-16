using MVCAuthorizeTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace MVCAuthorizeTest
{
    public class Principal : IPrincipal
    {
        public IIdentity Identity { get; private set;}

        public UserData Account { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="account"></param>
        public Principal(FormsAuthenticationTicket ticket, UserData account)
        {
            if (ticket == null)
                throw new ArgumentNullException("ticket");
            if (account == null)
                throw new ArgumentNullException("UserData");

            this.Identity = new FormsIdentity(ticket);
            this.Account = account;
        }

        public bool IsInRole(string role)
        {
            if (string.IsNullOrEmpty(role))
                return true;
            if (this.Account == null || this.Account.Roles == null)
                return false;
            return role.Split(',').Any(q => Account.Roles.Contains(int.Parse(q)));
        }
    }
}