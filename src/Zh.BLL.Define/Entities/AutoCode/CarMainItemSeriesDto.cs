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
	#region CarMainItemSeriesDto

	/// <summary>
    /// 车型系统表
	/// CarMainItemSeriesDto data view model for mapped table 'Car_MainItem_Series'.
	/// </summary>
	public partial class CarMainItemSeriesDto
	{
		
		#region Constructors
        
		public CarMainItemSeriesDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车型系列名称
        /// </summary>
		public virtual string Name { get; set; }
        
        
        /// <summary>
        /// 指定车辆表
        /// </summary>
        public virtual IList<CarMainItemDto> CarMainItemDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 