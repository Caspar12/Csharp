using System;
using System.Collections.Generic;

using System.Text;

namespace Zh.WeiXin.BLL.API.Events
{
    public interface IGetCacheKey
    {
        string Get(object obj);
    }
}
