using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;
using System.Drawing;

namespace Zh.Framework.Tools.QRCodeTool
{
    /// <summary>
    /// 二维码工具类,默认使用项目Zh.Comp.QRCode,使用开源ZXing.net项目
    /// </summary>
    public interface IQRCode
    {
        /// <summary>
        /// 创建二维码图片
        /// </summary>
        /// <param name="content">待编码字符</param>
        /// <param name="width">图片宽度</param>
        /// <param name="heigth">图片高度</param>
        /// <param name="characterSet">字符编码默认UTF-8</param>
        /// <returns>成功返回二维码图片</returns>
        Image CreateQRCodeImage(string content, int width, int heigth, string characterSet = "UTF-8");
    }
}
