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
	#region ComConfigMainDto

	/// <summary>
    /// 通用配置表
	/// ComConfigMainDto data view model for mapped table 'Com_ConfigMain'.
	/// </summary>
	public partial class ComConfigMainDto
	{
		
		#region Constructors
        
		public ComConfigMainDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 配置内容
        /// </summary>
		public virtual string ConfigContent { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 