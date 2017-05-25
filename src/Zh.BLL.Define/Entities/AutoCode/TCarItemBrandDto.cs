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
	#region TCarItemBrandDto

	/// <summary>
    /// 
	/// TCarItemBrandDto data view model for mapped table 'T_CarItemBrand'.
	/// </summary>
	public partial class TCarItemBrandDto
	{
		
		#region Constructors
        
		public TCarItemBrandDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 汽车用品品牌表索引
        /// </summary>
		public virtual int CarItemBrandIndex { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
		public virtual string BrandName { get; set; }
        /// <summary>
        /// 品牌名称拼音码
        /// </summary>
		public virtual string BrandSpell { get; set; }
        /// <summary>
        /// 品牌图标url
        /// </summary>
		public virtual string BrandIcon { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string BrandStory { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TCarItemDto> TCarItemDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 