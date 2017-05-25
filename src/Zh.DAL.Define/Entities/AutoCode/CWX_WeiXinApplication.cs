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
    #region CWX_WeiXinApplication

    /// <summary>
    /// 微信程序信息表
    /// CWX_WeiXinApplication object for mapped table 'CWX_WeiXinApplication'.
    /// </summary>
    public partial class CWX_WeiXinApplication
    {

        #region Constructors

        public CWX_WeiXinApplication() { }

        public CWX_WeiXinApplication(Guid iD, int identity, string name, string appID, string appSecret, string token, string accessToken, DateTime? accessTokenUpdateDateTime, Guid? authResourceId, string merchantId, string aPISecretKey)
        {

            this.ID = iD;

            this.Identity = identity;

            this.Name = name;

            this.AppID = appID;

            this.AppSecret = appSecret;

            this.Token = token;

            this.AccessToken = accessToken;

            this.AccessTokenUpdateDateTime = accessTokenUpdateDateTime;

            this.AuthResourceId = authResourceId;

            this.MerchantId = merchantId;

            this.APISecretKey = aPISecretKey;
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
        public virtual Auth_Resource Auth_Resource { get; set; }

        /// <summary>
        /// 微信菜单表
        /// </summary>
        public virtual IList<CWX_WeiXinMenu> CWX_WeiXinMenu { get; set; }


        #endregion

    }
    #endregion
}
