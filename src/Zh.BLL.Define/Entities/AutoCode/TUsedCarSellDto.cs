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
	#region TUsedCarSellDto

	/// <summary>
    /// 
	/// TUsedCarSellDto data view model for mapped table 'T_UsedCarSell'.
	/// </summary>
	public partial class TUsedCarSellDto
	{
		
		#region Constructors
        
		public TUsedCarSellDto() { }        
        
	 
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
        public virtual TCarTypeDto TCarTypeDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TCarTypeBigDto TCarTypeBigDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 