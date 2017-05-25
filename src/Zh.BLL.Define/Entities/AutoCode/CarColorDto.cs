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
	#region CarColorDto

	/// <summary>
    /// 车辆颜色
	/// CarColorDto data view model for mapped table 'Car_Color'.
	/// </summary>
	public partial class CarColorDto
	{
		
		#region Constructors
        
		public CarColorDto() { }        
        
	 
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
        /// 颜色RGB值
        /// </summary>
		public virtual string RGB { get; set; }
        
        
        /// <summary>
        /// 车辆外观颜色关系表
        /// </summary>
        public virtual IList<CarMainItemToExColorDto> CarMainItemToExColorDto{get;set;}
        /// <summary>
        /// 车辆内观颜色关系表
        /// </summary>
        public virtual IList<CarMainItemToInColorDto> CarMainItemToInColorDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 