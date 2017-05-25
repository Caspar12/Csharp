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
	#region RepairSetTripDistanceDto

	/// <summary>
    /// 维修套餐行驶里程表
	/// RepairSetTripDistanceDto data view model for mapped table 'Repair_SetTripDistance'.
	/// </summary>
	public partial class RepairSetTripDistanceDto
	{
		
		#region Constructors
        
		public RepairSetTripDistanceDto() { }        
        
	 
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
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        
        /// <summary>
        /// 维修套餐表
        /// </summary>
        public virtual IList<RepairSetDto> RepairSetDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 