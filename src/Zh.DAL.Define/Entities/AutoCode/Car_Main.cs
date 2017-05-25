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
	#region Car_Main

	/// <summary>
    /// 车辆主表
	/// Car_Main object for mapped table 'Car_Main'.
	/// </summary>
	public partial class Car_Main
	{
		
		#region Constructors
        
		public Car_Main() { }        
        
		public Car_Main( Guid iD, int identity, string name, Guid? brandID, int attantionRate, string siteUrl, bool isShowFront, decimal wholeScore, int prestigeCommentCount, string introduction, bool? isShowInWeiXinGoodCar )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.BrandID = brandID;
			this.AttantionRate = attantionRate;
			this.SiteUrl = siteUrl;
			this.IsShowFront = isShowFront;
			this.WholeScore = wholeScore;
			this.PrestigeCommentCount = prestigeCommentCount;
			this.Introduction = introduction;
			this.IsShowInWeiXinGoodCar = isShowInWeiXinGoodCar;
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
        /// 显示名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
		public virtual Guid? BrandID { get; set; }
        /// <summary>
        /// 关注度
        /// </summary>
		public virtual int AttantionRate { get; set; }
        /// <summary>
        /// 官网
        /// </summary>
		public virtual string SiteUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal WholeScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int PrestigeCommentCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Introduction { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsShowInWeiXinGoodCar { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual Car_Brand Car_Brand{get;set;}
        
        /// <summary>
        /// 车辆评论表
        /// </summary>
        public virtual IList<Car_Main_Comment> Car_Main_Comment{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Car_Main_Image> Car_Main_Image{get;set;}
        /// <summary>
        /// 抽象关系表
        /// </summary>
        public virtual IList<Car_MainToStore_MainRef> Car_MainToStore_MainRef{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Car_Main_Video> Car_Main_Video{get;set;}
        /// <summary>
        /// 其它重磅好车表
        /// </summary>
        public virtual IList<Car_OtherGoodCar> Car_OtherGoodCar{get;set;}
        /// <summary>
        /// 其它重磅好车表
        /// </summary>
        public virtual IList<Car_OtherGoodCar> Car_OtherGoodCar2{get;set;}
        /// <summary>
        /// 首页报价表
        /// </summary>
        public virtual IList<Display_HomePriceChart> Display_HomePriceChart{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<Display_PhotoAlbums> Display_PhotoAlbums{get;set;}
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<Article_Main> Article_Main{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>
        public virtual IList<Car_MainItem> Car_MainItem{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Maint_Main> Maint_Main{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<Member_CarInfo> Member_CarInfo{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>
        public virtual IList<Prestige_Post> Prestige_Post{get;set;}
        /// <summary>
        /// 汽车之家关系表
        /// </summary>
        public virtual IList<Site_CarImage> Site_CarImage{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPrice_RepairItem> TalkPrice_RepairItem{get;set;}


		#endregion
	 
	}
	#endregion
}
 