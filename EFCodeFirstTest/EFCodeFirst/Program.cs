using EFCodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new AccountUser()
                {
                    Name = "Test",
                    Sex = true,
                    Age = 29
                };
                using (var context = new DContext())
                {
                    context.AccountUsers.Add(user);
                    context.SaveChanges();
                    var accountUsers = context.AccountUsers.ToList();
                }
                Console.Write("{0}", user.AccountUserId);
            }
            catch (Exception ex)
            {
                Console.Write("{0}", ex);
            }
            Console.ReadLine();
        }
    }
}
