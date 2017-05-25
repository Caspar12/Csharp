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
	#region Com_AbstractLeftTable

	/// <summary>
    /// 抽象左表
	/// Com_AbstractLeftTable object for mapped table 'Com_AbstractLeftTable'.
	/// </summary>
	public partial class Com_AbstractLeftTable
	{
		
		#region Constructors
        
		public Com_AbstractLeftTable() { }        
        
		public Com_AbstractLeftTable( Guid id )
		{
			this.Id = id;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// Id
        /// </summary>
		public virtual Guid Id { get; set; }
        
        
        /// <summary>
        /// 抽象关系表
        /// </summary>
        public virtual IList<Com_AbstractLeftTableToRightTableRef> Com_AbstractLeftTableToRightTableRef{get;set;}


		#endregion
	 
	}
	#endregion
}
 