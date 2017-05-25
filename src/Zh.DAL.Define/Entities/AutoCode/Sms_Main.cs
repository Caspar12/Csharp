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
	#region Sms_Main

	/// <summary>
    /// 短信表
	/// Sms_Main object for mapped table 'Sms_Main'.
	/// </summary>
	public partial class Sms_Main
	{
		
		#region Constructors
        
		public Sms_Main() { }        
        
		public Sms_Main( Guid iD, Guid xCategory, string content, string phone, int state, DateTime createdDate )
		{
			this.ID = iD;
			this.XCategory = xCategory;
			this.Content = content;
			this.Phone = phone;
			this.State = state;
			this.CreatedDate = createdDate;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
		public virtual Guid XCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int State { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        
        
        /// <summary>
        /// 短信表
        /// </summary>
        public virtual IList<TalkPrice_OrderSmsRecord> TalkPrice_OrderSmsRecord{get;set;}


		#endregion
	 
	}
	#endregion
}
 