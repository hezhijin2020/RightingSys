using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace RightingSys.WinForm.Utility.cls
{
    /// <summary>
    /// pdf图片操作类
    /// </summary>
    public class PdfImage
    {

        #region PdfImage属性
        /// <summary>
        /// 图片URL地址
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// 图片域宽
        /// </summary>
        public float FitWidth { get; set; }
        /// <summary>
        /// 图片域高
        /// </summary>
        public float FitHeight { get; set; }
        /// <summary>
        /// 绝对X坐标
        /// </summary>
        public float AbsoluteX { get; set; }
        /// <summary>
        /// 绝对Y坐标
        /// </summary>
        public float AbsoluteY { get; set; }
        /// <summary>
        /// Img内容
        /// </summary>
        public byte[] ImgBytes { get; set; }
        /// <summary>
        /// 是否缩放
        /// </summary>
        public bool ScaleParent { get; set; }
        /// <summary>
        /// 画布对象
        /// </summary>
        public CanvasRectangle ContainerRect { get; set; }

        #endregion

        #region  PdfImage构造
        /// <summary>
        /// 网络图片写入
        /// </summary>
        /// <param name="imageUrl">图片URL地址</param>
        /// <param name="fitWidth"></param>
        /// <param name="fitHeight"></param>
        /// <param name="absolutX"></param>
        /// <param name="absoluteY"></param>
        /// <param name="scaleParent"></param>
        public PdfImage(string imageUrl, float fitWidth, float fitHeight, float absolutX, float absoluteY, bool scaleParent)
        {
            this.ImageUrl = imageUrl;
            this.FitWidth = fitWidth;
            this.FitHeight = fitHeight;
            this.AbsoluteX = absolutX;
            this.AbsoluteY = absoluteY;
            this.ScaleParent = scaleParent;
        }

        /// <summary>
        /// 本地文件写入
        /// </summary>
        ///  <param name="imageUrl">图片URL地址</param>
        /// <param name="fitWidth"></param>
        /// <param name="fitHeight"></param>
        /// <param name="absolutX"></param>
        /// <param name="absoluteY"></param>
        /// <param name="scaleParent"></param>
        /// <param name="imgBytes"></param>
        public PdfImage(string imageUrl, float fitWidth, float fitHeight, float absolutX, float absoluteY, bool scaleParent, byte[] imgBytes)
        {
            this.ImageUrl = imageUrl;
            this.FitWidth = fitWidth;
            this.FitHeight = fitHeight;
            this.AbsoluteX = absolutX;
            this.AbsoluteY = absoluteY;
            this.ScaleParent = scaleParent;
            this.ImgBytes = imgBytes;
        }

        #endregion

        #region 指定pdf模板文件添加图片
        /// <summary>
        /// 指定pdf模板文件添加图片
        /// </summary>
        /// <param name="tempFilePath"></param>
        /// <param name="createdPdfPath"></param>
        /// <param name="pdfImages"></param>
        public void PutImages(string tempFilePath, string createdPdfPath, List<PdfImage> pdfImages)
        {
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;

            try
            {
                pdfReader = new PdfReader(tempFilePath);
                pdfStamper = new PdfStamper(pdfReader, new FileStream(createdPdfPath, FileMode.OpenOrCreate));

                var pdfContentByte = pdfStamper.GetOverContent(1);//获取PDF指定页面内容

                foreach (var pdfImage in pdfImages)
                {
                    Uri uri = null;
                    Image img = null;

                    var imageUrl = pdfImage.ImageUrl;

                    //如果使用网络路径则先将图片转化位绝对路径
                    if (imageUrl.StartsWith("http"))
                    {
                        //var absolutePath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(".."), imageUrl);  
                        var absolutePath = System.Web.HttpContext.Current.Server.MapPath("..") + imageUrl;
                        uri = new Uri(absolutePath);
                        img = Image.GetInstance(uri);
                    }
                    else
                    {
                        //如果直接使用图片文件则直接创建iTextSharp的Image对象
                        if (pdfImage.ImgBytes != null)
                        {
                            img = Image.GetInstance(new MemoryStream(pdfImage.ImgBytes));
                        }
                    }

                    if (img != null)
                    {

                        if (pdfImage.ScaleParent)
                        {
                            var containerRect = pdfImage.ContainerRect;

                            float percentage = 0.0f;
                            percentage = CanvasRectangle.GetPercentage(img.Width, img.Height, containerRect);
                            img.ScalePercent(percentage * 100);

                            pdfImage.AbsoluteX = (containerRect.RectWidth - img.Width * percentage) / 2 + containerRect.StartX;
                            pdfImage.AbsoluteY = (containerRect.RectHeight - img.Height * percentage) / 2 + containerRect.StartY;
                        }
                        else
                        {
                            img.ScaleToFit(pdfImage.FitWidth, pdfImage.FitHeight);
                        }

                        img.SetAbsolutePosition(pdfImage.AbsoluteX, pdfImage.AbsoluteY);
                        pdfContentByte.AddImage(img);
                    }
                }

                pdfStamper.FormFlattening = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pdfStamper != null)
                {
                    pdfStamper.Close();
                }

                if (pdfReader != null)
                {
                    pdfReader.Close();
                }

                pdfStamper = null;
                pdfReader = null;
            }
        }
        #endregion
    }
}