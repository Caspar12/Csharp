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
	#region WeiXinArticlesDto

	/// <summary>
    /// 微信文章表
	/// WeiXinArticlesDto data view model for mapped table 'WeiXin_Articles'.
	/// </summary>
	public partial class WeiXinArticlesDto
	{
		
		#region Constructors
        
		public WeiXinArticlesDto() { }        
        
	 
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
        /// 描述
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 图片Url
        /// </summary>
		public virtual string PicUrl { get; set; }
        /// <summary>
        /// 文章Url
        /// </summary>
		public virtual string Url { get; set; }
        
        
        /// <summary>
        /// 微信菜单与文章表
        /// </summary>
        public virtual IList<WeiXinMenusArticlesRefDto> WeiXinMenusArticlesRefDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 