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
	#region Display_HomePriceChartDistributorAdvert

	/// <summary>
    /// 首页报价经销商广告表
	/// Display_HomePriceChartDistributorAdvert object for mapped table 'Display_HomePriceChartDistributorAdvert'.
	/// </summary>
	public partial class Display_HomePriceChartDistributorAdvert
	{
		
		#region Constructors
        
		public Display_HomePriceChartDistributorAdvert() { }        
        
		public Display_HomePriceChartDistributorAdvert( Guid iD, Guid distributorID, int sort, Guid typeId, int? cityId, bool? isShowNew )
		{
			this.ID = iD;
			this.DistributorID = distributorID;
			this.Sort = sort;
			this.TypeId = typeId;
			this.CityId = cityId;
			this.IsShowNew = isShowNew;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 经销商Id
        /// </summary>
		public virtual Guid DistributorID { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? CityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsShowNew { get; set; }
        
        /// <summary>
        /// 车辆经销商
        /// </summary>            
        public virtual Car_Distributor Car_Distributor{get;set;}
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual Common_Address_City Common_Address_City{get;set;}
        /// <summary>
        /// 首页报价类型表
        /// </summary>            
        public virtual Display_HomePriceChartType Display_HomePriceChartType{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 