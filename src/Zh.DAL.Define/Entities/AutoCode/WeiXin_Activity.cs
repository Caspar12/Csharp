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
	#region WeiXin_Activity

	/// <summary>
    /// 微活动报名表
	/// WeiXin_Activity object for mapped table 'WeiXin_Activity'.
	/// </summary>
	public partial class WeiXin_Activity
	{
		
		#region Constructors
        
		public WeiXin_Activity() { }        
        
		public WeiXin_Activity( Guid iD, int identity, string title, string shopId, DateTime createdDate )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Title = title;
			this.ShopId = shopId;
			this.CreatedDate = createdDate;
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
        /// 标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        
        
        /// <summary>
        /// 微活动报名表
        /// </summary>
        public virtual IList<WeiXin_Activity_Applicant> WeiXin_Activity_Applicant{get;set;}


		#endregion
	 
	}
	#endregion
}
 