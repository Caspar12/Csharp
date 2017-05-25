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
	#region T_CarTypeBig

	/// <summary>
    /// 
	/// T_CarTypeBig object for mapped table 'T_CarTypeBig'.
	/// </summary>
	public partial class T_CarTypeBig
	{
		
		#region Constructors
        
		public T_CarTypeBig() { }        
        
		public T_CarTypeBig( int carTypeBigIndex, string carTypeBigName, string carTypeBigSpell, string carTypeBigNumber, int carTypeBigBrand, decimal? minimumBoutiProport, decimal? minimumDeposit, int? carTypeBigLVIndex, string isDefaultUse, string manufacturer, string fuelClass, string displacement, string gearBox, string color, string lWH, string isSell, int? outsidepictureID, int? insidePictureID, int? spacePictureID, string videoUrl, int isLock, int click, int isMsg, int isTop, int isRed, int isHot, int isSlide, byte[] stamp )
		{
			this.CarTypeBigIndex = carTypeBigIndex;
			this.CarTypeBigName = carTypeBigName;
			this.CarTypeBigSpell = carTypeBigSpell;
			this.CarTypeBigNumber = carTypeBigNumber;
			this.CarTypeBigBrand = carTypeBigBrand;
			this.MinimumBoutiProport = minimumBoutiProport;
			this.MinimumDeposit = minimumDeposit;
			this.CarTypeBigLVIndex = carTypeBigLVIndex;
			this.IsDefaultUse = isDefaultUse;
			this.Manufacturer = manufacturer;
			this.FuelClass = fuelClass;
			this.Displacement = displacement;
			this.GearBox = gearBox;
			this.Color = color;
			this.LWH = lWH;
			this.IsSell = isSell;
			this.OutsidepictureID = outsidepictureID;
			this.InsidePictureID = insidePictureID;
			this.SpacePictureID = spacePictureID;
			this.VideoUrl = videoUrl;
			this.IsLock = isLock;
			this.Click = click;
			this.IsMsg = isMsg;
			this.IsTop = isTop;
			this.IsRed = isRed;
			this.IsHot = isHot;
			this.IsSlide = isSlide;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 大车型表索引,又称乏车型或车型
        /// </summary>
		public virtual int CarTypeBigIndex { get; set; }
        /// <summary>
        /// 大车型名,例如,宝来,高尔夫
        /// </summary>
		public virtual string CarTypeBigName { get; set; }
        /// <summary>
        /// 名称拼音码
        /// </summary>
		public virtual string CarTypeBigSpell { get; set; }
        /// <summary>
        /// 大车型编码,此编码不做主键，只为查询方便而设
        /// </summary>
		public virtual string CarTypeBigNumber { get; set; }
        /// <summary>
        /// 所属品牌
        /// </summary>
		public virtual int CarTypeBigBrand { get; set; }
        /// <summary>
        /// 最低精品收款比例
        /// </summary>
		public virtual decimal? MinimumBoutiProport { get; set; }
        /// <summary>
        /// 最低订金金额
        /// </summary>
		public virtual decimal? MinimumDeposit { get; set; }
        /// <summary>
        /// 大车型等级
        /// </summary>
		public virtual int? CarTypeBigLVIndex { get; set; }
        /// <summary>
        /// 细车没有找到对应的大车时默认使用的大车型
        /// </summary>
		public virtual string IsDefaultUse { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
		public virtual string Manufacturer { get; set; }
        /// <summary>
        /// 燃油类型
        /// </summary>
		public virtual string FuelClass { get; set; }
        /// <summary>
        /// 排量
        /// </summary>
		public virtual string Displacement { get; set; }
        /// <summary>
        /// 排挡类型;自动,手动
        /// </summary>
		public virtual string GearBox { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
		public virtual string Color { get; set; }
        /// <summary>
        /// 长宽高;例如：100*50*20
        /// </summary>
		public virtual string LWH { get; set; }
        /// <summary>
        /// 是否销售
        /// </summary>
		public virtual string IsSell { get; set; }
        /// <summary>
        /// 外观图片ID,根据图片ID，获取图片表的子表下的所有图片，下面图片ID用处相同
        /// </summary>
		public virtual int? OutsidepictureID { get; set; }
        /// <summary>
        /// 内饰图片ID
        /// </summary>
		public virtual int? InsidePictureID { get; set; }
        /// <summary>
        /// 空间图片ID
        /// </summary>
		public virtual int? SpacePictureID { get; set; }
        /// <summary>
        /// 视频地址
        /// </summary>
		public virtual string VideoUrl { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
		public virtual int IsLock { get; set; }
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
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_CarBrand T_CarBrand{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_CarTypeBigLv T_CarTypeBigLv{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_CarType> T_CarType{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_UsedCarBuy> T_UsedCarBuy{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_UsedCarSell> T_UsedCarSell{get;set;}


		#endregion
	 
	}
	#endregion
}
 