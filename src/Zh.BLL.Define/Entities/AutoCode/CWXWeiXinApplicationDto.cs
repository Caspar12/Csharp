
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
    #region CWXWeiXinApplicationDto

    /// <summary>
    /// 微信程序信息表
    /// CWXWeiXinApplicationDto object for mapped table 'CWX_WeiXinApplication'.
    /// </summary>
    public partial class CWXWeiXinApplicationDto
    {

        #region Constructors

        public CWXWeiXinApplicationDto() { }



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
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 应用ID
        /// </summary>
        public virtual string AppID { get; set; }
        /// <summary>
        /// 应用密钥
        /// </summary>
        public virtual string AppSecret { get; set; }
        /// <summary>
        /// Token
        /// </summary>
        public virtual string Token { get; set; }
        /// <summary>
        /// AccessToken
        /// </summary>
        public virtual string AccessToken { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime? AccessTokenUpdateDateTime { get; set; }
        /// <summary>
        /// 权限模块资源Id
        /// </summary>
        public virtual Guid? AuthResourceId { get; set; }
        /// <summary>
        /// 微信商户Id
        /// </summary>
        public virtual string MerchantId { get; set; }
        /// <summary>
        /// API安全密钥,设置路径：微信商户平台(pay.weixin.qq.com) - 账户设置 - API安全 - 密钥设置
        /// </summary>
        public virtual string APISecretKey { get; set; }

        /// <summary>
        /// 权限资源表
        /// </summary>            
        public virtual AuthResourceDto AuthResourceDto { get; set; }

        /// <summary>
        /// 微信菜单表
        /// </summary>
        public virtual IList<CWXWeiXinMenuDto> CWXWeiXinMenuDto { get; set; }


        #endregion

    }
    #endregion
}
