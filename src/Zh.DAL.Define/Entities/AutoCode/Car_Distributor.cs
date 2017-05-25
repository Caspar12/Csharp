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
	#region Car_Distributor

	/// <summary>
    /// 车辆经销商
	/// Car_Distributor object for mapped table 'Car_Distributor'.
	/// </summary>
	public partial class Car_Distributor
	{
		
		#region Constructors
        
		public Car_Distributor() { }        
        
		public Car_Distributor( Guid iD, int identity, string name, string siteUrl, string telNum, string mobilePhonNum, string address, int order, int? cityID, string longitude, string latitude, Guid? imageID, bool isFlagship, string shortName, string description )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.SiteUrl = siteUrl;
			this.TelNum = telNum;
			this.MobilePhonNum = mobilePhonNum;
			this.Address = address;
			this.Order = order;
			this.CityID = cityID;
			this.Longitude = longitude;
			this.Latitude = latitude;
			this.ImageID = imageID;
			this.IsFlagship = isFlagship;
			this.ShortName = shortName;
			this.Description = description;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 官网
        /// </summary>
		public virtual string SiteUrl { get; set; }
        /// <summary>
        /// 固话
        /// </summary>
		public virtual string TelNum { get; set; }
        /// <summary>
        /// 移动电话
        /// </summary>
		public virtual string MobilePhonNum { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
		public virtual string Address { get; set; }
        /// <summary>
        /// 顺序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 所在城市ID
        /// </summary>
		public virtual int? CityID { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
		public virtual string Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
		public virtual string Latitude { get; set; }
        /// <summary>
        /// 经销商图片
        /// </summary>
		public virtual Guid? ImageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsFlagship { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual Common_Address_City Common_Address_City{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Car_DistributorImage> Car_DistributorImage{get;set;}
        /// <summary>
        /// 首页报价表
        /// </summary>
        public virtual IList<Display_HomePriceChart> Display_HomePriceChart{get;set;}
        /// <summary>
        /// 首页报价经销商广告表
        /// </summary>
        public virtual IList<Display_HomePriceChartDistributorAdvert> Display_HomePriceChartDistributorAdvert{get;set;}
        /// <summary>
        /// 品牌与经销商关系表
        /// </summary>
        public virtual IList<Car_BrandToDistributor> Car_BrandToDistributor{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<WebSite> WebSite{get;set;}


		#endregion
	 
	}
	#endregion
}
 