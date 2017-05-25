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
	#region Car_Main_Image

	/// <summary>
    ///  
	/// Car_Main_Image object for mapped table 'Car_Main_Image'.
	/// </summary>
	public partial class Car_Main_Image
	{
		
		#region Constructors
        
		public Car_Main_Image() { }        
        
		public Car_Main_Image( Guid iD, int identity, string title, string url, Guid carMainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Title = title;
			this.Url = url;
			this.CarMainId = carMainId;
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
        /// 显示名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 