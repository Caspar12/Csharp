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
	#region T_SendMessage

	/// <summary>
    /// 
	/// T_SendMessage object for mapped table 'T_SendMessage'.
	/// </summary>
	public partial class T_SendMessage
	{
		
		#region Constructors
        
		public T_SendMessage() { }        
        
		public T_SendMessage( int sendMessageIndex, string phoneNumber, string messageContant, DateTime? sendTime, byte[] stamp )
		{
			this.SendMessageIndex = sendMessageIndex;
			this.PhoneNumber = phoneNumber;
			this.MessageContant = messageContant;
			this.SendTime = sendTime;
			this.Stamp = stamp;
		}
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
 