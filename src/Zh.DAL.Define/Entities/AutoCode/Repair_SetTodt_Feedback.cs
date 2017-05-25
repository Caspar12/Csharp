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
	#region Repair_SetTodt_Feedback

	/// <summary>
    /// 维修套餐预约关系表
	/// Repair_SetTodt_Feedback object for mapped table 'Repair_SetTodt_Feedback'.
	/// </summary>
	public partial class Repair_SetTodt_Feedback
	{
		
		#region Constructors
        
		public Repair_SetTodt_Feedback() { }        
        
		public Repair_SetTodt_Feedback( Guid iD, string shopID, Guid repairSetId, int feekBookId )
		{
			this.ID = iD;
			this.ShopID = shopID;
			this.RepairSetId = repairSetId;
			this.FeekBookId = feekBookId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
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
		public virtual int FeekBookId { get; set; }
        
        /// <summary>
        /// 维修套餐表
        /// </summary>            
        public virtual Repair_Set Repair_Set{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 