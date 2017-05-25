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
	#region MallGoodsImgDto

	/// <summary>
    /// 
	/// MallGoodsImgDto data view model for mapped table 'Mall_GoodsImg'.
	/// </summary>
	public partial class MallGoodsImgDto
	{
		
		#region Constructors
        
		public MallGoodsImgDto() { }        
        
	 
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
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual MallGoodsDto MallGoodsDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 