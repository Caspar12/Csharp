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
	#region T_GuestContact

	/// <summary>
    /// 
	/// T_GuestContact object for mapped table 'T_GuestContact'.
	/// </summary>
	public partial class T_GuestContact
	{
		
		#region Constructors
        
		public T_GuestContact() { }        
        
		public T_GuestContact( decimal guestContactIndex, int? guestIndex, decimal? operationIndex, string contactClass, DateTime? contactTime, string contactAim, int? employeeID, string employeeName, DateTime? contactNextTime, string contactNextAim, string contactType, string contactBeforeHot, string contactAfterHot, string priceContent, decimal? priceValue, string contactState, string contactResult, string contactResultCause, string guestSay, decimal? contactFee, string contactFeeUse, int? isApplyInstruction, int? isReplyInstruction, string shopID, byte[] stamp )
		{
			this.GuestContactIndex = guestContactIndex;
			this.GuestIndex = guestIndex;
			this.OperationIndex = operationIndex;
			this.ContactClass = contactClass;
			this.ContactTime = contactTime;
			this.ContactAim = contactAim;
			this.EmployeeID = employeeID;
			this.EmployeeName = employeeName;
			this.ContactNextTime = contactNextTime;
			this.ContactNextAim = contactNextAim;
			this.ContactType = contactType;
			this.ContactBeforeHot = contactBeforeHot;
			this.ContactAfterHot = contactAfterHot;
			this.PriceContent = priceContent;
			this.PriceValue = priceValue;
			this.ContactState = contactState;
			this.ContactResult = contactResult;
			this.ContactResultCause = contactResultCause;
			this.GuestSay = guestSay;
			this.ContactFee = contactFee;
			this.ContactFeeUse = contactFeeUse;
			this.IsApplyInstruction = isApplyInstruction;
			this.IsReplyInstruction = isReplyInstruction;
			this.ShopID = shopID;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 接触表索引,潜客跟进、业务回访等接触在这里记录
        /// </summary>
		public virtual decimal GuestContactIndex { get; set; }
        /// <summary>
        /// 客户ID,0表示无客户信息,潜客跟进则使用此字段
        /// </summary>
		public virtual int? GuestIndex { get; set; }
        /// <summary>
        /// 业务ID,或上级接触,0表示无业务或上级接触,业务回访则使用此字段,潜客跟进则无业务上级
        /// </summary>
		public virtual decimal? OperationIndex { get; set; }
        /// <summary>
        /// 接触类型,潜客跟进、二手车发布、二手车求购等,此字段和上面的业务ID字段可锁定某个业务
        /// </summary>
		public virtual string ContactClass { get; set; }
        /// <summary>
        /// 接触时间,本次跟进时间
        /// </summary>
		public virtual DateTime? ContactTime { get; set; }
        /// <summary>
        /// 接触目的,跟进重点
        /// </summary>
		public virtual string ContactAim { get; set; }
        /// <summary>
        /// 跟进人ID
        /// </summary>
		public virtual int? EmployeeID { get; set; }
        /// <summary>
        /// 根据人名称,根据人不一定在同一库中，因此可不用ID关联
        /// </summary>
		public virtual string EmployeeName { get; set; }
        /// <summary>
        /// 下次接触时间
        /// </summary>
		public virtual DateTime? ContactNextTime { get; set; }
        /// <summary>
        /// 下次接触目的
        /// </summary>
		public virtual string ContactNextAim { get; set; }
        /// <summary>
        /// 接触方式,电话、面访、传真、邮件、信函、会议、来访
        /// </summary>
		public virtual string ContactType { get; set; }
        /// <summary>
        /// 接触前热度,热度数字越高代表机会越大
        /// </summary>
		public virtual string ContactBeforeHot { get; set; }
        /// <summary>
        /// 接触后热度,热度数字越高代表机会越大
        /// </summary>
		public virtual string ContactAfterHot { get; set; }
        /// <summary>
        /// 报价内容
        /// </summary>
		public virtual string PriceContent { get; set; }
        /// <summary>
        /// 报价金额
        /// </summary>
		public virtual decimal? PriceValue { get; set; }
        /// <summary>
        /// 接触状态,
        /// </summary>
		public virtual string ContactState { get; set; }
        /// <summary>
        /// 接触结果,战败,成交
        /// </summary>
		public virtual string ContactResult { get; set; }
        /// <summary>
        /// 结果原因,可能更多的是战败原因
        /// </summary>
		public virtual string ContactResultCause { get; set; }
        /// <summary>
        /// 客户描述
        /// </summary>
		public virtual string GuestSay { get; set; }
        /// <summary>
        /// 接触费用,为0时就无所谓费用用途了
        /// </summary>
		public virtual decimal? ContactFee { get; set; }
        /// <summary>
        /// 费用用途,差旅/餐饮/礼品/公关
        /// </summary>
		public virtual string ContactFeeUse { get; set; }
        /// <summary>
        /// 是否申请批示,0不申请,1申请
        /// </summary>
		public virtual int? IsApplyInstruction { get; set; }
        /// <summary>
        /// 是否已回复批示,0未回复,1已回复，如果申请为0，则该字段无效
        /// </summary>
		public virtual int? IsReplyInstruction { get; set; }
        /// <summary>
        /// 店号
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_Guest T_Guest{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 