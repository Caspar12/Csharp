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
	#region dtContentsDto

	/// <summary>
    /// 
	/// dtContentsDto data view model for mapped table 'dt_Contents'.
	/// </summary>
	public partial class dtContentsDto
	{
		
		#region Constructors
        
		public dtContentsDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 调用标识
        /// </summary>
		public virtual string CallIndex { get; set; }
        /// <summary>
        /// 内容标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 栏目ID
        /// </summary>
		public virtual int ClassId { get; set; }
        /// <summary>
        /// 详细介绍
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 排序数字，越小越向前
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 