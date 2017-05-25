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
	#region TalkPrice_Order

	/// <summary>
    /// 
	/// TalkPrice_Order object for mapped table 'TalkPrice_Order'.
	/// </summary>
	public partial class TalkPrice_Order
	{
		
		#region Constructors
        
		public TalkPrice_Order() { }        
        
		public TalkPrice_Order( Guid iD, int identity, DateTime createdDate, Guid carMainItemId, decimal? hopePrice, string contact, string name, Guid? categoryId, int? state, string typeTitle )
		{
			this.ID = iD;
			this.Identity = identity;
			this.CreatedDate = createdDate;
			this.CarMainItemId = carMainItemId;
			this.HopePrice = hopePrice;
			this.Contact = contact;
			this.Name = name;
			this.CategoryId = categoryId;
			this.State = state;
			this.TypeTitle = typeTitle;
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
        /// 发布时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? HopePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? State { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string TypeTitle { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TalkPrice_Category TalkPrice_Category{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPrice_Image> TalkPrice_Image{get;set;}
        /// <summary>
        /// 短信表
        /// </summary>
        public virtual IList<TalkPrice_OrderSmsRecord> TalkPrice_OrderSmsRecord{get;set;}


		#endregion
	 
	}
	#endregion
}
 