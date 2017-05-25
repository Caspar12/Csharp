/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层接口契约文件 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.BLL.Define.Entities;
using Zh.BLL.Base.Define;
using Zh.Framework.Entities;
namespace Zh.BLL.Define.Contracts
{
    public partial interface IComConfigMainService : IBaseService<ComConfigMainDto, Com_ConfigMain>
    {
        /// <summary>
        /// 获取或创建默认配置
        /// </summary>
        /// <typeparam name="T">配置数据结构类型</typeparam>
        /// <param name="configId">配置Id</param>
        /// <param name="defaultConfig">默认配置数据</param>
        /// <returns>返回配置或返回默认配置</returns>
        T GetOrCreate<T>(Guid configId, T defaultConfig);
    }
}