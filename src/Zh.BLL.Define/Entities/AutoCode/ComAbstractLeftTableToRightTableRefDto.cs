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
	#region ComAbstractLeftTableToRightTableRefDto

	/// <summary>
    /// 抽象关系表
	/// ComAbstractLeftTableToRightTableRefDto data view model for mapped table 'Com_AbstractLeftTableToRightTableRef'.
	/// </summary>
	public partial class ComAbstractLeftTableToRightTableRefDto
	{
		
		#region Constructors
        
		public ComAbstractLeftTableToRightTableRefDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// Id
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 左关系表Id
        /// </summary>
		public virtual Guid LeftId { get; set; }
        /// <summary>
        /// 右关系表Id
        /// </summary>
		public virtual Guid RightId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDatetime { get; set; }
        
        /// <summary>
        /// 抽象左表
        /// </summary>            
        public virtual ComAbstractLeftTableDto ComAbstractLeftTableDto{get;set;}
        /// <summary>
        /// 抽象右表
        /// </summary>            
        public virtual ComAbstractRightTableDto ComAbstractRightTableDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 