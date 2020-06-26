using iTextSharp.text.pdf;
using RightingSys.WinForm.Utility.cls;
using System;
using System.IO;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class JobFilesEditForm : BaseForm
    {
        /// <summary>
        /// 声明变量
        /// </summary>
        BLL.JobFilesManager manager = new BLL.JobFilesManager();
        Models.ys_JobFiles model = new Models.ys_JobFiles();
        BLL.UserManager userManager = new BLL.UserManager();

        /// <summary>
        /// 新增构造函数
        /// </summary>
        public JobFilesEditForm()
        {
            InitializeComponent();
            tlCategory.Properties.DataSource = manager.GetAllListCategory();
            lkpAuditor.Properties.DataSource = lkpStaff.Properties.DataSource = userManager.GetAllList();
        }

       /// <summary>
       /// 更改构造函数
       /// </summary>
       /// <param name="md">实体</param>
        public JobFilesEditForm(Models.ys_JobFiles md):this()
        {
            model = md;
            txtFileName.Text = model.JobFileName;
            txtDescription.Text = model.Description;
            dAuditorday.EditValue = model.Auditorday;
            tlCategory.EditValue = model.JobFileCategoryId;
            lkpAuditor.EditValue = model.AuditorId;
            lkpStaff.EditValue = model.JobFileStaffId;
            panelEdit.Enabled = false;
            btnFileSelect.Enabled = false;
            pdfView.LoadDocument(new MemoryStream(model.FileImage));
            pdfView.Focus();
        }


        /// <summary>
        /// 保存方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtFileName.Text.Trim() == "" || lkpAuditor.EditValue == null || lkpStaff.EditValue == null || tlCategory.EditValue == null )
            {
               clsPublic.ShowMessage("信息输入不完整，请检查", Text);
                return;
            }
            else
            {
                if (pdfView.DocumentFilePath == "")
                {
                    clsPublic.ShowMessage("请选择要加载的文件", Text); return;
                }
                else
                {
                    model.Id = Guid.NewGuid();

                    model.JobFileCategoryId = clsPublic.GetObjGUID(tlCategory.EditValue);
                    model.JobFileCategoryName = tlCategory.Text;

                    model.JobFileName = txtFileName.Text;
                    model.JobFileStaffId = clsPublic.GetObjGUID(lkpStaff.EditValue);
                    model.JobFileStaffName = lkpStaff.Text;

                    model.OperatorId = Models.SqlHelper.Session._UserId;
                    model.OperatorName = Models.SqlHelper.Session._FullName;
                    model.Auditorday = dAuditorday.DateTime;
                    model.AuditorId = clsPublic.GetObjGUID(lkpAuditor.EditValue);
                    model.AuditorName = lkpAuditor.Text;
                    model.CreateTime = DateTime.Now;
                    model.Description = txtDescription.Text;
                    model.FileImage = File.ReadAllBytes(btnFileSelect.Text);

                    if (manager.AddNew(model))
                    {
                        this.Close();
                        base.DialogResult = DialogResult.OK;
                        clsPublic.ShowMessage("成功", Text);
                    }
                }
            }

        }

        /// <summary>
        /// 文件选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileSelect_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Multiselect = true;
            opfile.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp|PDF|*.pdf";
            if (opfile.ShowDialog() == DialogResult.OK)
            {
                if (opfile.FilterIndex == 1)
                {
                    btnFileSelect.Text = CreatePdf(opfile.FileNames, "档案");
                }
                else
                {
                    if (opfile.FileNames.Length > 1)
                    {
                        clsPublic.ShowMessage("PDF上传的文件，只能选单个文件", Text); return;
                    }
                    else
                    {
                        FileInfo info = new FileInfo(opfile.FileName);
                        if ((info.Length / (1024 * 1024)) > 5)
                        {
                            clsPublic.ShowMessage("PDF上传的文件不能超过5M" + (info.Length / (1024 * 1024)), Text); return;

                        }
                        else
                        {
                            btnFileSelect.Text = opfile.FileName;
                        }
                    }
                }

                pdfView.LoadDocument(btnFileSelect.Text);

            }
        }

        /// <summary>
        /// 创建PDF文件
        /// </summary>
        /// <param name="fileNames">文件名</param>
        /// <param name="strName">名称</param>
        /// <returns></returns>
        private string CreatePdf(string[] fileNames, string strName)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            string SaveName = String.Format(clsPublic.AppDir + "\\pdftemp\\{0}", strName + DateTime.Now.ToString("yyyyMMhhHHmmss") + ".pdf");
            clsPublic.CheckFolderExistsViaFileName(SaveName);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(SaveName, FileMode.Create));
            pdfWriter.SetEncryption(PdfWriter.STRENGTH128BITS, null, null, PdfWriter.AllowCopy);
            doc.Open();
            try
            {
                pdfWriter.PageEvent = new HeaderAndFooterEvent();

                #region 实现页眉和页脚： 

                HeaderAndFooterEvent.PAGE_NUMBER = true;//实现页眉跟页脚 
                HeaderAndFooterEvent.tpl = pdfWriter.DirectContent.CreateTemplate(500, 500); //定义模板
                HeaderAndFooterEvent.HeaderLeft = "株洲紫气东来商贸有限公司";
                HeaderAndFooterEvent.HeaderRight = "IT部存档专用";
                HeaderAndFooterEvent.FooterLeft = "TEL:0731-22965756";
                HeaderAndFooterEvent.FooterRight = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "(UTC)";

                #endregion

                #region 首页
                //每次在添加文本内容之前可以先设置字体，有效期持续到重新设置之前 
                //HeaderAndFooterEvent.SetFont(Color.BLACK, "宋体", 25, 0);
                //添加一个空段落来占位，五个参数分别为：内容，对齐方式（1为居中，0为居左，2为居右），段后空行数，段前空行数，行间距 
                //doc.Add(new Paragraph("jhgjh"));
                //这个方法为上一个方法的重载，三个参数分别为：内容，对齐方式，行间距 
                //doc.Add(new Paragraph("飞行气象文件"));
                // HeaderAndFooterEvent.SetFont(Color.BLACK, "宋体", 18, 0);
                // doc.Add(HeaderAndFooterEvent.AddParagraph(strName, 1, 1.0f));

                #endregion


                #region 新建页和加入内容
                //HeaderAndFooterEvent.SetFont(Color.DARK_GRAY, "宋体", 15, 0);
                //doc.Add(HeaderAndFooterEvent.AddParagraph("飞行气象文件", 1, 1.5f));
                // HeaderAndFooterEvent.SetFont(Color.DARK_GRAY, "宋体", 12);
                //doc.Add(HeaderAndFooterEvent.AddParagraph("航班号：      ", 1, 1.5f));

                #endregion

                #region  加入图片
                //doc.NewPage();
                //四个参数分别为：图片路径，对齐方式，文档的右边距，下边距；边距这两个参数用于计算图片的缩放尺寸。
                foreach (string s in fileNames)
                {
                    doc.Add(HeaderAndFooterEvent.AddImage(s, 1, 0, 0));
                }
                return SaveName;
                #endregion
            }
            catch (Exception e)
            {
                clsPublic.ShowMessage(e.Message);
                return "";
            }
            finally
            {
                pdfWriter.Flush();
                pdfWriter.CloseStream = true;
                doc.Close();
            }
        }
    }
}
