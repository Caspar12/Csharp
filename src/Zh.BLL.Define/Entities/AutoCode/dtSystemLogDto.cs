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
	#region dtSystemLogDto

	/// <summary>
    /// 
	/// dtSystemLogDto data view model for mapped table 'dt_SystemLog'.
	/// </summary>
	public partial class dtSystemLogDto
	{
		
		#region Constructors
        
		public dtSystemLogDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 