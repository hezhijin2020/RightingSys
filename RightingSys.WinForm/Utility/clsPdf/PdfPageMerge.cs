using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace RightingSys.WinForm.Utility.cls
{
    public class PdfPageMerge
    {
        private PdfWriter pw;
        private PdfReader reader;
        private Document document;
        private PdfContentByte cb;
        private PdfImportedPage newPage;
        private FileStream fs;
        /// <summary>
        /// 通过输出文件来构建合并管理，合并到新增文件中,合并完成后调用FinishedMerge方法
        /// </summary>
        /// <param name="sOutFiles">输出文件</param>
        public PdfPageMerge(string sOutFiles)
        {
            document = new Document(PageSize.A4);
            fs = new FileStream(sOutFiles, FileMode.Create);
            pw = PdfWriter.GetInstance(document, fs);
            document.Open();
            cb = pw.DirectContent;
        }
        /// <summary>
        /// 通过文件流来合并文件，合并到当前的可写流中，合并完成后调用FinishedMerge方法
        /// </summary>
        /// <param name="sm"></param>
        public PdfPageMerge(Stream sm)
        {
            document = new Document();
            pw = PdfWriter.GetInstance(document, sm);
            document.Open();
            cb = pw.DirectContent;
        }
        /// <summary>
        /// 合并文件
        /// </summary>
        /// <param name="sFiles">需要合并的文件路径名称</param>
        /// <returns></returns>
        public bool MergeFile(string sFiles)
        {
            reader = new PdfReader(sFiles);
            {
                int iPageNum = reader.NumberOfPages;
                for (int j = 1; j <= iPageNum; j++)
                {
                    newPage = pw.GetImportedPage(reader, j);
                    //Rectangle r = reader.GetPageSize(j);
                    Rectangle r = reader.GetPageSizeWithRotation(j);
                    document.SetPageSize(r);
                    cb.AddTemplate(newPage, 0, 0);
                    document.NewPage();
                }

            }
            reader.Close();
            return true;
        }
        /// <summary>
        /// 通过字节数据合并文件
        /// </summary>
        /// <param name="pdfIn">PDF字节数据</param>
        /// <returns></returns>
        public bool MergeFile(byte[] pdfIn)
        {
            reader = new PdfReader(pdfIn);
            {
                int iPageNum = reader.NumberOfPages;
                for (int j = 1; j <= iPageNum; j++)
                {
                    newPage = pw.GetImportedPage(reader, j);
                    Rectangle r = reader.GetPageSize(j);
                    document.SetPageSize(r);
                    document.NewPage();
                    cb.AddTemplate(newPage, 0, 0);
                }
            }
            reader.Close();
            return true;
        }
        /// <summary>
        /// 通过PDF文件流合并文件
        /// </summary>
        /// <param name="pdfStream">PDF文件流</param>
        /// <returns></returns>
        public bool MergeFile(Stream pdfStream)
        {
            reader = new PdfReader(pdfStream);
            {
                int iPageNum = reader.NumberOfPages;
                for (int j = 1; j <= iPageNum; j++)
                {
                    newPage = pw.GetImportedPage(reader, j);
                    Rectangle r = reader.GetPageSize(j);
                    document.SetPageSize(r);
                    document.NewPage();
                    cb.AddTemplate(newPage, 0, 0);
                }
            }
            reader.Close();
            return true;
        }
        /// <summary>
        /// 通过网络地址来合并文件
        /// </summary>
        /// <param name="pdfUrl">需要合并的PDF的网络路径</param>
        /// <returns></returns>
        public bool MergeFile(Uri pdfUrl)
        {
            reader = new PdfReader(pdfUrl);
            {
                int iPageNum = reader.NumberOfPages;
                for (int j = 1; j <= iPageNum; j++)
                {
                    newPage = pw.GetImportedPage(reader, j);
                    Rectangle r = reader.GetPageSize(j);
                    document.SetPageSize(r);
                    document.NewPage();
                    cb.AddTemplate(newPage, 0, 0);
                }
            }
            reader.Close();
            return true;
        }
        /// <summary>
        /// 完成合并
        /// </summary>
        public void FinishedMerge()
        {
            try
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (pw != null)
                {
                    pw.Flush();
                    pw.Close();
                }
                if (fs != null)
                {
                    fs.Flush();
                    fs.Close();
                }
                if (document.IsOpen())
                {
                    document.Close();
                }
            }
            catch
            {
            }
        }

        public static string AddCommentsToFile(string fileName, string outfilepath, string userComments, PdfPTable newTable)
        {
            string outputFileName = outfilepath;
            //Step 1: Create a Docuement-Object
            Document document = new Document();
            try
            {
                //Step 2: we create a writer that listens to the document
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputFileName, FileMode.Create));

                //Step 3: Open the document
                document.Open();

                PdfContentByte cb = writer.DirectContent;

                //The current file path
                string filename = fileName;

                // we create a reader for the document
                PdfReader reader = new PdfReader(filename);

                for (int pageNumber = 1; pageNumber < reader.NumberOfPages + 1; pageNumber++)
                {
                    document.SetPageSize(reader.GetPageSizeWithRotation(1));
                    document.NewPage();

                    //Insert to Destination on the first page
                    if (pageNumber == 1)
                    {
                        Chunk fileRef = new Chunk(" ");
                        fileRef.SetLocalDestination(filename);
                        document.Add(fileRef);
                    }

                    PdfImportedPage page = writer.GetImportedPage(reader, pageNumber);
                    int rotation = reader.GetPageRotation(pageNumber);
                    if (rotation == 90 || rotation == 270)
                    {
                        cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(pageNumber).Height);
                    }
                    else
                    {
                        cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                    }
                }

                // Add a new page to the pdf file
                document.NewPage();

                Paragraph paragraph = new Paragraph();
                Font titleFont = new Font(iTextSharp.text.Font.HELVETICA
                                          , 15
                                          , iTextSharp.text.Font.BOLD
                                          , Color.BLACK
                    );
                Chunk titleChunk = new Chunk("Comments", titleFont);
                paragraph.Add(titleChunk);
                document.Add(paragraph);

                paragraph = new Paragraph();
                Font textFont = new Font(iTextSharp.text.Font.HELVETICA
                                         , 12
                                         , iTextSharp.text.Font.NORMAL
                                         , Color.BLACK
                    );
                Chunk textChunk = new Chunk(userComments, textFont);
                paragraph.Add(textChunk);

                document.Add(paragraph);
                document.Add(newTable);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                document.Close();
            }
            return outputFileName;
        }

    }
}