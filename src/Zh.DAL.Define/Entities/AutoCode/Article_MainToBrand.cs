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
	#region Article_MainToBrand

	/// <summary>
    /// 
	/// Article_MainToBrand object for mapped table 'Article_MainToBrand'.
	/// </summary>
	public partial class Article_MainToBrand
	{
		
		#region Constructors
        
		public Article_MainToBrand() { }        
        
		public Article_MainToBrand( Guid iD, Guid brandID, bool isShowFront, int sort )
		{
			this.ID = iD;
			this.BrandID = brandID;
			this.IsShowFront = isShowFront;
			this.Sort = sort;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid BrandID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual Car_Brand Car_Brand{get;set;}
        
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<Article_Main> Article_Main{get;set;}


		#endregion
	 
	}
	#endregion
}
 