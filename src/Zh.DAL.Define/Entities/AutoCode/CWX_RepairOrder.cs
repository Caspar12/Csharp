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
	#region CWX_RepairOrder

	/// <summary>
    /// 
	/// CWX_RepairOrder object for mapped table 'CWX_RepairOrder'.
	/// </summary>
	public partial class CWX_RepairOrder
	{
		
		#region Constructors
        
		public CWX_RepairOrder() { }        
        
		public CWX_RepairOrder( Guid iD, int identity, string name, string contact, string carBrand, string carType, DateTime createdDateTime, DateTime orderDateTime, Guid? storeMainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Contact = contact;
			this.CarBrand = carBrand;
			this.CarType = carType;
			this.CreatedDateTime = createdDateTime;
			this.OrderDateTime = orderDateTime;
			this.StoreMainId = storeMainId;
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
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CarBrand { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CarType { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime OrderDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? StoreMainId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Store_Main Store_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 