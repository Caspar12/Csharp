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
	#region ArticleMainToBrandDto

	/// <summary>
    /// 
	/// ArticleMainToBrandDto data view model for mapped table 'Article_MainToBrand'.
	/// </summary>
	public partial class ArticleMainToBrandDto
	{
		
		#region Constructors
        
		public ArticleMainToBrandDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid BrandID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual CarBrandDto CarBrandDto{get;set;}
        
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<ArticleMainDto> ArticleMainDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 