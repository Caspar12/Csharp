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
	#region AuthRoleDto

	/// <summary>
    /// 权限角色表
	/// AuthRoleDto data view model for mapped table 'Auth_Role'.
	/// </summary>
	public partial class AuthRoleDto
	{
		
		#region Constructors
        
		public AuthRoleDto() { }        
        
	 
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
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        
        
        /// <summary>
        /// 后台账号与角色关系表
        /// </summary>
        public virtual IList<AuthAdministratorRoleRefDto> AuthAdministratorRoleRefDto{get;set;}
        /// <summary>
        /// 权限与角色关系表
        /// </summary>
        public virtual IList<AuthPermissionRoleRefDto> AuthPermissionRoleRefDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 