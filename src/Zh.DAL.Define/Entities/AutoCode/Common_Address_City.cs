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
	#region Common_Address_City

	/// <summary>
    /// 市区
	/// Common_Address_City object for mapped table 'Common_Address_City'.
	/// </summary>
	public partial class Common_Address_City
	{
		
		#region Constructors
        
		public Common_Address_City() { }        
        
		public Common_Address_City( int iD, int order, string name, int provinceID )
		{
			this.ID = iD;
			this.Order = order;
			this.Name = name;
			this.ProvinceID = provinceID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 顺序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
		public virtual int ProvinceID { get; set; }
        
        /// <summary>
        /// 省份
        /// </summary>            
        public virtual Common_Address_Province Common_Address_Province{get;set;}
        
        /// <summary>
        /// 品牌与经销商关系表
        /// </summary>
        public virtual IList<Car_BrandToDistributor> Car_BrandToDistributor{get;set;}
        /// <summary>
        /// 镇级
        /// </summary>
        public virtual IList<Common_Address_Area> Common_Address_Area{get;set;}
        /// <summary>
        /// 首页报价表
        /// </summary>
        public virtual IList<Display_HomePriceChart> Display_HomePriceChart{get;set;}
        /// <summary>
        /// 首页报价经销商广告表
        /// </summary>
        public virtual IList<Display_HomePriceChartDistributorAdvert> Display_HomePriceChartDistributorAdvert{get;set;}
        /// <summary>
        /// 车辆经销商
        /// </summary>
        public virtual IList<Car_Distributor> Car_Distributor{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Enquiry> Car_Enquiry{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Exchange> Car_Exchange{get;set;}
        /// <summary>
        /// 热门城市
        /// </summary>
        public virtual IList<Config_HotCity> Config_HotCity{get;set;}
        /// <summary>
        /// 会员资料表
        /// </summary>
        public virtual IList<Member_Profile> Member_Profile{get;set;}


		#endregion
	 
	}
	#endregion
}
 