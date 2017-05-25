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
	#region TActivityDto

	/// <summary>
    /// 
	/// TActivityDto data view model for mapped table 'T_Activity'.
	/// </summary>
	public partial class TActivityDto
	{
		
		#region Constructors
        
		public TActivityDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 活动表索引,目前仅做自驾游活动
        /// </summary>
		public virtual decimal ActivityIndex { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
		public virtual string ActivityName { get; set; }
        /// <summary>
        /// 活动发起人 /方
        /// </summary>
		public virtual string ActivityPromoter { get; set; }
        /// <summary>
        /// 活动类型,自驾游,比赛
        /// </summary>
		public virtual string ActivityType { get; set; }
        /// <summary>
        /// 活动对象:团体,个人。
        /// </summary>
		public virtual string ActivityObject { get; set; }
        /// <summary>
        /// 活动发表时间,即发表这条信息的时间
        /// </summary>
		public virtual DateTime ActivityAddTime { get; set; }
        /// <summary>
        /// 活动起始时间
        /// </summary>
		public virtual DateTime ActivityBeginDate { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
		public virtual DateTime ActivityEndDate { get; set; }
        /// <summary>
        /// 活动地点
        /// </summary>
		public virtual string ActivityArea { get; set; }
        /// <summary>
        /// 活动状态,新建、已审核、报名中、进行中、已完成
        /// </summary>
		public virtual string ActivityState { get; set; }
        /// <summary>
        /// 放在首页展示的图片url,仅一张
        /// </summary>
		public virtual string MainPicture { get; set; }
        /// <summary>
        /// 活动图片ID,关联图片表中的ID，可加载出N张图片
        /// </summary>
		public virtual int? ActivityPicuteID { get; set; }
        /// <summary>
        /// 活动介绍
        /// </summary>
		public virtual string ActivityiIntroduce { get; set; }
        /// <summary>
        /// 活动路线,例如：济南 - 青岛 - 台湾 - 福州 - 济南
        /// </summary>
		public virtual string ActivityPath { get; set; }
        /// <summary>
        /// 出发地
        /// </summary>
		public virtual string DepartPlace { get; set; }
        /// <summary>
        /// 目的地
        /// </summary>
		public virtual string DestinationPlace { get; set; }
        /// <summary>
        /// 里程
        /// </summary>
		public virtual string Mileage { get; set; }
        /// <summary>
        /// 道路类型,国道、其他
        /// </summary>
		public virtual string RoadClass { get; set; }
        /// <summary>
        /// 行程天数
        /// </summary>
		public virtual decimal? RouteDays { get; set; }
        /// <summary>
        /// 过路费
        /// </summary>
		public virtual decimal? RoadExpense { get; set; }
        /// <summary>
        /// 燃油费
        /// </summary>
		public virtual decimal? FuelExpense { get; set; }
        /// <summary>
        /// 其他费用
        /// </summary>
		public virtual decimal? OtherExpense { get; set; }
        /// <summary>
        /// 点击次数
        /// </summary>
		public virtual int Click { get; set; }
        /// <summary>
        /// 是否允许评论,0不允许1允许
        /// </summary>
		public virtual int IsMsg { get; set; }
        /// <summary>
        /// 是否置顶;显示顺序
        /// </summary>
		public virtual int IsTop { get; set; }
        /// <summary>
        /// 是否推荐;推荐栏
        /// </summary>
		public virtual int IsRed { get; set; }
        /// <summary>
        /// 是否热门;显示活动图片
        /// </summary>
		public virtual int IsHot { get; set; }
        /// <summary>
        /// 是否幻灯片;
        /// </summary>
		public virtual int IsSlide { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
		public virtual int IsLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TActivityGuestItemDto> TActivityGuestItemDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 