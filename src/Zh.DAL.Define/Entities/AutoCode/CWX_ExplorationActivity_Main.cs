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
	#region CWX_ExplorationActivity_Main

	/// <summary>
    /// 活动表
	/// CWX_ExplorationActivity_Main object for mapped table 'CWX_ExplorationActivity_Main'.
	/// </summary>
	public partial class CWX_ExplorationActivity_Main
	{
		
		#region Constructors
        
		public CWX_ExplorationActivity_Main() { }        
        
		public CWX_ExplorationActivity_Main( Guid iD, int identity, string title, DateTime activityTime, string content, string calendarContent, DateTime orderBeginTime, DateTime orderEndTime, string titleImageUrl, Guid? categoryId, string enterpriseName, string contacterPhone, string contacter )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Title = title;
			this.ActivityTime = activityTime;
			this.Content = content;
			this.CalendarContent = calendarContent;
			this.OrderBeginTime = orderBeginTime;
			this.OrderEndTime = orderEndTime;
			this.TitleImageUrl = titleImageUrl;
			this.CategoryId = categoryId;
			this.EnterpriseName = enterpriseName;
			this.ContacterPhone = contacterPhone;
			this.Contacter = contacter;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
		public virtual DateTime ActivityTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CalendarContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime OrderBeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime OrderEndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string TitleImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string EnterpriseName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ContacterPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contacter { get; set; }
        
        /// <summary>
        /// 分类表
        /// </summary>            
        public virtual Category_Main Category_Main{get;set;}
        
        /// <summary>
        /// 活动表
        /// </summary>
        public virtual IList<CWX_ExplorationActivity_OrderUser> CWX_ExplorationActivity_OrderUser{get;set;}


		#endregion
	 
	}
	#endregion
}
 