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
	#region MemberProfileToSiteDto

	/// <summary>
    /// 会员开通站点信息
	/// MemberProfileToSiteDto data view model for mapped table 'Member_ProfileToSite'.
	/// </summary>
	public partial class MemberProfileToSiteDto
	{
		
		#region Constructors
        
		public MemberProfileToSiteDto() { }        
        
	 
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
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteDto WebSiteDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MemberProfileToSiteCarDto> MemberProfileToSiteCarDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 