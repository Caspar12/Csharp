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
	#region TActivityGuestItemDto

	/// <summary>
    /// 
	/// TActivityGuestItemDto data view model for mapped table 'T_ActivityGuestItem'.
	/// </summary>
	public partial class TActivityGuestItemDto
	{
		
		#region Constructors
        
		public TActivityGuestItemDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 活动参与人员表
        /// </summary>
		public virtual decimal ActivityGuestItemIndex { get; set; }
        /// <summary>
        /// 活动表ID,用于关联活动主表
        /// </summary>
		public virtual decimal ActivityIndex { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
		public virtual string GuestName { get; set; }
        /// <summary>
        /// 客户电话,可支持2个电话,用,分割
        /// </summary>
		public virtual string GuestPhone { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 跟进状态,新建（即已分配）、跟进中（即有了跟进记录）、暂不处理、已完成
        /// </summary>
		public virtual string TraceState { get; set; }
        /// <summary>
        /// 跟进人ID
        /// </summary>
		public virtual int? TraceEmployeeID { get; set; }
        /// <summary>
        /// 分配时间,分配跟进员工的时间,如果被重新分配则取最后一次被分配的时间
        /// </summary>
		public virtual DateTime? TraceAllotDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual TActivityDto TActivityDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TEmployeeDto TEmployeeDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 