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
	#region WeiXinActivityDto

	/// <summary>
    /// 微活动报名表
	/// WeiXinActivityDto data view model for mapped table 'WeiXin_Activity'.
	/// </summary>
	public partial class WeiXinActivityDto
	{
		
		#region Constructors
        
		public WeiXinActivityDto() { }        
        
	 
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
        /// 标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        
        
        /// <summary>
        /// 微活动报名表
        /// </summary>
        public virtual IList<WeiXinActivityApplicantDto> WeiXinActivityApplicantDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 