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
	#region Prestige_Impression

	/// <summary>
    /// 口啤印象表
	/// Prestige_Impression object for mapped table 'Prestige_Impression'.
	/// </summary>
	public partial class Prestige_Impression
	{
		
		#region Constructors
        
		public Prestige_Impression() { }        
        
		public Prestige_Impression( Guid iD, int identity, int type, string content, DateTime createdDate, Guid? memberID, Guid? carItemID, Guid carMainID )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Type = type;
			this.Content = content;
			this.CreatedDate = createdDate;
			this.MemberID = memberID;
			this.CarItemID = carItemID;
			this.CarMainID = carMainID;
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
        /// 印象类型(0-优点，1-缺点)
        /// </summary>
		public virtual int Type { get; set; }
        /// <summary>
        /// 印象内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
		public virtual Guid? MemberID { get; set; }
        /// <summary>
        /// 车款ID
        /// </summary>
		public virtual Guid? CarItemID { get; set; }
        /// <summary>
        /// 车型ID
        /// </summary>
		public virtual Guid CarMainID { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 