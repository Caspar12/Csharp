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
	#region DisplayHomePriceChartTypeDto

	/// <summary>
    /// 首页报价类型表
	/// DisplayHomePriceChartTypeDto data view model for mapped table 'Display_HomePriceChartType'.
	/// </summary>
	public partial class DisplayHomePriceChartTypeDto
	{
		
		#region Constructors
        
		public DisplayHomePriceChartTypeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        
        
        /// <summary>
        /// 首页报价表
        /// </summary>
        public virtual IList<DisplayHomePriceChartDto> DisplayHomePriceChartDto{get;set;}
        /// <summary>
        /// 首页报价经销商广告表
        /// </summary>
        public virtual IList<DisplayHomePriceChartDistributorAdvertDto> DisplayHomePriceChartDistributorAdvertDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 