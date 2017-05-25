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
	#region ComDisplayTypeDto

	/// <summary>
    /// 通用展示类型表
	/// ComDisplayTypeDto data view model for mapped table 'Com_DisplayType'.
	/// </summary>
	public partial class ComDisplayTypeDto
	{
		
		#region Constructors
        
		public ComDisplayTypeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual string ID { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
		public virtual string Name { get; set; }
        
        
        /// <summary>
        /// 通用展示信息关联表
        /// </summary>
        public virtual IList<ComDisplayInfoDto> ComDisplayInfoDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 