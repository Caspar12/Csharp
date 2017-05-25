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
	#region ComDisplayInfoDto

	/// <summary>
    /// 通用展示信息关联表
	/// ComDisplayInfoDto data view model for mapped table 'Com_DisplayInfo'.
	/// </summary>
	public partial class ComDisplayInfoDto
	{
		
		#region Constructors
        
		public ComDisplayInfoDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 展示类型Id
        /// </summary>
		public virtual string DisplayTypeId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 关联对象Id
        /// </summary>
		public virtual Guid ObjectId { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
		public virtual bool IsShow { get; set; }
        
        /// <summary>
        /// 通用展示类型表
        /// </summary>            
        public virtual ComDisplayTypeDto ComDisplayTypeDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 