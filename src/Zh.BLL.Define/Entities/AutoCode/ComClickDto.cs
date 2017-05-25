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
	#region ComClickDto

	/// <summary>
    /// 点击表
	/// ComClickDto data view model for mapped table 'Com_Click'.
	/// </summary>
	public partial class ComClickDto
	{
		
		#region Constructors
        
		public ComClickDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 分类标识
        /// </summary>
		public virtual string Category { get; set; }
        /// <summary>
        /// 点击数量
        /// </summary>
		public virtual int? ClickCount { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 