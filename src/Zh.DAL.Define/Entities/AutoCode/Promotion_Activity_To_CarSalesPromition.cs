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
	#region Promotion_Activity_To_CarSalesPromition

	/// <summary>
    /// 
	/// Promotion_Activity_To_CarSalesPromition object for mapped table 'Promotion_Activity_To_CarSalesPromition'.
	/// </summary>
	public partial class Promotion_Activity_To_CarSalesPromition
	{
		
		#region Constructors
        
		public Promotion_Activity_To_CarSalesPromition() { }        
        
		public Promotion_Activity_To_CarSalesPromition( Guid iD, int? t_CarSalesPromotionID, Guid? promotion_ActivityID, Guid webSiteID )
		{
			this.ID = iD;
			this.T_CarSalesPromotionID = t_CarSalesPromotionID;
			this.Promotion_ActivityID = promotion_ActivityID;
			this.WebSiteID = webSiteID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? T_CarSalesPromotionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? Promotion_ActivityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid WebSiteID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Promotion_Activity Promotion_Activity{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 