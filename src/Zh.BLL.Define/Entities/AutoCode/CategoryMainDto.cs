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
	#region CategoryMainDto

	/// <summary>
    /// 分类表
	/// CategoryMainDto data view model for mapped table 'Category_Main'.
	/// </summary>
	public partial class CategoryMainDto
	{
		
		#region Constructors
        
		public CategoryMainDto() { }        
        
	 
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
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowInFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int XType { get; set; }
        
        
        /// <summary>
        /// 活动表
        /// </summary>
        public virtual IList<CWXExplorationActivityMainDto> CWXExplorationActivityMainDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 