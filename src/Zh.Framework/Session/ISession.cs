using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Session
{
    public interface ISession
    {
        object Get(string key);

        void Set(string key, object value); 
    }
}
