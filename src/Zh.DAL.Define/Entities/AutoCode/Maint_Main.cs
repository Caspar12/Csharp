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
	#region Maint_Main

	/// <summary>
    /// 
	/// Maint_Main object for mapped table 'Maint_Main'.
	/// </summary>
	public partial class Maint_Main
	{
		
		#region Constructors
        
		public Maint_Main() { }        
        
		public Maint_Main( Guid iD, int identity, DateTime createdDate, Guid? carMainItemId, decimal mileageBetweenServices, DateTime servicesDate, string business, int? serviceScore, int? maintRateScore, int? storeEnvironmentScore, int? priceScore, string description, Guid? carMainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.CreatedDate = createdDate;
			this.CarMainItemId = carMainItemId;
			this.MileageBetweenServices = mileageBetweenServices;
			this.ServicesDate = servicesDate;
			this.Business = business;
			this.ServiceScore = serviceScore;
			this.MaintRateScore = maintRateScore;
			this.StoreEnvironmentScore = storeEnvironmentScore;
			this.PriceScore = priceScore;
			this.Description = description;
			this.CarMainId = carMainId;
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
        /// 发布时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CarMainItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal MileageBetweenServices { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime ServicesDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Business { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? ServiceScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? MaintRateScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? StoreEnvironmentScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? PriceScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CarMainId { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Maint_Image> Maint_Image{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Maint_MaintItem> Maint_MaintItem{get;set;}


		#endregion
	 
	}
	#endregion
}
 