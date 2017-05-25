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
	#region Display_HomePriceChartType

	/// <summary>
    /// 首页报价类型表
	/// Display_HomePriceChartType object for mapped table 'Display_HomePriceChartType'.
	/// </summary>
	public partial class Display_HomePriceChartType
	{
		
		#region Constructors
        
		public Display_HomePriceChartType() { }        
        
		public Display_HomePriceChartType( Guid iD, string name, int sort )
		{
			this.ID = iD;
			this.Name = name;
			this.Sort = sort;
		}
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
        public virtual IList<Display_HomePriceChart> Display_HomePriceChart{get;set;}
        /// <summary>
        /// 首页报价经销商广告表
        /// </summary>
        public virtual IList<Display_HomePriceChartDistributorAdvert> Display_HomePriceChartDistributorAdvert{get;set;}


		#endregion
	 
	}
	#endregion
}
 