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
	#region PrestigePostImageDto

	/// <summary>
    /// 口碑图片表
	/// PrestigePostImageDto data view model for mapped table 'Prestige_PostImage'.
	/// </summary>
	public partial class PrestigePostImageDto
	{
		
		#region Constructors
        
		public PrestigePostImageDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 帖子ID
        /// </summary>
		public virtual Guid PostID { get; set; }
        /// <summary>
        /// 图片ID
        /// </summary>
		public virtual Guid ImageID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>            
        public virtual PrestigePostDto PrestigePostDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 