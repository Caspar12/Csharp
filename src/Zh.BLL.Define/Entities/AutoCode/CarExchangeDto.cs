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
	#region CarExchangeDto

	/// <summary>
    /// 
	/// CarExchangeDto data view model for mapped table 'Car_Exchange'.
	/// </summary>
	public partial class CarExchangeDto
	{
		
		#region Constructors
        
		public CarExchangeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid Car_MainItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int CityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? AreaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string GuestName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid Old_Car_MainItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal Distance { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int RegisteredYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int RegisteredMoth { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsFeedBack { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? FeedBackTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Remark { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto2{get;set;}
        /// <summary>
        /// 镇级
        /// </summary>            
        public virtual CommonAddressAreaDto CommonAddressAreaDto{get;set;}
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual CommonAddressCityDto CommonAddressCityDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 