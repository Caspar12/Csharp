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
	#region TSystemConfigDto

	/// <summary>
    /// 系统设置
	/// TSystemConfigDto data view model for mapped table 'T_System_Config'.
	/// </summary>
	public partial class TSystemConfigDto
	{
		
		#region Constructors
        
		public TSystemConfigDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 配置名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 配置关键字
        /// </summary>
		public virtual string Key { get; set; }
        /// <summary>
        /// 配置值
        /// </summary>
		public virtual string Value { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string SiteID { get; set; }
        /// <summary>
        /// 组配置名字
        /// </summary>
		public virtual string ConfigGroup { get; set; }
        /// <summary>
        /// 输入方法
        /// </summary>
		public virtual int InputType { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 