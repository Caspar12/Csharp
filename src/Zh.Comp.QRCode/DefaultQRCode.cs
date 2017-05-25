using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.QRCodeTool;
using System.IO;
using System.Drawing.Imaging;
using Zh.Framework.Entities;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using System.Drawing;

namespace Zh.Comp.QRCode
{   /// <summary>
    /// 含有QR码的描述类和包装编码和渲染
    /// </summary>

    public class DefaultQRCode : IQRCode
    {

        /// <summary>
        /// 创建二维码图片
        /// </summary>
        /// <param name="content">待编码字符</param>
        /// <param name="width">图片宽度</param>
        /// <param name="heigth">图片高度</param>
        /// <param name="characterSet">字符编码默认UTF-8</param>
        /// <returns>成功返回二维码图片</returns>
        public Image CreateQRCodeImage(string content, int width, int heigth, string characterSet = "UTF-8")
        {

            EncodingOptions options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = characterSet,
                Width = width,
                Height = heigth
            }; ;
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var image = writer.Write(content);
            return image;
        }
    }
}
