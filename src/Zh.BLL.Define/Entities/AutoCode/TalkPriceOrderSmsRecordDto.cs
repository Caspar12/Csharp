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
	#region TalkPriceOrderSmsRecordDto

	/// <summary>
    /// 短信表
	/// TalkPriceOrderSmsRecordDto data view model for mapped table 'TalkPrice_OrderSmsRecord'.
	/// </summary>
	public partial class TalkPriceOrderSmsRecordDto
	{
		
		#region Constructors
        
		public TalkPriceOrderSmsRecordDto() { }        
        
	 
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
        public virtual SmsMainDto SmsMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TalkPriceOrderDto TalkPriceOrderDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 