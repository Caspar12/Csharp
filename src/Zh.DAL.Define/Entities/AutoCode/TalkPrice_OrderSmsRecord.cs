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
	#region TalkPrice_OrderSmsRecord

	/// <summary>
    /// 短信表
	/// TalkPrice_OrderSmsRecord object for mapped table 'TalkPrice_OrderSmsRecord'.
	/// </summary>
	public partial class TalkPrice_OrderSmsRecord
	{
		
		#region Constructors
        
		public TalkPrice_OrderSmsRecord() { }        
        
		public TalkPrice_OrderSmsRecord( Guid iD, Guid talkPriceOrderId, Guid smsId )
		{
			this.ID = iD;
			this.TalkPriceOrderId = talkPriceOrderId;
			this.SmsId = smsId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TalkPriceOrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid SmsId { get; set; }
        
        /// <summary>
        /// 短信表
        /// </summary>            
        public virtual Sms_Main Sms_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TalkPrice_Order TalkPrice_Order{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 