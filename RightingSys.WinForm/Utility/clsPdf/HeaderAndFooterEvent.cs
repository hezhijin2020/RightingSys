using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace RightingSys.WinForm.Utility.cls
{
    public class HeaderAndFooterEvent : PdfPageEventHelper, IPdfPageEvent
    {
        #region 静态字段 
        public static PdfTemplate tpl = null;
        public static bool PAGE_NUMBER = false;

        //为True时就生成 页眉和页脚  
        public static iTextSharp.text.Rectangle rect = PageSize.A4;

        public static int PageCount = 0;
        //文档大小
        /// <summary> /// 正文字体 /// </summary>
        private static Font font;

        /// <summary>  页眉页脚字体 /// </summary> 
        public static string HeaderFooterFontName = "黑体";

        /// <summary> /// 页头页脚字号 /// </summary> 
        public static int HeaderFooterFontSize = 10;

        /// <summary> /// 页头页尾字体颜色 /// </summary> 
        public static  Color HeaderFooterFontColor = Color.BLACK;

        /// <summary> /// 左边页眉 /// </summary> 
        public static string HeaderLeft { get; set; }

        /// <summary> /// 右边页眉 /// </summary> 
        public static string HeaderRight { get; set; }

        /// <summary> /// 左边页脚 /// </summary> 
        public static string FooterLeft { get; set; }

        /// <summary> /// 右边页脚 /// </summary> 
        public static string FooterRight { get; set; }

        #endregion

        #region 设置页面大小 

        /// <summary> /// 设置页面大小 /// </summary>
        /// <param name="type">页面大小(如"A4")</param> 
        public static void SetPageSize(string type)
        {
            switch (type.Trim())
            {
                case "A4": rect = PageSize.A4; break;
                case "A8": rect = PageSize.A8; break;
            }
        }
        #endregion

        #region 设置字体 
        /// <summary> /// 设置字体 /// </summary> 
        /// /// <param name="size">字体大小</param> 
        public static void SetFont(Color color, string fontName = "华文中宋", float size = 12, int style = Font.NORMAL)
        {
            font = new Font(BaseFontAndSize(fontName), size, style, color);
        }
        #endregion

        #region 生成页眉页脚 

        /// <summary>  关闭一个页面时发生  </summary> 
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            if (PAGE_NUMBER)
            {
                Font HeaderFooterFont = FontAndSize(HeaderFooterFontName, HeaderFooterFontSize, Font.NORMAL, HeaderFooterFontColor);
                Phrase header_left = new Phrase(HeaderLeft, HeaderFooterFont);
                Phrase header_right = new Phrase(HeaderRight, HeaderFooterFont);
                Phrase footer_left = new Phrase(FooterLeft, HeaderFooterFont);
                Phrase footer_center = new Phrase("第" + (writer.PageNumber) + "页", HeaderFooterFont);
                Phrase footer_right = new Phrase(FooterRight, HeaderFooterFont); PdfContentByte cb = writer.DirectContent;
                //模版 显示总共页数  cb.AddTemplate(tpl, document.Right - 290 + document.LeftMargin, document.Bottom - 15);

                //调节模版显示的位置  //页眉显示的位置 
                ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, header_right, document.Right - 50 + document.LeftMargin, document.Top + 15, 0);
                ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, header_left, document.Right - 500 + document.LeftMargin, document.Top + 15, 0);
                //页脚显示的位置 
                ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, footer_left, document.Right - 535 + document.LeftMargin, document.Bottom - 15, 0);
                ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, footer_center, document.Right - 300 + document.LeftMargin, document.Bottom - 15, 0);
                ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, footer_right, document.Right - 80 + document.LeftMargin, document.Bottom - 15, 0);
            }
        }


        /// <summary> 
        /// 打开一个新页面时发生 
        /// </summary> 
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            if (PAGE_NUMBER)
            {
                writer.PageCount = writer.PageNumber - 1;
            }
        }

        /// <summary> /// 关闭PDF文档时发生该事件 /// </summary>
        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            BaseFont bf = BaseFontAndSize(HeaderFooterFontName);
            tpl.BeginText(); tpl.SetFontAndSize(bf, HeaderFooterFontSize);
            tpl.ShowText((writer.PageNumber - 1).ToString());
            //总页数 tpl.EndText(); tpl.ClosePath();
        }
        #endregion

        #region 私有方法 
        private static Font FontAndSize(string font_name, int size, int style, Color baseColor)
        {
            BaseFont baseFont; BaseFont.AddToResourceSearch("iTextAsian.dll");
            BaseFont.AddToResourceSearch("iTextAsianCmaps.dll");
            Font font = null; string file_name = "";
            int fontStyle; switch (font_name)
            {
                case "黑体": file_name = "SIMHEI.TTF"; break;
                case "华文中宋": file_name = "STZHONGS.TTF"; break;
                case "宋体": file_name = "SIMYOU.TTF"; break;
                default: file_name = "SIMYOU.TTF"; break;
            }
            baseFont = BaseFont.CreateFont(@"c:/windows/fonts/" + file_name, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            if (style < -1)
            {
                fontStyle = Font.NORMAL;
            }
            else
            {
                fontStyle = style;
            }
            font = new Font(baseFont, size, fontStyle, baseColor);
            return font;
        }
        private static BaseFont BaseFontAndSize(string font_name)
        {
            BaseFont baseFont; BaseFont.AddToResourceSearch("iTextAsian.dll");
            BaseFont.AddToResourceSearch("iTextAsianCmaps.dll");
            string file_name = "";
            switch (font_name)
            {
                case "黑体": file_name = "SIMHEI.TTF"; break;
                case "华文中宋": file_name = "STZHONGS.TTF"; break;
                case "宋体": file_name = "SIMYOU.TTF"; break;
                default: file_name = "SIMYOU.TTF"; break;
            }
            baseFont = BaseFont.CreateFont(@"c:/windows/fonts/" + file_name, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            return baseFont;
        }
        #endregion

        #region 添加段落
        /// < summary > /// 添加段落 /// </summary>
        /// <param name="content">内容</param>
        /// <param name="Alignment">对齐方式（1为居中，0为居左，2为居右）</param> 
        /// <param name="SpacingAfter">段后空行数（0为默认值）</param>
        /// <param name="SpacingBefore">段前空行数（0为默认值）</param>
        /// <param name="MultipliedLeading">行间距（0为默认值）</param> 
        public static Paragraph AddParagraph(string content, int Alignment, float SpacingAfter, float SpacingBefore, float MultipliedLeading)
        {
            Paragraph pra = new Paragraph(content, font);
            pra.Alignment = Alignment;
            pra.SpacingAfter = SpacingAfter;
            pra.SpacingBefore = SpacingBefore;
            pra.MultipliedLeading = MultipliedLeading;
            return pra;
        }

        public static Paragraph AddParagraph(string content, int Alignment, float MultipliedLeading)
        {
            Paragraph pra = new Paragraph(content, font);
            pra.Alignment = Alignment;
            pra.MultipliedLeading = MultipliedLeading;
            return pra;
        }

        public static void AddPhrase(PdfWriter writer, Document document, string content, float marginLift, float marginBottom)
        {
            Phrase phrase = new Phrase(content, font);
            PdfContentByte cb = writer.DirectContent;
            ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, phrase, marginLift + document.LeftMargin, marginBottom, 0);
        }

        #endregion

        #region 添加图片 

        ///< summary > /// 添加图片 
        /// <param name="Alignment">对齐方式 (0/1/2)</param>
        /// <param name="marginRight">页边距</param>
        /// <param name="marginBottom">页边距</param> 
        /// </summary>
        public static iTextSharp.text.Image AddImage(string path, int Alignment, float marginRight, float marginBottom)
        {
            try
            {
                string TempPath = clsPublic.CompressImage(path, 80, 300, true);
                Image img = Image.GetInstance(TempPath);
                img.Alignment = Alignment; //等比缩放，宽与高的缩放系数哪个大就取哪一个（比如高的系数是0.8，宽的是0.7，则取0.7。这样图片就不会超出页面范围） 
                if (img.Width > img.Height)
                {
                    //这里计算图片的缩放系数，因为图片width>height,所以将图片旋转90度以适应页面，计算缩放系数的时候宽与高对调 
                    float PageHeight = PageSize.A4.Height - marginBottom * 3;
                    double percentHeight = Math.Round((PageHeight / img.Width), 2);
                    float PageWidth = PageSize.A4.Width - marginRight * 2;
                    double percentWidth = Math.Round((PageWidth / img.Height), 2);
                    double percent = percentHeight > percentWidth ? percentWidth : percentHeight;

                    // img.ScaleAbsolute(img.Width, img.Height );
                    img.ScalePercent((float)percent * 90);
                    img.RotationDegrees = 90f;
                }
                else
                {
                    float PageHeight = PageSize.A4.Height - marginBottom * 3;
                    double percentHeight = Math.Round((PageHeight / img.Height), 2);
                    float PageWidth = PageSize.A4.Width - marginRight * 2;
                    double percentWidth = Math.Round((PageWidth / img.Width), 2);
                    double percent = percentHeight > percentWidth ? percentWidth : percentHeight;
                    img.ScalePercent((float)percent * 90);
                }
                return img;
            }
            catch (Exception EX)
            {
                throw new Exception("图片添加出错", EX);
            }
        }
       
        #endregion

    }
}
