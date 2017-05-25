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
	#region Display_IndexAdvert

	/// <summary>
    /// 首页广告
	/// Display_IndexAdvert object for mapped table 'Display_IndexAdvert'.
	/// </summary>
	public partial class Display_IndexAdvert
	{
		
		#region Constructors
        
		public Display_IndexAdvert() { }        
        
		public Display_IndexAdvert( Guid iD, int identity, int sort, string name, string url, string shopId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Sort = sort;
			this.Name = name;
			this.Url = url;
			this.ShopId = shopId;
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
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 