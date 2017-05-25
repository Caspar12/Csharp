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
	#region MemberMessageReciver

	/// <summary>
    /// 
	/// MemberMessageReciver object for mapped table 'MemberMessageReciver'.
	/// </summary>
	public partial class MemberMessageReciver
	{
		
		#region Constructors
        
		public MemberMessageReciver() { }        
        
		public MemberMessageReciver( int iD, Guid messageID, Guid memberID, bool isReaded )
		{
			this.ID = iD;
			this.MessageID = messageID;
			this.MemberID = memberID;
			this.IsReaded = isReaded;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid MessageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid MemberID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsReaded { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual MemberMessage MemberMessage{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 