/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using System.Collections.Generic;
namespace Zh.BLL.Define.Entities
{
	#region WeiXinAccountToCenterAccountDto

	/// <summary>
    /// 微信账号对集群账号表
	/// WeiXinAccountToCenterAccountDto data view model for mapped table 'WeiXin_AccountToCenterAccount'.
	/// </summary>
	public partial class WeiXinAccountToCenterAccountDto
	{
		
		#region Constructors
        
		public WeiXinAccountToCenterAccountDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// WeiXinOpenId
        /// </summary>
		public virtual string WeiXinOpenId { get; set; }
        /// <summary>
        /// CenterAccountId
        /// </summary>
		public virtual Guid CenterAccountId { get; set; }
        /// <summary>
        /// AppId
        /// </summary>
		public virtual string AppId { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 