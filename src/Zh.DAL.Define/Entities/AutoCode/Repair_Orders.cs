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
	#region Repair_Orders

	/// <summary>
    /// 维修消费记录
	/// Repair_Orders object for mapped table 'Repair_Orders'.
	/// </summary>
	public partial class Repair_Orders
	{
		
		#region Constructors
        
		public Repair_Orders() { }        
        
		public Repair_Orders( Guid iD, int identity, Guid webSiteId, string shopId, DateTime createdTime, string carNumber, Guid? carId, decimal? balance, decimal? payment, int typeId, string yYID, int guestIndex )
		{
			this.ID = iD;
			this.Identity = identity;
			this.WebSiteId = webSiteId;
			this.ShopId = shopId;
			this.CreatedTime = createdTime;
			this.CarNumber = carNumber;
			this.CarId = carId;
			this.Balance = balance;
			this.Payment = payment;
			this.TypeId = typeId;
			this.YYID = yYID;
			this.GuestIndex = guestIndex;
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
        public virtual Member_CarInfo Member_CarInfo{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_Guest T_Guest{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 