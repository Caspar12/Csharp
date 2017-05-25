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
	#region TalkPrice_Category

	/// <summary>
    /// 
	/// TalkPrice_Category object for mapped table 'TalkPrice_Category'.
	/// </summary>
	public partial class TalkPrice_Category
	{
		
		#region Constructors
        
		public TalkPrice_Category() { }        
        
		public TalkPrice_Category( Guid iD, int identity, string name, bool isConnectCarBrand, bool isShowInFront )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.IsConnectCarBrand = isConnectCarBrand;
			this.IsShowInFront = isShowInFront;
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
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsConnectCarBrand { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowInFront { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPrice_CategoryConnectCarBrand> TalkPrice_CategoryConnectCarBrand{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPrice_Order> TalkPrice_Order{get;set;}


		#endregion
	 
	}
	#endregion
}
 