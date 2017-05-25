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
	#region Auth_PermissionResourceRef

	/// <summary>
    /// 权限资源关系表
	/// Auth_PermissionResourceRef object for mapped table 'Auth_PermissionResourceRef'.
	/// </summary>
	public partial class Auth_PermissionResourceRef
	{
		
		#region Constructors
        
		public Auth_PermissionResourceRef() { }        
        
		public Auth_PermissionResourceRef( Guid iD, int identity, Guid permissionId, Guid resourceId, bool isAllow )
		{
			this.ID = iD;
			this.Identity = identity;
			this.PermissionId = permissionId;
			this.ResourceId = resourceId;
			this.IsAllow = isAllow;
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
        public virtual Auth_Permission Auth_Permission{get;set;}
        /// <summary>
        /// 权限资源表
        /// </summary>            
        public virtual Auth_Resource Auth_Resource{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 