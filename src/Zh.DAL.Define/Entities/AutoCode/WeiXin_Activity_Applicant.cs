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
	#region WeiXin_Activity_Applicant

	/// <summary>
    /// 微活动报名表
	/// WeiXin_Activity_Applicant object for mapped table 'WeiXin_Activity_Applicant'.
	/// </summary>
	public partial class WeiXin_Activity_Applicant
	{
		
		#region Constructors
        
		public WeiXin_Activity_Applicant() { }        
        
		public WeiXin_Activity_Applicant( Guid iD, int identity, string phone, string name, string openId, Guid activityId, DateTime createdDate, int state )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Phone = phone;
			this.Name = name;
			this.OpenId = openId;
			this.ActivityId = activityId;
			this.CreatedDate = createdDate;
			this.State = state;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string OpenId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ActivityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int State { get; set; }
        
        /// <summary>
        /// 微活动报名表
        /// </summary>            
        public virtual WeiXin_Activity WeiXin_Activity{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 