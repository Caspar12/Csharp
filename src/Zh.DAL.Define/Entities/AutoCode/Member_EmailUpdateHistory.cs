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
	#region Member_EmailUpdateHistory

	/// <summary>
    /// 会员账号信息
	/// Member_EmailUpdateHistory object for mapped table 'Member_EmailUpdateHistory'.
	/// </summary>
	public partial class Member_EmailUpdateHistory
	{
		
		#region Constructors
        
		public Member_EmailUpdateHistory() { }        
        
		public Member_EmailUpdateHistory( Guid id, Guid memberId, string email, DateTime createdDate, bool isUsed )
		{
			this.Id = id;
			this.MemberId = memberId;
			this.Email = email;
			this.CreatedDate = createdDate;
			this.IsUsed = isUsed;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 会员Id
        /// </summary>
		public virtual Guid MemberId { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
		public virtual string Email { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 已经使用
        /// </summary>
		public virtual bool IsUsed { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 