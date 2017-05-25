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
	#region T_CarBrand

	/// <summary>
    /// 
	/// T_CarBrand object for mapped table 'T_CarBrand'.
	/// </summary>
	public partial class T_CarBrand
	{
		
		#region Constructors
        
		public T_CarBrand() { }        
        
		public T_CarBrand( int carBrandIndex, string brandName, string brandSpell, string brandIcon, byte[] stamp, string brandShortName, int? brandTypeID, string brandAddress, string brandServerPhone, string brandQQ, string brandWeibo )
		{
			this.CarBrandIndex = carBrandIndex;
			this.BrandName = brandName;
			this.BrandSpell = brandSpell;
			this.BrandIcon = brandIcon;
			this.Stamp = stamp;
			this.BrandShortName = brandShortName;
			this.BrandTypeID = brandTypeID;
			this.BrandAddress = brandAddress;
			this.BrandServerPhone = brandServerPhone;
			this.BrandQQ = brandQQ;
			this.BrandWeibo = brandWeibo;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 车型品牌表索引
        /// </summary>
		public virtual int CarBrandIndex { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
		public virtual string BrandName { get; set; }
        /// <summary>
        /// 品牌名称拼音码
        /// </summary>
		public virtual string BrandSpell { get; set; }
        /// <summary>
        /// 品牌图标url
        /// </summary>
		public virtual string BrandIcon { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 品牌简称
        /// </summary>
		public virtual string BrandShortName { get; set; }
        /// <summary>
        /// 品牌所属类别
        /// </summary>
		public virtual int? BrandTypeID { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
		public virtual string BrandAddress { get; set; }
        /// <summary>
        /// 服务电话
        /// </summary>
		public virtual string BrandServerPhone { get; set; }
        /// <summary>
        /// QQ号码
        /// </summary>
		public virtual string BrandQQ { get; set; }
        /// <summary>
        /// 微博
        /// </summary>
		public virtual string BrandWeibo { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_CarTypeBig> T_CarTypeBig{get;set;}


		#endregion
	 
	}
	#endregion
}
 