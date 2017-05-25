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
	#region CarMainItemModelDto

	/// <summary>
    /// 车型表
	/// CarMainItemModelDto data view model for mapped table 'Car_MainItem_Model'.
	/// </summary>
	public partial class CarMainItemModelDto
	{
		
		#region Constructors
        
		public CarMainItemModelDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车型名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 显示在车型菜单
        /// </summary>
		public virtual bool IsShowInCarModelMenu { get; set; }
        /// <summary>
        /// 图片ID
        /// </summary>
		public virtual Guid? ImageID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        
        /// <summary>
        /// 车辆与车型关系表
        /// </summary>
        public virtual IList<CarMainItemToModelDto> CarMainItemToModelDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 