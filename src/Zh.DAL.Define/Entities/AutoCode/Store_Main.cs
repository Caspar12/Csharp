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
	#region Store_Main

	/// <summary>
    /// 
	/// Store_Main object for mapped table 'Store_Main'.
	/// </summary>
	public partial class Store_Main
	{
		
		#region Constructors
        
		public Store_Main() { }        
        
		public Store_Main( Guid iD, int identity, string name, string description, string contact, string address, decimal? longitude, decimal? latitude, string imageUrl, Guid levelId, Guid typeId, string weiXinQRCodeImageUrl, Guid? brandId, string contacter, string contacterPhone )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Description = description;
			this.Contact = contact;
			this.Address = address;
			this.Longitude = longitude;
			this.Latitude = latitude;
			this.ImageUrl = imageUrl;
			this.LevelId = levelId;
			this.TypeId = typeId;
			this.WeiXinQRCodeImageUrl = weiXinQRCodeImageUrl;
			this.BrandId = brandId;
			this.Contacter = contacter;
			this.ContacterPhone = contacterPhone;
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
        /// 活动名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid LevelId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string WeiXinQRCodeImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? BrandId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ContacterPhone { get; set; }
        
        
        /// <summary>
        /// 抽象关系表
        /// </summary>
        public virtual IList<Car_MainToStore_MainRef> Car_MainToStore_MainRef{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CWX_RepairOrder> CWX_RepairOrder{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Store_MainBrand> Store_MainBrand{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Store_MainGoodCar> Store_MainGoodCar{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Store_MainImage> Store_MainImage{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Store_OrderDrivingTest> Store_OrderDrivingTest{get;set;}


		#endregion
	 
	}
	#endregion
}
 