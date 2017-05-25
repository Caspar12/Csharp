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
	#region Mall_GoodsImg

	/// <summary>
    /// 
	/// Mall_GoodsImg object for mapped table 'Mall_GoodsImg'.
	/// </summary>
	public partial class Mall_GoodsImg
	{
		
		#region Constructors
        
		public Mall_GoodsImg() { }        
        
		public Mall_GoodsImg( Guid id, int identity, int order, Guid goodsId )
		{
			this.Id = id;
			this.Identity = identity;
			this.Order = order;
			this.GoodsId = goodsId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid GoodsId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Mall_Goods Mall_Goods{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 