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
	#region dtChannelDto

	/// <summary>
    /// 
	/// dtChannelDto data view model for mapped table 'dt_Channel'.
	/// </summary>
	public partial class dtChannelDto
	{
		
		#region Constructors
        
		public dtChannelDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 栏目名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 父栏目ID
        /// </summary>
		public virtual int ParentId { get; set; }
        /// <summary>
        /// 子栏目ID列表
        /// </summary>
		public virtual string ClassList { get; set; }
        /// <summary>
        /// 栏目深度
        /// </summary>
		public virtual int ClassLayer { get; set; }
        /// <summary>
        /// 排序数字
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 栏目管理地址
        /// </summary>
		public virtual string PageUrl { get; set; }
        /// <summary>
        /// 栏目自定义数字
        /// </summary>
		public virtual int KindId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 