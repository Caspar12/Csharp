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
	#region Prestige_Post

	/// <summary>
    /// 车辆口碑帖子
	/// Prestige_Post object for mapped table 'Prestige_Post'.
	/// </summary>
	public partial class Prestige_Post
	{
		
		#region Constructors
        
		public Prestige_Post() { }        
        
		public Prestige_Post( Guid iD, DateTime createdDate, int identity, Guid carMainID, Guid carItemID, Guid memberID, int wholeScore, string wholeComment, int appearanceScore, string appearanceComment, int internalViewScore, string inernalViewComment, int spaceScore, string spaceComment, int powerScore, string powerComment, int controlScore, string controlComment, int configScore, string configComment, int comfortLevelScore, string comfortLevelComment, int costPerformanceScore, string costPerformanceComment, DateTime? buyDateTime, decimal? carPrice, decimal? currentKM, decimal oilWear, decimal? carCostPerMonth )
		{
			this.ID = iD;
			this.CreatedDate = createdDate;
			this.Identity = identity;
			this.CarMainID = carMainID;
			this.CarItemID = carItemID;
			this.MemberID = memberID;
			this.WholeScore = wholeScore;
			this.WholeComment = wholeComment;
			this.AppearanceScore = appearanceScore;
			this.AppearanceComment = appearanceComment;
			this.InternalViewScore = internalViewScore;
			this.InernalViewComment = inernalViewComment;
			this.SpaceScore = spaceScore;
			this.SpaceComment = spaceComment;
			this.PowerScore = powerScore;
			this.PowerComment = powerComment;
			this.ControlScore = controlScore;
			this.ControlComment = controlComment;
			this.ConfigScore = configScore;
			this.ConfigComment = configComment;
			this.ComfortLevelScore = comfortLevelScore;
			this.ComfortLevelComment = comfortLevelComment;
			this.CostPerformanceScore = costPerformanceScore;
			this.CostPerformanceComment = costPerformanceComment;
			this.BuyDateTime = buyDateTime;
			this.CarPrice = carPrice;
			this.CurrentKM = currentKM;
			this.OilWear = oilWear;
			this.CarCostPerMonth = carCostPerMonth;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 车型ID
        /// </summary>
		public virtual Guid CarMainID { get; set; }
        /// <summary>
        /// 车款ID
        /// </summary>
		public virtual Guid CarItemID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
		public virtual Guid MemberID { get; set; }
        /// <summary>
        /// 总评分
        /// </summary>
		public virtual int WholeScore { get; set; }
        /// <summary>
        /// 总评价
        /// </summary>
		public virtual string WholeComment { get; set; }
        /// <summary>
        /// 外观评分
        /// </summary>
		public virtual int AppearanceScore { get; set; }
        /// <summary>
        /// 外观评价
        /// </summary>
		public virtual string AppearanceComment { get; set; }
        /// <summary>
        /// 内饰评分
        /// </summary>
		public virtual int InternalViewScore { get; set; }
        /// <summary>
        /// 内饰评价
        /// </summary>
		public virtual string InernalViewComment { get; set; }
        /// <summary>
        /// 空间评分
        /// </summary>
		public virtual int SpaceScore { get; set; }
        /// <summary>
        /// 空间评价
        /// </summary>
		public virtual string SpaceComment { get; set; }
        /// <summary>
        /// 动力评分
        /// </summary>
		public virtual int PowerScore { get; set; }
        /// <summary>
        /// 动力评价
        /// </summary>
		public virtual string PowerComment { get; set; }
        /// <summary>
        /// 控制评分
        /// </summary>
		public virtual int ControlScore { get; set; }
        /// <summary>
        /// 控制评价
        /// </summary>
		public virtual string ControlComment { get; set; }
        /// <summary>
        /// 油耗评分
        /// </summary>
		public virtual int ConfigScore { get; set; }
        /// <summary>
        /// 油耗评价
        /// </summary>
		public virtual string ConfigComment { get; set; }
        /// <summary>
        /// 舒适度评分
        /// </summary>
		public virtual int ComfortLevelScore { get; set; }
        /// <summary>
        /// 舒适度评价
        /// </summary>
		public virtual string ComfortLevelComment { get; set; }
        /// <summary>
        /// 性价比评分
        /// </summary>
		public virtual int CostPerformanceScore { get; set; }
        /// <summary>
        /// 性价比评价
        /// </summary>
		public virtual string CostPerformanceComment { get; set; }
        /// <summary>
        /// 购车时间
        /// </summary>
		public virtual DateTime? BuyDateTime { get; set; }
        /// <summary>
        /// 裸车价格(万元)
        /// </summary>
		public virtual decimal? CarPrice { get; set; }
        /// <summary>
        /// 当前里程(公里)
        /// </summary>
		public virtual decimal? CurrentKM { get; set; }
        /// <summary>
        /// 油耗(L/100km)
        /// </summary>
		public virtual decimal OilWear { get; set; }
        /// <summary>
        /// 养车费用(元/月)
        /// </summary>
		public virtual decimal? CarCostPerMonth { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        
        /// <summary>
        /// 口碑收藏表
        /// </summary>
        public virtual IList<Prestige_PostCollection> Prestige_PostCollection{get;set;}
        /// <summary>
        /// 口碑图片表
        /// </summary>
        public virtual IList<Prestige_PostImage> Prestige_PostImage{get;set;}


		#endregion
	 
	}
	#endregion
}
 