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
	#region Repair_Set

	/// <summary>
    /// 维修套餐表
	/// Repair_Set object for mapped table 'Repair_Set'.
	/// </summary>
	public partial class Repair_Set
	{
		
		#region Constructors
        
		public Repair_Set() { }        
        
		public Repair_Set( Guid iD, int identity, string name, DateTime? beginTime, DateTime? endTime, string shopID, string content, decimal? salePrice, decimal? price, string remark, Guid? repairSetTripDistanceId, Guid? repairSetTripTimeId, int sort, DateTime createdDate, string imgUrl )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.BeginTime = beginTime;
			this.EndTime = endTime;
			this.ShopID = shopID;
			this.Content = content;
			this.SalePrice = salePrice;
			this.Price = price;
			this.Remark = remark;
			this.RepairSetTripDistanceId = repairSetTripDistanceId;
			this.RepairSetTripTimeId = repairSetTripTimeId;
			this.Sort = sort;
			this.CreatedDate = createdDate;
			this.ImgUrl = imgUrl;
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
        public virtual Repair_SetTripDistance Repair_SetTripDistance{get;set;}
        /// <summary>
        /// 维修套餐行驶时间表
        /// </summary>            
        public virtual Repair_SetTripTime Repair_SetTripTime{get;set;}
        
        /// <summary>
        /// 维修套餐预约关系表
        /// </summary>
        public virtual IList<Repair_SetTodt_Feedback> Repair_SetTodt_Feedback{get;set;}
        /// <summary>
        /// 维修套餐对维修工时表
        /// </summary>
        public virtual IList<Repair_SetToT_CarService> Repair_SetToT_CarService{get;set;}
        /// <summary>
        /// 维修套餐对维修配件表
        /// </summary>
        public virtual IList<Repair_SetToT_CounterPart> Repair_SetToT_CounterPart{get;set;}


		#endregion
	 
	}
	#endregion
}
 