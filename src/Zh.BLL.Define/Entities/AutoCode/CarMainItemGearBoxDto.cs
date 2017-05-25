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
	#region CarMainItemGearBoxDto

	/// <summary>
    /// 车辆变速箱参数
	/// CarMainItemGearBoxDto data view model for mapped table 'Car_MainItem_GearBox'.
	/// </summary>
	public partial class CarMainItemGearBoxDto
	{
		
		#region Constructors
        
		public CarMainItemGearBoxDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 挡位个数
        /// </summary>
		public virtual string LevelCount { get; set; }
        /// <summary>
        /// 变速箱类型
        /// </summary>
		public virtual string Type { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 