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
	#region Store_MainBrand

	/// <summary>
    /// 
	/// Store_MainBrand object for mapped table 'Store_MainBrand'.
	/// </summary>
	public partial class Store_MainBrand
	{
		
		#region Constructors
        
		public Store_MainBrand() { }        
        
		public Store_MainBrand( Guid iD, Guid storeMainId, Guid brandId )
		{
			this.ID = iD;
			this.StoreMainId = storeMainId;
			this.BrandId = brandId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid StoreMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid BrandId { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual Car_Brand Car_Brand{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Store_Main Store_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 