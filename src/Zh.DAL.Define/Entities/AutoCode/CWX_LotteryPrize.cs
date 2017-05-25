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
	#region CWX_LotteryPrize

	/// <summary>
    /// 活动奖品表
	/// CWX_LotteryPrize object for mapped table 'CWX_LotteryPrize'.
	/// </summary>
	public partial class CWX_LotteryPrize
	{
		
		#region Constructors
        
		public CWX_LotteryPrize() { }        
        
		public CWX_LotteryPrize( Guid iD, int identity, decimal beginChance, decimal endChance, string content, int count, Guid lotteryMainId, bool isNotPrize, int sort )
		{
			this.ID = iD;
			this.Identity = identity;
			this.BeginChance = beginChance;
			this.EndChance = endChance;
			this.Content = content;
			this.Count = count;
			this.LotteryMainId = lotteryMainId;
			this.IsNotPrize = isNotPrize;
			this.Sort = sort;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal BeginChance { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal EndChance { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid LotteryMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsNotPrize { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual CWX_LotteryMain CWX_LotteryMain{get;set;}
        
        /// <summary>
        /// 活动中奖人员表
        /// </summary>
        public virtual IList<CWX_LotteryUserPrize> CWX_LotteryUserPrize{get;set;}


		#endregion
	 
	}
	#endregion
}
 