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
	#region dt_Advertising

	/// <summary>
    /// 
	/// dt_Advertising object for mapped table 'dt_Advertising'.
	/// </summary>
	public partial class dt_Advertising
	{
		
		#region Constructors
        
		public dt_Advertising() { }        
        
		public dt_Advertising( int id, string title, int adType, string adRemark, int adNum, decimal adPrice, int adWidth, int adHeight, string adTarget, byte[] stamp )
		{
			this.Id = id;
			this.Title = title;
			this.AdType = adType;
			this.AdRemark = adRemark;
			this.AdNum = adNum;
			this.AdPrice = adPrice;
			this.AdWidth = adWidth;
			this.AdHeight = adHeight;
			this.AdTarget = adTarget;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 自增ID PK
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 广告位名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 广告位类型
        /// </summary>
		public virtual int AdType { get; set; }
        /// <summary>
        /// 广告位说明
        /// </summary>
		public virtual string AdRemark { get; set; }
        /// <summary>
        /// 显示广告数
        /// </summary>
		public virtual int AdNum { get; set; }
        /// <summary>
        /// 广告位价格
        /// </summary>
		public virtual decimal AdPrice { get; set; }
        /// <summary>
        /// 广告位宽度
        /// </summary>
		public virtual int AdWidth { get; set; }
        /// <summary>
        /// 广告位高度
        /// </summary>
		public virtual int AdHeight { get; set; }
        /// <summary>
        /// 链接目标，新窗口、原窗口
        /// </summary>
		public virtual string AdTarget { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<dt_Adbanner> dt_Adbanner{get;set;}


		#endregion
	 
	}
	#endregion
}
 