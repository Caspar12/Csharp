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
	#region ComMaxIdDto

	/// <summary>
    /// 通用生成无重复数据值表
	/// ComMaxIdDto data view model for mapped table 'Com_MaxId'.
	/// </summary>
	public partial class ComMaxIdDto
	{
		
		#region Constructors
        
		public ComMaxIdDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 最大数字
        /// </summary>
		public virtual long MaxId { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 