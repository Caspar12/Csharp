using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.BLL.Define.Contracts
{
    /// <summary>
    /// 通用生成无重复数据值逻辑
    /// </summary>
    public partial interface IComMaxIdService
    {
        /// <summary>
        /// 创建下一个数值
        /// </summary>
        /// <param name="id">Com_Max id</param>
        /// <returns>下一个数值</returns>
        long CreateNext(Guid id);
        /// <summary>
        /// 获取当前参数id,最大数值
        /// </summary>
        /// <param name="id">Com_Max id</param>
        /// <returns>最大数值</returns>
        long GetMax(Guid id);
    }
}
