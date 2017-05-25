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
	#region TSendMessageDto

	/// <summary>
    /// 
	/// TSendMessageDto data view model for mapped table 'T_SendMessage'.
	/// </summary>
	public partial class TSendMessageDto
	{
		
		#region Constructors
        
		public TSendMessageDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 发送短信记录
        /// </summary>
		public virtual int SendMessageIndex { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
		public virtual string PhoneNumber { get; set; }
        /// <summary>
        /// 短信内容
        /// </summary>
		public virtual string MessageContant { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
		public virtual DateTime? SendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 