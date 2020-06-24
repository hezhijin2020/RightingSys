using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace RightingSys.WinForm.Utility.cls
{
    /// <summary>
    /// pdf文本域操作类
    /// </summary>
    public class PdfText
    {
        #region  pdf模板文本域复制
        /// <summary>
        /// 指定pdf模板为其文本域赋值
        /// </summary>
        /// <param name="pdfTemplate">pdf模板路径</param>
        /// <param name="tempFilePath">pdf导出路径</param>
        /// <param name="parameters">pdf模板域键值</param>
        public void PutText(string pdfTemplate, string tempFilePath, Dictionary<string, string> parameters)
        {
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;

            try
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }

                pdfReader = new PdfReader(pdfTemplate);
                pdfStamper = new PdfStamper(pdfReader, new FileStream(tempFilePath, FileMode.OpenOrCreate));

                AcroFields pdfFormFields = pdfStamper.AcroFields;
                pdfStamper.FormFlattening = true;

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                BaseFont simheiBase = BaseFont.CreateFont(@"C:\Windows\Fonts\simhei.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                pdfFormFields.AddSubstitutionFont(simheiBase);

                foreach (KeyValuePair<string, string> parameter in parameters)
                {
                    if (pdfFormFields.Fields[parameter.Key] != null)
                    {
                        pdfFormFields.SetField(parameter.Key, parameter.Value);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pdfStamper.Close();
                pdfReader.Close();

                pdfStamper = null;
                pdfReader = null;
            }
        }
        #endregion
    }
}
