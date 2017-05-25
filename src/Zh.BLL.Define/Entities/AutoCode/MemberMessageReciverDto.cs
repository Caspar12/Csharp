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
	#region MemberMessageReciverDto

	/// <summary>
    /// 
	/// MemberMessageReciverDto data view model for mapped table 'MemberMessageReciver'.
	/// </summary>
	public partial class MemberMessageReciverDto
	{
		
		#region Constructors
        
		public MemberMessageReciverDto() { }        
        
	 
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
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual MemberMessageDto MemberMessageDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 