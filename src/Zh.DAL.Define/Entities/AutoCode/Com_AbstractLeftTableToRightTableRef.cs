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
	#region Com_AbstractLeftTableToRightTableRef

	/// <summary>
    /// 抽象关系表
	/// Com_AbstractLeftTableToRightTableRef object for mapped table 'Com_AbstractLeftTableToRightTableRef'.
	/// </summary>
	public partial class Com_AbstractLeftTableToRightTableRef
	{
		
		#region Constructors
        
		public Com_AbstractLeftTableToRightTableRef() { }        
        
		public Com_AbstractLeftTableToRightTableRef( Guid id, Guid leftId, Guid rightId, int sort, DateTime createdDatetime )
		{
			this.Id = id;
			this.LeftId = leftId;
			this.RightId = rightId;
			this.Sort = sort;
			this.CreatedDatetime = createdDatetime;
		}
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
        public virtual Com_AbstractLeftTable Com_AbstractLeftTable{get;set;}
        /// <summary>
        /// 抽象右表
        /// </summary>            
        public virtual Com_AbstractRightTable Com_AbstractRightTable{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 