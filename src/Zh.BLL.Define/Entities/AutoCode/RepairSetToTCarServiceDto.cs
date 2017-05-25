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
	#region RepairSetToTCarServiceDto

	/// <summary>
    /// 维修套餐对维修工时表
	/// RepairSetToTCarServiceDto data view model for mapped table 'Repair_SetToT_CarService'.
	/// </summary>
	public partial class RepairSetToTCarServiceDto
	{
		
		#region Constructors
        
		public RepairSetToTCarServiceDto() { }        
        
	 
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
        public virtual RepairSetDto RepairSetDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 