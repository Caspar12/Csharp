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
	#region Com_DisplayType

	/// <summary>
    /// 通用展示类型表
	/// Com_DisplayType object for mapped table 'Com_DisplayType'.
	/// </summary>
	public partial class Com_DisplayType
	{
		
		#region Constructors
        
		public Com_DisplayType() { }        
        
		public Com_DisplayType( string iD, string name )
		{
			this.ID = iD;
			this.Name = name;
		}
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
        public virtual IList<Com_DisplayInfo> Com_DisplayInfo{get;set;}


		#endregion
	 
	}
	#endregion
}
 