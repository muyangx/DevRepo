using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace AppWinfrom.Utils
{
    /// <summary>
    /// Img与Base64转化的帮助类
    /// </summary>
    public class Base64ImgHelper
    {
        /// <summary>
        /// Img转Base64的方法
        /// </summary>
        /// <param name="bitmap">bmp类型的图片数据</param>
        /// <param name="imgFromat">Img原来的格式</param>
        /// <returns></returns>
        public static string ImgToBase64Str(Bitmap bitmap, ImageFormat imgFromat)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, imgFromat);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Base64转Img的方法
        /// img.Save("ImgName.png", ImageFormat.Png);
        /// </summary>
        /// <param name="base64Str">图片源的Base64字节流</param>
        /// <returns></returns>
        public static Image Base64StrToImg(string base64Str)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(base64Str);
                MemoryStream ms = new MemoryStream(arr);
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }

        #region 扩展
        /// <summary>
        /// 根据图片名字的后缀返回图片的System.Drawing.Imaging.ImageFormat格式
        /// </summary>
        /// <param name="imgName">带后缀的图片名字</param>
        /// <returns></returns>
        public static ImageFormat GetImageFormat(string imgName)
        {
            string[] files = imgName.Split('.');
            imgName = files[files.Length - 1].Trim().ToLower();  // 获取后缀
            switch (imgName)
            {
                case "png":
                    return ImageFormat.Png;
                case "jpg":
                    return ImageFormat.Jpeg;
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "gif":
                    return ImageFormat.Gif;
                case "bmp":
                    return ImageFormat.Bmp;
                case "icon":
                    return ImageFormat.Icon;
                case "memoryBmp":  // 不是文件类型
                    return ImageFormat.MemoryBmp;
                case "tiff":
                    return ImageFormat.Tiff;
                case "exif":
                    return ImageFormat.Exif;
                case "wmf":
                    return ImageFormat.Wmf;
                case "emf":
                    return ImageFormat.Emf;
                default:  // 默认返回Jpeg
                    return ImageFormat.Jpeg;
            }
        }
        #endregion
    }
}
