using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace PDF_Splitter
{
    public static class Utils
    {
        public static void ExtractPagePerSize(string sourcePdfPath, string outputPdfPath, int pageNumber, decimal maxFileSize)
        {
            PdfReader reader = null;
            FileInfo info = new FileInfo(sourcePdfPath);
            Dictionary<int, Tuple<Document, FileStream, PdfSmartCopy>> docs = new Dictionary<int, Tuple<Document, FileStream, PdfSmartCopy>>();

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                reader = new PdfReader(sourcePdfPath);

                int docIndex = 0;
                int currentPage = 0;
                for (int i = 0; i < reader.NumberOfPages; i++)
                {
                    currentPage = i + 1;
                    Document document;
                    FileStream fs;
                    PdfSmartCopy pdfCopyProvider;
                    if (docs.Count <= 0)
                    {
                        document = new Document(reader.GetPageSizeWithRotation(currentPage));
                        fs = new FileStream(Path.Combine(outputPdfPath, info.Name.Replace(info.Extension, "") + "_" + docIndex + ".pdf"), System.IO.FileMode.Create);
                        pdfCopyProvider = new PdfSmartCopy(document, fs);
                        pdfCopyProvider.SetFullCompression();
                        document.Open();
                        docs.Add(docIndex, new Tuple<Document, FileStream, PdfSmartCopy>(document, fs, pdfCopyProvider));
                    }
                    else
                    {

                        decimal overhead = maxFileSize * 0.20m;
                        if (docs[docIndex].Item2.Length > ((maxFileSize - overhead) * 1024 * 1024))
                        {
                            docIndex++;
                            document = new Document(reader.GetPageSizeWithRotation(currentPage));
                            fs = new FileStream(Path.Combine(outputPdfPath, info.Name.Replace(info.Extension, "") + "_" + docIndex + ".pdf"), System.IO.FileMode.Create);
                            pdfCopyProvider = new PdfSmartCopy(document, fs);
                            pdfCopyProvider.SetFullCompression();
                            document.Open();
                            docs.Add(docIndex, new Tuple<Document, FileStream, PdfSmartCopy>(document, fs, pdfCopyProvider));
                        }
                        else
                        {
                            pdfCopyProvider = docs[docIndex].Item3;

                        }
                    }

                    PdfImportedPage importedPage = pdfCopyProvider.GetImportedPage(reader, currentPage);
                    pdfCopyProvider.AddPage(importedPage);

                    //if (docs[docIndex].Item2.Length > 2000000)
                    //{
                    //}
                }

                // Capture the correct size and orientation for the page:


                // Initialize an instance of the PdfCopyClass with the source 
                // document and an output file stream:


                // Extract the desired page number:


                foreach (Tuple<Document, FileStream, PdfSmartCopy> i in docs.Values)
                {
                    i.Item1.Close();
                    i.Item2.Close();
                    i.Item3.Close();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void MergePDFs(string outPutFilePath, params string[] filesPath)
        {
            List<PdfReader> readerList = new List<PdfReader>();
            foreach (string filePath in filesPath.OrderBy(x => x))
            {
                PdfReader pdfReader = new PdfReader(filePath);
                PdfReader.unethicalreading = true;
                readerList.Add(pdfReader);
            }

            //Define a new output document and its size, type
            Document document = new Document(PageSize.A4, 0, 0, 0, 0);
            //Create blank output pdf file and get the stream to write on it.
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outPutFilePath, FileMode.Create));
            writer.PdfVersion = PdfWriter.VERSION_1_5;

            writer.SetFullCompression();

            document.Open();
            foreach (PdfReader reader in readerList)
            {

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    PdfImportedPage page = writer.GetImportedPage(reader, i);

                    document.Add(iTextSharp.text.Image.GetInstance(page));
                }
            }


            document.Close();
        }

        public static void ExtractPagePerPage(string sourcePdfPath, string outputPdfPath, int pages)
        {
            PdfReader reader = null;
            FileInfo info = new FileInfo(sourcePdfPath);
            Dictionary<int, Tuple<Document, FileStream, PdfSmartCopy>> docs = new Dictionary<int, Tuple<Document, FileStream, PdfSmartCopy>>();

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                reader = new PdfReader(sourcePdfPath);

                int docIndex = 1;
                int currentPage = 0;
                int pageCounter = 0;
                for (int i = 0; i < reader.NumberOfPages; i++)
                {
                    currentPage = i + 1;

                    Document document;
                    FileStream fs;
                    PdfSmartCopy pdfCopyProvider;
                    if (docs.Count <= 0)
                    {
                        document = new Document(reader.GetPageSizeWithRotation(currentPage));
                        string fileName = GetTextFromPDF(reader, docIndex);
                        fs = new FileStream(Path.Combine(outputPdfPath, fileName + ".pdf"), System.IO.FileMode.Create);
                        pdfCopyProvider = new PdfSmartCopy(document, fs);
                        pdfCopyProvider.SetFullCompression();
                        document.Open();
                        docs.Add(docIndex, new Tuple<Document, FileStream, PdfSmartCopy>(document, fs, pdfCopyProvider));
                        pageCounter = 1;
                    }
                    else
                    {
                        if (pageCounter >= pages)
                        {
                            docIndex++;
                            document = new Document(reader.GetPageSizeWithRotation(currentPage));
                            string fileName = GetTextFromPDF(reader, docIndex);
                            string destinationPath = Path.Combine(outputPdfPath, fileName + ".pdf");
                            if (!File.Exists(destinationPath))
                            {
                                fs = new FileStream(destinationPath, System.IO.FileMode.Create);
                                pdfCopyProvider = new PdfSmartCopy(document, fs);
                                pdfCopyProvider.SetFullCompression();
                                document.Open();
                                docs.Add(docIndex, new Tuple<Document, FileStream, PdfSmartCopy>(document, fs, pdfCopyProvider));
                            }
                            else
                            {
                                pdfCopyProvider = null;
                            }
                           
                            pageCounter = 1;
                        }
                        else
                        {
                            pdfCopyProvider = docs[docIndex].Item3;
                            pageCounter++;

                        }
                    }

                    if (pdfCopyProvider != null)
                    {
                        PdfImportedPage importedPage = pdfCopyProvider.GetImportedPage(reader, currentPage);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                }

                foreach (Tuple<Document, FileStream, PdfSmartCopy> i in docs.Values)
                {
                    i.Item1.Close();
                    i.Item2.Close();
                    i.Item3.Close();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string GetTextFromPDF(PdfReader reader, int page)
        {
            try
            {

                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                string currentPageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                string fName = Regex.Match(currentPageText, @"(?<=guid.*\S).*", RegexOptions.IgnoreCase | RegexOptions.Multiline).Captures[0].Value.Trim();
                return fName;
                //CultureInfo cultureInfo = CultureInfo.InvariantCulture;
                //TextInfo textInfo = cultureInfo.TextInfo;

                //return textInfo.ToTitleCase(fName.ToLowerInvariant());
            }
            catch (Exception)
            {

                return "Page_" + page.ToString().PadLeft(3, '0');
            }
        }
    }
}
