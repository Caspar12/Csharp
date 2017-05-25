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
	#region Site_CarImage

	/// <summary>
    /// 汽车之家关系表
	/// Site_CarImage object for mapped table 'Site_CarImage'.
	/// </summary>
	public partial class Site_CarImage
	{
		
		#region Constructors
        
		public Site_CarImage() { }        
        
		public Site_CarImage( Guid iD, int identity, Guid webSiteId, int carTypeBigIndex, int order, Guid? carMainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.WebSiteId = webSiteId;
			this.CarTypeBigIndex = carTypeBigIndex;
			this.Order = order;
			this.CarMainId = carMainId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 站点Id
        /// </summary>
		public virtual Guid WebSiteId { get; set; }
        /// <summary>
        /// 站点车型Id
        /// </summary>
		public virtual int CarTypeBigIndex { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 车型Id
        /// </summary>
		public virtual Guid? CarMainId { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 