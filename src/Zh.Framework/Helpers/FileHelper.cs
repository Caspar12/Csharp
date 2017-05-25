using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Helpers
{
    public class FileHelper
    {
        public static bool IsImageFile(string fileName)
        {
            var extension = System.IO.Path.GetExtension(fileName);

            var imgFileExtensions = new string[] {
                ".gif",
                ".png",
                ".bmp",
                ".jpg",
                ".jpeg",
            };

            foreach (var item in imgFileExtensions)
            {
                if (extension.Equals(item, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
