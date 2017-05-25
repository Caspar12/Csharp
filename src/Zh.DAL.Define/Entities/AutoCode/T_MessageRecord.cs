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
	#region T_MessageRecord

	/// <summary>
    /// 
	/// T_MessageRecord object for mapped table 'T_MessageRecord'.
	/// </summary>
	public partial class T_MessageRecord
	{
		
		#region Constructors
        
		public T_MessageRecord() { }        
        
		public T_MessageRecord( int id, string messageType, int? count, DateTime? sendDate, string shopid, string messageContent )
		{
			this.id = id;
			this.messageType = messageType;
			this.count = count;
			this.sendDate = sendDate;
			this.shopid = shopid;
			this.messageContent = messageContent;
		}
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
 