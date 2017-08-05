using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Information
    {
      public   List<Account> Accounts;

        public Information()
        {
            Accounts = new List<Account>();
            Accounts.Add(new Account { Id = 4, Name = "anin ", Age = 6 });
            Accounts.Add(new Account { Id = 1, Name = "putong ", Age = 6 });
            Accounts.Add(new Account { Id = 3, Name = "johannes ", Age = 6 });
            Accounts.Add(new Account { Id = 2, Name = "guay ", Age = 6 });
        }
    }
}