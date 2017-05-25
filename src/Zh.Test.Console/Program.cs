using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define;
using Zh.DAL.Define.Entities;
using Zh.DAL.Define.Contracts;
using System.Collections;
using NHibernate.Cfg;
using Spring.Data.Common;
using System.Data;
using System.Data.SQLite;
using Zh.BLL.Define.Contracts;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;
using System.Reflection;
using Zh.Framework.Tools;
using Zh.DAL.Base.NH;
using Spring.Data.NHibernate.Generic;
using Spring.Data.NHibernate;
using Zh.DAL.Base.NH.Helpers;
using Zh.BLL.Define.Contracts.Imp;
using Zh.DAL.Define;
using System.Threading;

namespace Zh.Test.Console
{
    class Program
    {
        public static object SyncObj = new object();
        public static string SyncObj1 = "1";
        static void Main(string[] args)
        {
            //   IComCountDao k = ServiceFactory.Get<IComCountDao>();
            var t1 = new ThreadStart(() =>
            {
                try
                {
                    var ioc = ToolFactory.Ioc;

                    SyncObj1 = Thread.CurrentThread.Name;
                    // Thread.Sleep(new Random().Next(100, 200));
                    var obj = ioc.Get<object>("NHibernateSessionFactory");
                    var localSessionFactoryObjectThreadSafe = ioc.Get<LocalSessionFactoryObjectThreadSafe>("&NHibernateSessionFactory");

                    IComCountService a = ServiceFactory.Get<IComCountService>();
                    var list = a.FindAll();

                    //foreach (var item in list.Data)
                    //{
                    //    System.Console.WriteLine(string.Format("{0},{1}", Thread.CurrentThread.Name, item.Id));
                    //}
                }
                catch (Exception ex)
                {
                    var kk = 0;
                }

            });
            for (var i = 0; i < 5; i++)
            {
                var thread = new Thread(t1);
                thread.Name = i.ToString();
                thread.Start();
             
            }
          //  System.Console.ReadLine();
        }
        static void ReadLine()
        {
            System.Console.ReadLine();
        }
        static void WriteLine(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
