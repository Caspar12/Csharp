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
	#region ComAbstractLeftTableDto

	/// <summary>
    /// 抽象左表
	/// ComAbstractLeftTableDto data view model for mapped table 'Com_AbstractLeftTable'.
	/// </summary>
	public partial class ComAbstractLeftTableDto
	{
		
		#region Constructors
        
		public ComAbstractLeftTableDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// Id
        /// </summary>
		public virtual Guid Id { get; set; }
        
        
        /// <summary>
        /// 抽象关系表
        /// </summary>
        public virtual IList<ComAbstractLeftTableToRightTableRefDto> ComAbstractLeftTableToRightTableRefDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 