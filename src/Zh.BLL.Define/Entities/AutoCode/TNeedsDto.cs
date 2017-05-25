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
	#region TNeedsDto

	/// <summary>
    /// 
	/// TNeedsDto data view model for mapped table 'T_Needs'.
	/// </summary>
	public partial class TNeedsDto
	{
		
		#region Constructors
        
		public TNeedsDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 需求表
        /// </summary>
		public virtual int NeedsIndex { get; set; }
        /// <summary>
        /// 留言表ID
        /// </summary>
		public virtual int? FeedbackID { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 是否需要,0不需要,1需要，其他为保存内容
        /// </summary>
		public virtual string IsNeed { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 