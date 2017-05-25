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
	#region T_CarItem

	/// <summary>
    /// 
	/// T_CarItem object for mapped table 'T_CarItem'.
	/// </summary>
	public partial class T_CarItem
	{
		
		#region Constructors
        
		public T_CarItem() { }        
        
		public T_CarItem( int carItemIndex, string carItemClass, string cArItemName, string carItemSpell, int mainPicUrl, int? otherPicUrl, int carItemBrand, decimal marketPrice, decimal ourPrice, int? saleCount, string brandStory, string remark, byte[] stamp )
		{
			this.CarItemIndex = carItemIndex;
			this.CarItemClass = carItemClass;
			this.CArItemName = cArItemName;
			this.CarItemSpell = carItemSpell;
			this.MainPicUrl = mainPicUrl;
			this.OtherPicUrl = otherPicUrl;
			this.CarItemBrand = carItemBrand;
			this.MarketPrice = marketPrice;
			this.OurPrice = ourPrice;
			this.SaleCount = saleCount;
			this.BrandStory = brandStory;
			this.Remark = remark;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 汽车用品索引
        /// </summary>
		public virtual int CarItemIndex { get; set; }
        /// <summary>
        /// 用品分类:内饰用品,外饰改装,汽车配件,影音电子,GPS导航仪,美容保养,清洗用品
        /// </summary>
		public virtual string CarItemClass { get; set; }
        /// <summary>
        /// 用品名称
        /// </summary>
		public virtual string CArItemName { get; set; }
        /// <summary>
        /// 名称拼音码
        /// </summary>
		public virtual string CarItemSpell { get; set; }
        /// <summary>
        /// 全景展示图,列表显示使用,规格限定?
        /// </summary>
		public virtual int MainPicUrl { get; set; }
        /// <summary>
        /// 详细展示图
        /// </summary>
		public virtual int? OtherPicUrl { get; set; }
        /// <summary>
        /// 商品品牌
        /// </summary>
		public virtual int CarItemBrand { get; set; }
        /// <summary>
        /// 参考市场价
        /// </summary>
		public virtual decimal MarketPrice { get; set; }
        /// <summary>
        /// 商城价格
        /// </summary>
		public virtual decimal OurPrice { get; set; }
        /// <summary>
        /// 销售数量,生成热销产品
        /// </summary>
		public virtual int? SaleCount { get; set; }
        /// <summary>
        /// 品牌故事
        /// </summary>
		public virtual string BrandStory { get; set; }
        /// <summary>
        /// 其他说明
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_CarItemBrand T_CarItemBrand{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 