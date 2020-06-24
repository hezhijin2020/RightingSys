
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RightingSys.WinForm.Utility.cls
{
    public partial class PdfPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region  默认文档
        protected void defaultpdf_Click(object sender, EventArgs e)
        {
           // iframepdf.Attributes["src"] = "../PDFTemplate/pdfTemplate.pdf";
        }
        #endregion

        #region 文字域
        protected void CreatePdf_Click(object sender, EventArgs e)
        {
            string pdfTemplate = Server.MapPath("~/PDFTemplate/pdfTemplate.pdf");
            string newpdf = Server.MapPath("~/PDFTemplate/newpdf.pdf");
            //追加文本##########
            Dictionary<string, string> dicPra = new Dictionary<string, string>();
            dicPra.Add("HTjiafang", "北京美嘉生物科技有限公司111111");
            dicPra.Add("Total", "1370000000000000");
            dicPra.Add("TotalDaXie", "壹万叁仟柒佰元整");
            dicPra.Add("Date", "2017年12月12日前付款3000元，2018年1月10日前付余款10700元");
            new PdfText().PutText(pdfTemplate, newpdf, dicPra);
            //iframepdf.Attributes["src"] = "../PDFTemplate/newpdf.pdf";
            //Response.Write("<script> alert('已生成pdf');</script>");
        }
        #endregion

        #region 普通水印
        protected void WaterMark_Click(object sender, EventArgs e)
        {
            string pdfTemplate = Server.MapPath("~/PDFTemplate/pdfTemplate.pdf");
            string newpdf = Server.MapPath("~/PDFTemplate/newpdf1.pdf");
            //添加水印############
            new PdfWatermark().setWatermark(pdfTemplate, newpdf, "仪器信息网");
           // iframepdf.Attributes["src"] = "../PDFTemplate/newpdf1.pdf";
            //Response.Write("<script> alert('已生成pdf');</script>");
        }
        #endregion

        #region 图片水印
        protected void WaterMarkPic_Click(object sender, EventArgs e)
        {
            string pdfTemplate = Server.MapPath("~/PDFTemplate/pdfTemplate.pdf");
            string newpdf = Server.MapPath("~/PDFTemplate/newpdf2.pdf");
            //添加图片水印############
            new PdfWatermark().PDFWatermark(pdfTemplate, newpdf, Server.MapPath("~/Images/200_50logo.gif"), 0, 0);
           // iframepdf.Attributes["src"] = "../PDFTemplate/newpdf2.pdf";
            //Response.Write("<script> alert('已生成pdf');</script>");
        }
        #endregion

        #region 添加印章
        protected void PdfImg_Click(object sender, EventArgs e)
        {
            string pdfTemplate = Server.MapPath("~/PDFTemplate/pdfTemplate.pdf");
            string newpdf = Server.MapPath("~/PDFTemplate/newpdf3.pdf");
            //追加图片#############
            FileStream fs = new FileStream(Server.MapPath("~/Images/yinzhang.png"), FileMode.Open);
            byte[] byData = new byte[fs.Length];
            fs.Read(byData, 0, byData.Length);
            fs.Close();
            PdfImage pdfimg = new PdfImage("", 100f, 100f, 400f, 470f, false, byData);
            List<PdfImage> listimg = new List<PdfImage>();
            listimg.Add(pdfimg);
            pdfimg.PutImages(pdfTemplate, newpdf, listimg);
           // iframepdf.Attributes["src"] = "../PDFTemplate/newpdf3.pdf";
            //Response.Write("<script> alert('已生成pdf');</script>");
        }
        #endregion

        #region 添加表格
        protected void PdfTable_Click(object sender, EventArgs e)
        {
            string pdfTemplate = Server.MapPath("~/PDFTemplate/pdfTemplate.pdf");
            string newpdf = Server.MapPath("~/PDFTemplate/newpdf4.pdf");
            //追加表格############
            StringBuilder tableHtml = new StringBuilder();
            tableHtml.Append(@"<table>
                <tr><td>项目</td><td>细类</td><td>价格</td><td>数量</td><td>投放时间</td><td>金额</td></tr>
                <tr><td>钻石会员</td><td>基础服务</td><td>69800元/月</td><td>1年</td><td>2016.01.03-2017.01.02</td><td>69800</td></tr>
                <tr><td>核酸纯化系统专场</td><td>金榜题名</td><td>70000元/月</td><td>1年</td><td>2016.01.03-2017.01.02</td><td>7000</td></tr>
                </table>");
            new PdfTable().PutTable(pdfTemplate, newpdf, tableHtml.ToString());
           // iframepdf.Attributes["src"] = "../PDFTemplate/newpdf4.pdf";
            //Response.Write("<script> alert('已生成pdf');</script>");
        }
        #endregion
    }
}