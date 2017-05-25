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
	#region CarDistributorDto

	/// <summary>
    /// 车辆经销商
	/// CarDistributorDto data view model for mapped table 'Car_Distributor'.
	/// </summary>
	public partial class CarDistributorDto
	{
		
		#region Constructors
        
		public CarDistributorDto() { }        
        
	 
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
        public virtual CommonAddressCityDto CommonAddressCityDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<CarDistributorImageDto> CarDistributorImageDto{get;set;}
        /// <summary>
        /// 首页报价表
        /// </summary>
        public virtual IList<DisplayHomePriceChartDto> DisplayHomePriceChartDto{get;set;}
        /// <summary>
        /// 首页报价经销商广告表
        /// </summary>
        public virtual IList<DisplayHomePriceChartDistributorAdvertDto> DisplayHomePriceChartDistributorAdvertDto{get;set;}
        /// <summary>
        /// 品牌与经销商关系表
        /// </summary>
        public virtual IList<CarBrandToDistributorDto> CarBrandToDistributorDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<WebSiteDto> WebSiteDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 