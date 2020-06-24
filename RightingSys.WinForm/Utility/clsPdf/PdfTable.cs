using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace RightingSys.WinForm.Utility.cls
{
    /// <summary>
    /// Pdf表格操作类
    /// </summary>
    public class PdfTable : PdfBase
    {
        /// <summary>
        /// 向PDF中动态插入表格，表格内容按照htmltable标记格式插入
        /// </summary>
        /// <param name="pdfTemplate">pdf模板路径</param>
        /// <param name="tempFilePath">pdf导出路径</param>
        /// <param name="parameters">table标签</param>
        public void PutTable(string pdfTemplate, string tempFilePath, string parameter)
        {
            Document doc = new Document();
            try
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }

                doc = new Document(PageSize.LETTER);

                FileStream temFs = new FileStream(tempFilePath, FileMode.OpenOrCreate);
                PdfWriter PWriter = PdfWriter.GetInstance(doc, temFs);
                PdfTable pagebase = new PdfTable();
                PWriter.PageEvent = pagebase;//添加页眉页脚

                BaseFont bf1 = BaseFont.CreateFont("C:\\Windows\\Fonts\\SIMSUN.TTC,1", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font CellFont = new iTextSharp.text.Font(bf1, 12);
                doc.Open();

                PdfContentByte cb = PWriter.DirectContent;
                PdfReader reader = new PdfReader(pdfTemplate);
                for (int pageNumber = 1; pageNumber < reader.NumberOfPages + 1; pageNumber++)
                {
                    doc.SetPageSize(reader.GetPageSizeWithRotation(1));

                    PdfImportedPage page = PWriter.GetImportedPage(reader, pageNumber);
                    int rotation = reader.GetPageRotation(pageNumber);
                    cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                    doc.NewPage();
                }

                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(parameter);
                XmlNodeList xnlTable = xmldoc.SelectNodes("table");
                if (xnlTable.Count > 0)
                {
                    foreach (XmlNode xn in xnlTable)
                    {
                        //添加表格与正文之间间距
                        doc.Add(new Phrase("\n\n"));

                        // 由html标记和属性解析表格样式
                        var xmltr = xn.SelectNodes("tr");
                        foreach (XmlNode xntr in xmltr)
                        {
                            var xmltd = xntr.SelectNodes("td");
                            PdfPTable newTable = new PdfPTable(xmltd.Count);
                            foreach (XmlNode xntd in xmltd)
                            {
                                PdfPCell newCell = new PdfPCell(new Paragraph(1, xntd.InnerText, CellFont));
                                newTable.AddCell(newCell);//表格添加内容
                                var tdStyle = xntd.Attributes["style"];//获取单元格样式
                                if (tdStyle != null)
                                {
                                    string[] styles = tdStyle.Value.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                                    Dictionary<string, string> dicStyle = new Dictionary<string, string>();
                                    foreach (string strpar in styles)
                                    {
                                        string[] keyvalue = strpar.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                                        dicStyle.Add(keyvalue[0], keyvalue[1]);
                                    }

                                    //设置单元格宽度
                                    if (dicStyle.Select(sty => sty.Key.ToLower().Equals("width")).Count() > 0)
                                    {
                                        newCell.Width = float.Parse(dicStyle["width"]);
                                    }
                                    //设置单元格高度
                                    if (dicStyle.Select(sty => sty.Key.ToLower().Equals("height")).Count() > 0)
                                    {
                                        //newCell.Height = float.Parse(dicStyle["height"]);
                                    }

                                }
                            }
                            doc.Add(newTable);
                        }
                    }

                }

                doc.Close();
                temFs.Close();
                PWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                doc.Close();
            }


        }

        #region GenerateHeader
        /// <summary>  
        /// 生成页眉  
        /// </summary>  
        /// <param name="writer"></param>  
        /// <returns></returns>  
        public override PdfPTable GenerateHeader(iTextSharp.text.pdf.PdfWriter writer)
        {
            BaseFont baseFont = BaseFontForHeaderFooter;
            iTextSharp.text.Font font_logo = new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font_header1 = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font_header2 = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font_headerContent = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);

            float[] widths = new float[] { 355, 50, 90, 15, 20, 15 };

            PdfPTable header = new PdfPTable(widths);
            PdfPCell cell = new PdfPCell();
            cell.BorderWidthBottom = 2;
            cell.BorderWidthLeft = 2;
            cell.BorderWidthTop = 2;
            cell.BorderWidthRight = 2;
            cell.FixedHeight = 35;

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_LEFT);

            //Image img = Image.GetInstance("http://simg.instrument.com.cn/home/20141224/images/200_50logo.gif");
            //img.ScaleToFit(100f, 20f);
            //cell.Image = img;
            cell.Phrase = new Phrase("LOGO", font_logo);
            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            cell.PaddingTop = -1;
            header.AddCell(cell);

            //cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_LEFT);
            //cell.Phrase = new Paragraph("PDF报表", font_header1);
            //header.AddCell(cell);


            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_RIGHT);
            cell.Phrase = new Paragraph("日期:", font_header2);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_LEFT);
            cell.Phrase = new Paragraph(DateTime.Now.ToString("yyyy-MM-dd"), font_headerContent);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_RIGHT);
            cell.Phrase = new Paragraph("第", font_header2);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_CENTER);
            cell.Phrase = new Paragraph(writer.PageNumber.ToString(), font_headerContent);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_RIGHT);
            cell.Phrase = new Paragraph("页", font_header2);
            header.AddCell(cell);
            return header;
        }
        #region 
        /// <summary>  
        /// 生成只有底边的cell  
        /// </summary>  
        /// <param name="bottomBorder"></param>  
        /// <param name="horizontalAlignment">水平对齐方式<see cref="iTextSharp.text.Element"/></param>  
        /// <returns></returns>  
        private PdfPCell GenerateOnlyBottomBorderCell(int bottomBorder, int horizontalAlignment)
        {
            PdfPCell cell = GenerateOnlyBottomBorderCell(bottomBorder, horizontalAlignment, iTextSharp.text.Element.ALIGN_BOTTOM);
            cell.PaddingBottom = 5;
            return cell;
        }

        /// <summary>  
        /// 生成只有底边的cell  
        /// </summary>  
        /// <param name="bottomBorder"></param>  
        /// <param name="horizontalAlignment">水平对齐方式<see cref="iTextSharp.text.Element"/></param>  
        /// <param name="verticalAlignment">垂直对齐方式<see cref="iTextSharp.text.Element"/</param>  
        /// <returns></returns>  
        private PdfPCell GenerateOnlyBottomBorderCell(int bottomBorder, int horizontalAlignment, int verticalAlignment)
        {
            PdfPCell cell = GenerateOnlyBottomBorderCell(bottomBorder);
            cell.HorizontalAlignment = horizontalAlignment;
            cell.VerticalAlignment = verticalAlignment; ;
            return cell;
        }

        /// <summary>  
        /// 生成只有底边的cell  
        /// </summary>  
        /// <param name="bottomBorder"></param>  
        /// <returns></returns>  
        private PdfPCell GenerateOnlyBottomBorderCell(int bottomBorder)
        {
            PdfPCell cell = new PdfPCell();
            cell.BorderWidthBottom = 2;
            cell.BorderWidthLeft = 0;
            cell.BorderWidthTop = 0;
            cell.BorderWidthRight = 0;
            return cell;
        }
        #endregion

        #endregion  

        #region GenerateFooter
        public override PdfPTable GenerateFooter(iTextSharp.text.pdf.PdfWriter writer)
        {
            BaseFont baseFont = BaseFontForHeaderFooter;
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);

            PdfPTable footer = new PdfPTable(new float[] { 1, 1, 2, 1 });
            AddFooterCell(footer, "电话:010-51654077-8039", font);
            AddFooterCell(footer, "传真:010-82051730", font);
            AddFooterCell(footer, "电子邮件:yangdd@instrument.com.cn", font);
            AddFooterCell(footer, "联系人:杨丹丹", font);
            return footer;
        }

        private void AddFooterCell(PdfPTable foot, String text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell();
            cell.BorderWidthTop = 2;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthLeft = 0;
            cell.Phrase = new Phrase(text, font);
            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            foot.AddCell(cell);
        }
        #endregion


    }
}