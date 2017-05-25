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
	#region Com_Click

	/// <summary>
    /// 点击表
	/// Com_Click object for mapped table 'Com_Click'.
	/// </summary>
	public partial class Com_Click
	{
		
		#region Constructors
        
		public Com_Click() { }        
        
		public Com_Click( Guid iD, string category, int? clickCount )
		{
			this.ID = iD;
			this.Category = category;
			this.ClickCount = clickCount;
		}
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
 