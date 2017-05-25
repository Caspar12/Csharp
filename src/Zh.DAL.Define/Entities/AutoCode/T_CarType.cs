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
	#region T_CarType

	/// <summary>
    /// 
	/// T_CarType object for mapped table 'T_CarType'.
	/// </summary>
	public partial class T_CarType
	{
		
		#region Constructors
        
		public T_CarType() { }        
        
		public T_CarType( int carTypeIndex, string carTypeName, string carTypeSpell, int carTypeBigIndex, string carTypeModel, string yieldID, string displacement, string gearBox, decimal? limitPrice, decimal distriPrice, DateTime? listingDate, DateTime? stopDate, string color, string remark, int clickCount, byte[] stamp )
		{
			this.CarTypeIndex = carTypeIndex;
			this.CarTypeName = carTypeName;
			this.CarTypeSpell = carTypeSpell;
			this.CarTypeBigIndex = carTypeBigIndex;
			this.CarTypeModel = carTypeModel;
			this.YieldID = yieldID;
			this.Displacement = displacement;
			this.GearBox = gearBox;
			this.LimitPrice = limitPrice;
			this.DistriPrice = distriPrice;
			this.ListingDate = listingDate;
			this.StopDate = stopDate;
			this.Color = color;
			this.Remark = remark;
			this.ClickCount = clickCount;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 细车型表索引,精确到具体的排量等
        /// </summary>
		public virtual int CarTypeIndex { get; set; }
        /// <summary>
        /// 细车型名,比如：exi MT
        /// </summary>
		public virtual string CarTypeName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
		public virtual string CarTypeSpell { get; set; }
        /// <summary>
        /// 所属大车型,大车型,比如：宝来
        /// </summary>
		public virtual int CarTypeBigIndex { get; set; }
        /// <summary>
        /// 车型代码,用于国家的公告,上牌时用于登记。一个大车型可能对应多个细车型代码
        /// </summary>
		public virtual string CarTypeModel { get; set; }
        /// <summary>
        /// 生产代码
        /// </summary>
		public virtual string YieldID { get; set; }
        /// <summary>
        /// 排量
        /// </summary>
		public virtual string Displacement { get; set; }
        /// <summary>
        /// 变速箱,手动、自动、无极变速、手自一体
        /// </summary>
		public virtual string GearBox { get; set; }
        /// <summary>
        /// 车型限价
        /// </summary>
		public virtual decimal? LimitPrice { get; set; }
        /// <summary>
        /// 车辆经销价
        /// </summary>
		public virtual decimal DistriPrice { get; set; }
        /// <summary>
        /// 上市时间
        /// </summary>
		public virtual DateTime? ListingDate { get; set; }
        /// <summary>
        /// 停产日期
        /// </summary>
		public virtual DateTime? StopDate { get; set; }
        /// <summary>
        /// 颜色,是否要将年份/颜色/排量/变速箱提取出来单独建表?
        /// </summary>
		public virtual string Color { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 点击次数，用于构建关注车型排行榜
        /// </summary>
		public virtual int ClickCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_CarTypeBig T_CarTypeBig{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_UsedCarSell> T_UsedCarSell{get;set;}


		#endregion
	 
	}
	#endregion
}
 