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
	#region ComCountDto

	/// <summary>
    /// 独立计数器主表
	/// ComCountDto data view model for mapped table 'Com_Count'.
	/// </summary>
	public partial class ComCountDto
	{
		
		#region Constructors
        
		public ComCountDto() { }        
        
	 
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
 