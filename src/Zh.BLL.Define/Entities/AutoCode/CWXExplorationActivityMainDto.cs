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
	#region CWXExplorationActivityMainDto

	/// <summary>
    /// 活动表
	/// CWXExplorationActivityMainDto data view model for mapped table 'CWX_ExplorationActivity_Main'.
	/// </summary>
	public partial class CWXExplorationActivityMainDto
	{
		
		#region Constructors
        
		public CWXExplorationActivityMainDto() { }        
        
	 
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
        public virtual CategoryMainDto CategoryMainDto{get;set;}
        
        /// <summary>
        /// 活动表
        /// </summary>
        public virtual IList<CWXExplorationActivityOrderUserDto> CWXExplorationActivityOrderUserDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 