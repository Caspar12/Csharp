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
	#region Com_Count

	/// <summary>
    /// 独立计数器主表
	/// Com_Count object for mapped table 'Com_Count'.
	/// </summary>
	public partial class Com_Count
	{
		
		#region Constructors
        
		public Com_Count() { }        
        
		public Com_Count( Guid id, Guid targetId, DateTime createdDatetime, long count, string categoryId, string tableName )
		{
			this.Id = id;
			this.TargetId = targetId;
			this.CreatedDatetime = createdDatetime;
			this.Count = count;
			this.CategoryId = categoryId;
			this.TableName = tableName;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// Id
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 计数对象Id
        /// </summary>
		public virtual Guid TargetId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDatetime { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
		public virtual long Count { get; set; }
        /// <summary>
        /// 分类标记
        /// </summary>
		public virtual string CategoryId { get; set; }
        /// <summary>
        /// 记录对象表
        /// </summary>
		public virtual string TableName { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 