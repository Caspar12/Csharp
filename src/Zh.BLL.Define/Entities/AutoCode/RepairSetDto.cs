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
	#region RepairSetDto

	/// <summary>
    /// 维修套餐表
	/// RepairSetDto data view model for mapped table 'Repair_Set'.
	/// </summary>
	public partial class RepairSetDto
	{
		
		#region Constructors
        
		public RepairSetDto() { }        
        
	 
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
        /// 套餐名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
		public virtual DateTime? BeginTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
		public virtual DateTime? EndTime { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? SalePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? RepairSetTripDistanceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? RepairSetTripTimeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImgUrl { get; set; }
        
        /// <summary>
        /// 维修套餐行驶里程表
        /// </summary>            
        public virtual RepairSetTripDistanceDto RepairSetTripDistanceDto{get;set;}
        /// <summary>
        /// 维修套餐行驶时间表
        /// </summary>            
        public virtual RepairSetTripTimeDto RepairSetTripTimeDto{get;set;}
        
        /// <summary>
        /// 维修套餐预约关系表
        /// </summary>
        public virtual IList<RepairSetTodtFeedbackDto> RepairSetTodtFeedbackDto{get;set;}
        /// <summary>
        /// 维修套餐对维修工时表
        /// </summary>
        public virtual IList<RepairSetToTCarServiceDto> RepairSetToTCarServiceDto{get;set;}
        /// <summary>
        /// 维修套餐对维修配件表
        /// </summary>
        public virtual IList<RepairSetToTCounterPartDto> RepairSetToTCounterPartDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 