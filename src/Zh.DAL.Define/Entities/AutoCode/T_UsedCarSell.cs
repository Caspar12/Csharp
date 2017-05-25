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
	#region T_UsedCarSell

	/// <summary>
    /// 
	/// T_UsedCarSell object for mapped table 'T_UsedCarSell'.
	/// </summary>
	public partial class T_UsedCarSell
	{
		
		#region Constructors
        
		public T_UsedCarSell() { }        
        
		public T_UsedCarSell( decimal usedCarSellIndex, string sellProvince, string sellCity, string sellArea, int? usedCarBrand, int? usedCarTypeBigIndex, int? carTypeIndex, string usedCarColor, DateTime? firstCarNumberDate, string usedCarUseKind, int? usedCarMileage, DateTime? audtingYearDate, DateTime? insuranceDate, string usedCarIntroduction, string usedCarConfig, decimal? sellPrice, int? isHaveNumberSell, int? isMaintainLog, string usedCarStatus, string buyerName, string buyerSex, string buyerHandTel, DateTime? validityDate, int? isAudting, string traceState, int? traceEmployeeID, string traceEmployeeName, DateTime? traceAllotDate, string title, DateTime? pushTime, string fromType, byte[] stamp, string changeProcedure, int? mainPicUrl, int? otherPicUrl )
		{
			this.UsedCarSellIndex = usedCarSellIndex;
			this.SellProvince = sellProvince;
			this.SellCity = sellCity;
			this.SellArea = sellArea;
			this.UsedCarBrand = usedCarBrand;
			this.UsedCarTypeBigIndex = usedCarTypeBigIndex;
			this.CarTypeIndex = carTypeIndex;
			this.UsedCarColor = usedCarColor;
			this.FirstCarNumberDate = firstCarNumberDate;
			this.UsedCarUseKind = usedCarUseKind;
			this.UsedCarMileage = usedCarMileage;
			this.AudtingYearDate = audtingYearDate;
			this.InsuranceDate = insuranceDate;
			this.UsedCarIntroduction = usedCarIntroduction;
			this.UsedCarConfig = usedCarConfig;
			this.SellPrice = sellPrice;
			this.IsHaveNumberSell = isHaveNumberSell;
			this.IsMaintainLog = isMaintainLog;
			this.UsedCarStatus = usedCarStatus;
			this.BuyerName = buyerName;
			this.BuyerSex = buyerSex;
			this.BuyerHandTel = buyerHandTel;
			this.ValidityDate = validityDate;
			this.IsAudting = isAudting;
			this.TraceState = traceState;
			this.TraceEmployeeID = traceEmployeeID;
			this.TraceEmployeeName = traceEmployeeName;
			this.TraceAllotDate = traceAllotDate;
			this.Title = title;
			this.PushTime = pushTime;
			this.FromType = fromType;
			this.Stamp = stamp;
			this.ChangeProcedure = changeProcedure;
			this.MainPicUrl = mainPicUrl;
			this.OtherPicUrl = otherPicUrl;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 二手车销售信息发布表索引
        /// </summary>
		public virtual decimal UsedCarSellIndex { get; set; }
        /// <summary>
        /// 所在省份
        /// </summary>
		public virtual string SellProvince { get; set; }
        /// <summary>
        /// 所在城市
        /// </summary>
		public virtual string SellCity { get; set; }
        /// <summary>
        /// 所在区域
        /// </summary>
		public virtual string SellArea { get; set; }
        /// <summary>
        /// 车型品牌
        /// </summary>
		public virtual int? UsedCarBrand { get; set; }
        /// <summary>
        /// 车系
        /// </summary>
		public virtual int? UsedCarTypeBigIndex { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
		public virtual int? CarTypeIndex { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
		public virtual string UsedCarColor { get; set; }
        /// <summary>
        /// 首次上牌日期
        /// </summary>
		public virtual DateTime? FirstCarNumberDate { get; set; }
        /// <summary>
        /// 用途,非运营  运营  营转非  租赁
        /// </summary>
		public virtual string UsedCarUseKind { get; set; }
        /// <summary>
        /// 行驶里程
        /// </summary>
		public virtual int? UsedCarMileage { get; set; }
        /// <summary>
        /// 年审时间
        /// </summary>
		public virtual DateTime? AudtingYearDate { get; set; }
        /// <summary>
        /// 保险时间
        /// </summary>
		public virtual DateTime? InsuranceDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
		public virtual string UsedCarIntroduction { get; set; }
        /// <summary>
        /// 车型配置
        /// </summary>
		public virtual string UsedCarConfig { get; set; }
        /// <summary>
        /// 出售价格
        /// </summary>
		public virtual decimal? SellPrice { get; set; }
        /// <summary>
        /// 是否带牌销售
        /// </summary>
		public virtual int? IsHaveNumberSell { get; set; }
        /// <summary>
        /// 是否维修保养记录
        /// </summary>
		public virtual int? IsMaintainLog { get; set; }
        /// <summary>
        /// 车况,类似新车  很好  一般
        /// </summary>
		public virtual string UsedCarStatus { get; set; }
        /// <summary>
        /// 姓名,意向购车人姓名
        /// </summary>
		public virtual string BuyerName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
		public virtual string BuyerSex { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
		public virtual string BuyerHandTel { get; set; }
        /// <summary>
        /// 有效期,信息有效期
        /// </summary>
		public virtual DateTime? ValidityDate { get; set; }
        /// <summary>
        /// 是否审核,0未审核1已审核
        /// </summary>
		public virtual int? IsAudting { get; set; }
        /// <summary>
        /// 跟进状态,新建、跟进中、暂不处理、已完成
        /// </summary>
		public virtual string TraceState { get; set; }
        /// <summary>
        /// 跟进人ID
        /// </summary>
		public virtual int? TraceEmployeeID { get; set; }
        /// <summary>
        /// 跟进人名称
        /// </summary>
		public virtual string TraceEmployeeName { get; set; }
        /// <summary>
        /// 分配时间,分配跟进员工的时间,如果被重新分配则取最后一次被分配的时间
        /// </summary>
		public virtual DateTime? TraceAllotDate { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime? PushTime { get; set; }
        /// <summary>
        /// 发布来源,个人,经销商
        /// </summary>
		public virtual string FromType { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 过户手续,齐全,不齐全
        /// </summary>
		public virtual string ChangeProcedure { get; set; }
        /// <summary>
        /// 封面图片
        /// </summary>
		public virtual int? MainPicUrl { get; set; }
        /// <summary>
        /// 其他图片
        /// </summary>
		public virtual int? OtherPicUrl { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_CarType T_CarType{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_CarTypeBig T_CarTypeBig{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 