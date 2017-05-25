/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层接口契约文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using System.Collections.Generic; 
using Zh.DAL.Define.Entities;
using Zh.BLL.Define.Entities;
using Zh.BLL.Base.Define;
namespace Zh.BLL.Define.Contracts
{
    public partial interface IBBSCommentService : IBaseService< BBSCommentDto,BBS_Comment>
    {
        
    }
}