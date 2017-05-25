using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Session.Impls
{
    /// <summary>
    /// Http 上下文环境 Session
    /// </summary>
    public class HttpContextCurrentSession : ISession
    {
        System.Web.SessionState.HttpSessionState Session
        {
            get
            {
                var session = System.Web.HttpContext.Current.Session;
                if (session == null)
                {
                    throw new Exception("获取当前Http上下文环境Session变量失败");
                }
                return session;
            }
        }
        public object Get(string key)
        {
            return Session[key];
        }

        public T Get<T>(string key)
        {
            var value = Get(key);
            if (value == null) return default(T);
            return (T)value;
        }

        public void Set(string key, object value)
        {
            Session[key] = value;
        }

        public void Set<T>(string key, T value)
        {
            Set(key, (object)value);
        }
    }
}
