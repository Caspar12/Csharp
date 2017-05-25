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
	#region BBS_CommentType

	/// <summary>
    /// 评论类型表
	/// BBS_CommentType object for mapped table 'BBS_CommentType'.
	/// </summary>
	public partial class BBS_CommentType
	{
		
		#region Constructors
        
		public BBS_CommentType() { }        
        
		public BBS_CommentType( Guid iD, int identity, Guid type, string remark )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Type = type;
			this.Remark = remark;
		}
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
        public virtual IList<BBS_Comment> BBS_Comment{get;set;}


		#endregion
	 
	}
	#endregion
}
 