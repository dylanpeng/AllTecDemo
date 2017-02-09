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
                //var user = new AccountUser()
                //{
                //    Name = "Test",
                //    Sex = true,
                //    Age = 29
                //};
                //using (var context = new DContext())
                //{
                //    context.AccountUsers.Add(user);
                //    context.SaveChanges();
                //    var accountUsers = context.AccountUsers.ToList();
                //}

                //var provice = new Provice
                //{
                //    ProviceName = "河南省",
                //    Citys = new List<City>()
                //    {
                //        new City() { CityName = "安阳"},
                //        new City() { CityName = "郑州"},
                //        new City() { CityName = "洛阳"},
                //    }
                //};
                //using (var context = new DContext())
                //{
                //    context.Provices.Add(provice);
                //    context.SaveChanges();
                //    var provices = context.Provices.Include("Citys").ToList();
                //}

                var city = new City()
                {
                    ProviceId = 2,
                    CityName = "新乡"
                };
                using (var context = new DContext())
                {
                    context.Citys.Add(city);
                    Console.Write("{0}", context.Entry(city).State.ToString());
                    context.SaveChanges();
                    var citys = context.Citys.ToList();
                    
                }

                //Console.Write("{0}", provice.ProviceId);
            }
            catch (Exception ex)
            {
                Console.Write("{0}", ex);
            }

            Console.ReadLine();
        }
    }
}
