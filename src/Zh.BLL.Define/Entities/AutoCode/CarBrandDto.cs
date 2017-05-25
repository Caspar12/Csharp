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
	#region CarBrandDto

	/// <summary>
    /// 车辆品牌
	/// CarBrandDto data view model for mapped table 'Car_Brand'.
	/// </summary>
	public partial class CarBrandDto
	{
		
		#region Constructors
        
		public CarBrandDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 介绍
        /// </summary>
		public virtual string Introduction { get; set; }
        /// <summary>
        /// 首字母
        /// </summary>
		public virtual string FirstChar { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 父ID
        /// </summary>
		public virtual Guid? ParentID { get; set; }
        /// <summary>
        /// 是否显示在品牌菜单
        /// </summary>
		public virtual bool IsShowBrandMenu { get; set; }
        /// <summary>
        /// 图片ID
        /// </summary>
		public virtual Guid? ImageID { get; set; }
        /// <summary>
        /// 欧美(0)或日韩(1)
        /// </summary>
		public virtual int CountryType { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 官网
        /// </summary>
		public virtual string SiteUrl { get; set; }
        /// <summary>
        /// 国家名称
        /// </summary>
		public virtual string CountryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsShowFrontList { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? FrontOrder { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual CarBrandDto CarBrandDto2{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<CarBrandImageDto> CarBrandImageDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<ArticleMainToBrandDto> ArticleMainToBrandDto{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public virtual IList<CarBrandDto> CarBrandDto3{get;set;}
        /// <summary>
        /// 品牌与经销商关系表
        /// </summary>
        public virtual IList<CarBrandToDistributorDto> CarBrandToDistributorDto{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>
        public virtual IList<CarMainDto> CarMainDto{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<MemberCarInfoDto> MemberCarInfoDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<StoreMainBrandDto> StoreMainBrandDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPriceCategoryConnectCarBrandDto> TalkPriceCategoryConnectCarBrandDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 