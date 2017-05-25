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
	#region dt_AllReviews

	/// <summary>
    /// 
	/// dt_AllReviews object for mapped table 'dt_AllReviews'.
	/// </summary>
	public partial class dt_AllReviews
	{
		
		#region Constructors
        
		public dt_AllReviews() { }        
        
		public dt_AllReviews( int id, int kindId, int parentId, string userName, int? grade, string content, int? isLock, DateTime addTime, byte[] stamp )
		{
			this.Id = id;
			this.KindId = kindId;
			this.ParentId = parentId;
			this.UserName = userName;
			this.Grade = grade;
			this.Content = content;
			this.IsLock = isLock;
			this.AddTime = addTime;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 所属评论频道栏目
        /// </summary>
		public virtual int KindId { get; set; }
        /// <summary>
        /// 所属评论信息ID
        /// </summary>
		public virtual int ParentId { get; set; }
        /// <summary>
        /// 评论用户
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 星级
        /// </summary>
		public virtual int? Grade { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
		public virtual int? IsLock { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 