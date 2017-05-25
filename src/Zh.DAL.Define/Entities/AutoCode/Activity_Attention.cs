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
	#region Activity_Attention

	/// <summary>
    /// 
	/// Activity_Attention object for mapped table 'Activity_Attention'.
	/// </summary>
	public partial class Activity_Attention
	{
		
		#region Constructors
        
		public Activity_Attention() { }        
        
		public Activity_Attention( Guid iD, int bigType, int smallType, string contetText, int identity, string shopId )
		{
			this.ID = iD;
			this.BigType = bigType;
			this.SmallType = smallType;
			this.ContetText = contetText;
			this.Identity = identity;
			this.ShopId = shopId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 大类，0注意，1冠军竞猜，2胜负竞猜，3参猜大抽奖
        /// </summary>
		public virtual int BigType { get; set; }
        /// <summary>
        /// 小类，0竞猜规则，1获奖规则
        /// </summary>
		public virtual int SmallType { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ContetText { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 