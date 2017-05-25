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
	#region TMessageRecordDto

	/// <summary>
    /// 
	/// TMessageRecordDto data view model for mapped table 'T_MessageRecord'.
	/// </summary>
	public partial class TMessageRecordDto
	{
		
		#region Constructors
        
		public TMessageRecordDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string messageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? count { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? sendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string shopid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string messageContent { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 