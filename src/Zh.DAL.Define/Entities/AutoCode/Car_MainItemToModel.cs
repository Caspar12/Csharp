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
	#region Car_MainItemToModel

	/// <summary>
    /// 车辆与车型关系表
	/// Car_MainItemToModel object for mapped table 'Car_MainItemToModel'.
	/// </summary>
	public partial class Car_MainItemToModel
	{
		
		#region Constructors
        
		public Car_MainItemToModel() { }        
        
		public Car_MainItemToModel( Guid iD, Guid carItemID, Guid carModelID )
		{
			this.ID = iD;
			this.CarItemID = carItemID;
			this.CarModelID = carModelID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车辆ID
        /// </summary>
		public virtual Guid CarItemID { get; set; }
        /// <summary>
        /// 车型表ID
        /// </summary>
		public virtual Guid CarModelID { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        /// <summary>
        /// 车型表
        /// </summary>            
        public virtual Car_MainItem_Model Car_MainItem_Model{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 