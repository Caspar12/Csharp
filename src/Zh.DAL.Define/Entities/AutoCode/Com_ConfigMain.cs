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
	#region Com_ConfigMain

	/// <summary>
    /// 通用配置表
	/// Com_ConfigMain object for mapped table 'Com_ConfigMain'.
	/// </summary>
	public partial class Com_ConfigMain
	{
		
		#region Constructors
        
		public Com_ConfigMain() { }        
        
		public Com_ConfigMain( Guid iD, string configContent )
		{
			this.ID = iD;
			this.ConfigContent = configContent;
		}
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
 