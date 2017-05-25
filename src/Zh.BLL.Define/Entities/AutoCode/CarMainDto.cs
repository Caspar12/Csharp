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
	#region CarMainDto

	/// <summary>
    /// 车辆主表
	/// CarMainDto data view model for mapped table 'Car_Main'.
	/// </summary>
	public partial class CarMainDto
	{
		
		#region Constructors
        
		public CarMainDto() { }        
        
	 
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
        public virtual CarBrandDto CarBrandDto{get;set;}
        
        /// <summary>
        /// 车辆评论表
        /// </summary>
        public virtual IList<CarMainCommentDto> CarMainCommentDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<CarMainImageDto> CarMainImageDto{get;set;}
        /// <summary>
        /// 抽象关系表
        /// </summary>
        public virtual IList<CarMainToStoreMainRefDto> CarMainToStoreMainRefDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<CarMainVideoDto> CarMainVideoDto{get;set;}
        /// <summary>
        /// 其它重磅好车表
        /// </summary>
        public virtual IList<CarOtherGoodCarDto> CarOtherGoodCarDto{get;set;}
        /// <summary>
        /// 其它重磅好车表
        /// </summary>
        public virtual IList<CarOtherGoodCarDto> CarOtherGoodCarDto2{get;set;}
        /// <summary>
        /// 首页报价表
        /// </summary>
        public virtual IList<DisplayHomePriceChartDto> DisplayHomePriceChartDto{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<DisplayPhotoAlbumsDto> DisplayPhotoAlbumsDto{get;set;}
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<ArticleMainDto> ArticleMainDto{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>
        public virtual IList<CarMainItemDto> CarMainItemDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MaintMainDto> MaintMainDto{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<MemberCarInfoDto> MemberCarInfoDto{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>
        public virtual IList<PrestigePostDto> PrestigePostDto{get;set;}
        /// <summary>
        /// 汽车之家关系表
        /// </summary>
        public virtual IList<SiteCarImageDto> SiteCarImageDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPriceRepairItemDto> TalkPriceRepairItemDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 