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
	#region Repair_SetToT_CounterPart

	/// <summary>
    /// 维修套餐对维修配件表
	/// Repair_SetToT_CounterPart object for mapped table 'Repair_SetToT_CounterPart'.
	/// </summary>
	public partial class Repair_SetToT_CounterPart
	{
		
		#region Constructors
        
		public Repair_SetToT_CounterPart() { }        
        
		public Repair_SetToT_CounterPart( Guid iD, int identity, string shopID, Guid repairSetId, string name, decimal price )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ShopID = shopID;
			this.RepairSetId = repairSetId;
			this.Name = name;
			this.Price = price;
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
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid RepairSetId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal Price { get; set; }
        
        /// <summary>
        /// 维修套餐表
        /// </summary>            
        public virtual Repair_Set Repair_Set{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 