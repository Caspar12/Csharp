/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define.Entities;
namespace Zh.DAL.Define.Entities
{
	#region WeiXin_AccountToCenterAccount

	/// <summary>
    /// 微信账号对集群账号表
	/// WeiXin_AccountToCenterAccount object for mapped table 'WeiXin_AccountToCenterAccount'.
	/// </summary>
	public partial class WeiXin_AccountToCenterAccount
	{
		
		#region Constructors
        
		public WeiXin_AccountToCenterAccount() { }        
        
		public WeiXin_AccountToCenterAccount( Guid iD, int identity, string weiXinOpenId, Guid centerAccountId, string appId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.WeiXinOpenId = weiXinOpenId;
			this.CenterAccountId = centerAccountId;
			this.AppId = appId;
		}
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
        public virtual Member_Account Member_Account{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 