/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 数据接口契约文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Base.Define;
using Zh.DAL.Define.Entities;
using Zh.DAL.Define;
namespace Zh.DAL.Define.Contracts
{
    /// <summary>
    /// Member_Account(会员账号信息)表访问接口
    /// </summary>
    public partial interface IMemberAccountDao : IBaseDao<Member_Account>
    {
        
    }
}