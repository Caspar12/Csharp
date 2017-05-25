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
	#region Car_Brand

	/// <summary>
    /// 车辆品牌
	/// Car_Brand object for mapped table 'Car_Brand'.
	/// </summary>
	public partial class Car_Brand
	{
		
		#region Constructors
        
		public Car_Brand() { }        
        
		public Car_Brand( Guid iD, string name, string introduction, string firstChar, int identity, Guid? parentID, bool isShowBrandMenu, Guid? imageID, int countryType, int order, string siteUrl, string countryName, bool isShowFront, bool? isShowFrontList, int? frontOrder )
		{
			this.ID = iD;
			this.Name = name;
			this.Introduction = introduction;
			this.FirstChar = firstChar;
			this.Identity = identity;
			this.ParentID = parentID;
			this.IsShowBrandMenu = isShowBrandMenu;
			this.ImageID = imageID;
			this.CountryType = countryType;
			this.Order = order;
			this.SiteUrl = siteUrl;
			this.CountryName = countryName;
			this.IsShowFront = isShowFront;
			this.IsShowFrontList = isShowFrontList;
			this.FrontOrder = frontOrder;
		}
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
        public virtual Car_Brand Car_Brand2{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Car_BrandImage> Car_BrandImage{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Article_MainToBrand> Article_MainToBrand{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public virtual IList<Car_Brand> Car_Brand3{get;set;}
        /// <summary>
        /// 品牌与经销商关系表
        /// </summary>
        public virtual IList<Car_BrandToDistributor> Car_BrandToDistributor{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>
        public virtual IList<Car_Main> Car_Main{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<Member_CarInfo> Member_CarInfo{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Store_MainBrand> Store_MainBrand{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPrice_CategoryConnectCarBrand> TalkPrice_CategoryConnectCarBrand{get;set;}


		#endregion
	 
	}
	#endregion
}
 