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
	#region Com_MaxId

	/// <summary>
    /// 通用生成无重复数据值表
	/// Com_MaxId object for mapped table 'Com_MaxId'.
	/// </summary>
	public partial class Com_MaxId
	{
		
		#region Constructors
        
		public Com_MaxId() { }        
        
		public Com_MaxId( Guid iD, long maxId )
		{
			this.ID = iD;
			this.MaxId = maxId;
		}
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
 