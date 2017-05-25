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
	#region CarMainToStoreMainRefDto

	/// <summary>
    /// 抽象关系表
	/// CarMainToStoreMainRefDto data view model for mapped table 'Car_MainToStore_MainRef'.
	/// </summary>
	public partial class CarMainToStoreMainRefDto
	{
		
		#region Constructors
        
		public CarMainToStoreMainRefDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// Id
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid StoreMainId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDatetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsShowInGoodCar { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsShowInCarMainDetal { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsShowInTalkPrice { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual StoreMainDto StoreMainDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 