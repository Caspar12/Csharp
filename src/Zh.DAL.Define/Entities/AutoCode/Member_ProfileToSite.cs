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
	#region Member_ProfileToSite

	/// <summary>
    /// 会员开通站点信息
	/// Member_ProfileToSite object for mapped table 'Member_ProfileToSite'.
	/// </summary>
	public partial class Member_ProfileToSite
	{
		
		#region Constructors
        
		public Member_ProfileToSite() { }        
        
		public Member_ProfileToSite( Guid id, Guid memberId, DateTime createdDate, Guid siteId, int guestId )
		{
			this.Id = id;
			this.MemberId = memberId;
			this.CreatedDate = createdDate;
			this.SiteId = siteId;
			this.GuestId = guestId;
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
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 站点Id
        /// </summary>
		public virtual Guid SiteId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int GuestId { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Member_ProfileToSiteCar> Member_ProfileToSiteCar{get;set;}


		#endregion
	 
	}
	#endregion
}
 