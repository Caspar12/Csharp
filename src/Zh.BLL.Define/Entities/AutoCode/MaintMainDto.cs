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
	#region MaintMainDto

	/// <summary>
    /// 
	/// MaintMainDto data view model for mapped table 'Maint_Main'.
	/// </summary>
	public partial class MaintMainDto
	{
		
		#region Constructors
        
		public MaintMainDto() { }        
        
	 
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
        public virtual CarMainDto CarMainDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MaintImageDto> MaintImageDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MaintMaintItemDto> MaintMaintItemDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 