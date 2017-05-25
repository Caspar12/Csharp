﻿/*
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
	#region CarMainItemToExColorDto

	/// <summary>
    /// 车辆外观颜色关系表
	/// CarMainItemToExColorDto data view model for mapped table 'Car_MainItemToExColor'.
	/// </summary>
	public partial class CarMainItemToExColorDto
	{
		
		#region Constructors
        
		public CarMainItemToExColorDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车系ID
        /// </summary>
		public virtual Guid MainItemID { get; set; }
        /// <summary>
        /// 颜色ID
        /// </summary>
		public virtual Guid ColorID { get; set; }
        
        /// <summary>
        /// 车辆颜色
        /// </summary>            
        public virtual CarColorDto CarColorDto{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 