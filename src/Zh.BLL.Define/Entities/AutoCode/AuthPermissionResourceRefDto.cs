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
	#region AuthPermissionResourceRefDto

	/// <summary>
    /// 权限资源关系表
	/// AuthPermissionResourceRefDto data view model for mapped table 'Auth_PermissionResourceRef'.
	/// </summary>
	public partial class AuthPermissionResourceRefDto
	{
		
		#region Constructors
        
		public AuthPermissionResourceRefDto() { }        
        
	 
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
        /// 权限Id
        /// </summary>
		public virtual Guid PermissionId { get; set; }
        /// <summary>
        /// 资源Id
        /// </summary>
		public virtual Guid ResourceId { get; set; }
        /// <summary>
        /// 是否允许
        /// </summary>
		public virtual bool IsAllow { get; set; }
        
        /// <summary>
        /// 权限表
        /// </summary>            
        public virtual AuthPermissionDto AuthPermissionDto{get;set;}
        /// <summary>
        /// 权限资源表
        /// </summary>            
        public virtual AuthResourceDto AuthResourceDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 