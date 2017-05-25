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
	#region BBSCommentTypeDto

	/// <summary>
    /// 评论类型表
	/// BBSCommentTypeDto data view model for mapped table 'BBS_CommentType'.
	/// </summary>
	public partial class BBSCommentTypeDto
	{
		
		#region Constructors
        
		public BBSCommentTypeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 评语类型
        /// </summary>
		public virtual Guid Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
		public virtual string Remark { get; set; }
        
        
        /// <summary>
        /// 评论内容表
        /// </summary>
        public virtual IList<BBSCommentDto> BBSCommentDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 