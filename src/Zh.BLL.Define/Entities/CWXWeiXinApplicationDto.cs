/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件 
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
namespace Zh.BLL.Define.Entities
{
    public partial class CWXWeiXinApplicationDto : CWX_WeiXinApplication
    {
        /// <summary>
        /// 微信调用凭证过期时间
        /// </summary>
        public DateTime AccessTokenExpire
        {
            get
            {
                return this.AccessTokenUpdateDateTime.HasValue ? this.AccessTokenUpdateDateTime.Value.AddSeconds(7000) : DateTime.MinValue;
            }
        }
        /// <summary>
        /// 微信调用凭证是否过期
        /// </summary>
        public bool IsAccessTokenExpire
        {
            get
            {
                return string.IsNullOrEmpty(this.AccessToken) || DateTime.Now >= this.AccessTokenExpire;
            }
        }
        /// <summary>
        /// 微信调用凭证剩余过期时间,单位秒
        /// </summary>
        public int AccessTokenExpireInSeconds
        {
            get
            {
                return (int)(this.AccessTokenExpire - DateTime.Now).TotalSeconds;
            }
        }
    }
}