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
	#region RepairOrdersDto

	/// <summary>
    /// 维修消费记录
	/// RepairOrdersDto data view model for mapped table 'Repair_Orders'.
	/// </summary>
	public partial class RepairOrdersDto
	{
		
		#region Constructors
        
		public RepairOrdersDto() { }        
        
	 
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
        /// 站点Id
        /// </summary>
		public virtual Guid WebSiteId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CarNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CarId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Payment { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string YYID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int GuestIndex { get; set; }
        
        /// <summary>
        /// 会员车辆信息
        /// </summary>            
        public virtual MemberCarInfoDto MemberCarInfoDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TGuestDto TGuestDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteDto WebSiteDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 