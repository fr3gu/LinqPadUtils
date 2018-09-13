// //-----------------------------------------------------------------------------
// // <copyright file="LinqPadPdfWrapper.cs" company="YourVoice">
// //     Copyright (c) Your Voice Network AB.  All rights reserved.
// // </copyright>
// //-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using Hilda.Shared.PDF.Contracts.Enums;
using Hilda.Shared.PDF.Contracts.Interfaces;
using Hilda.Shared.PDF.Contracts.Models;

namespace LinqPadUtils
{
    public class LinqPadPdfWrapper : IPdfWrapper
    {
        private readonly List<int> _pages;
        private int _browserWidth;
        private double _hPos;
        private bool _isTopDown;
        private int _objectCount;
        private int _pageId;
        private FakeRect _rect;
        private double _vPos;

        public void AddContent(string rawHtml)
        {
            throw new NotImplementedException();
        }

        public void AddContent(string rawHtml, string headerRawHtml, string footerRawHtml)
        {
            throw new NotImplementedException();
        }

        public void AddContent(string rawHtml, string headerRawHtml, string footerRawHtml, bool newPage)
        {
            throw new NotImplementedException();
        }

        public void AddContent(string rawHtml, string headerRawHtml, string footerRawHtml, string headerFirstRawHtml, string footerFirstRawHtml, bool newPage)
        {
            throw new NotImplementedException();
        }

        public void AddContent(string[] urls, string headerRawHtml, string footerRawHtml, string headerFirstRawHtml, string footerFirstRawHtml, bool newPage)
        {
            throw new NotImplementedException();
        }

        public void AddContent(string url, bool newPage)
        {
            throw new NotImplementedException();
        }

        public int AddFont(string fontName)
        {
            return _objectCount++;
        }

        public int AddImageBitmap(Bitmap bm, bool transparent)
        {
            Console.WriteLine($"Adding bitmap image... ({bm.Size.ToString()})");
            return _objectCount++;
        }

        public int AddImageCopy(int imageId)
        {
            return _objectCount++;
        }

        public int AddImageFile(string imageFilePath, int frame)
        {
            return _objectCount++;
        }

        public int AddImageHtml(string imageHtml)
        {
            return _objectCount++;
        }

        public int AddImageObject(IPdfImage theImg, bool transparent)
        {
            return _objectCount++;
        }

        public int AddImageToChain(int id)
        {
            throw new NotImplementedException();
        }

        public int AddLine(double x, double y, double w, double h)
        {
            return _objectCount++;
        }

        public int AddPage()
        {
            var newPageId = _pages.Max() + 1;
            _pages.Add(newPageId);
            return newPageId;
        }

        public int AddText(string text)
        {
            return _objectCount++;
        }

        public void ConfigPdfDoc(PdfDocConfiguration config)
        {
            //
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCurrentPage()
        {
            //
        }

        public int EmbedFont(string fontName, PdfLanguageType languageType)
        {
            throw new NotImplementedException();
        }

        public int EmbedFont(string fontName)
        {
            return _objectCount++;
        }

        public string FileName { get; set; }

        public int FillRect()
        {
            return _objectCount++;
        }

        public void Flatten()
        {
            //
        }

        public void FrameRect()
        {
            //
        }

        public Color GetColor()
        {
            throw new NotImplementedException();
        }

        public int GetFontSize()
        {
            throw new NotImplementedException();
        }

        public double GetHPos()
        {
            return _hPos;
        }

        public bool IsChainable(int pdfId)
        {
            throw new NotImplementedException();
        }

        public IPdfImage GetImage(string imageFilePath)
        {
            return new FakeImage();
        }

        public IPdfImage GetImage(byte[] imageData)
        {
            throw new NotImplementedException();
        }

        public string GetInfo(int id, string type)
        {
            throw new NotImplementedException();
        }

        public int GetLayer()
        {
            throw new NotImplementedException();
        }

        public IPdfRect GetMediaBox()
        {
            throw new NotImplementedException();
        }

        public string GetMediaBoxString()
        {
            throw new NotImplementedException();
        }

        public int GetPage() => _pageId;
        public int GetPageNumber()
        {
            throw new NotImplementedException();
        }

        public byte[] GetPdfDocData()
        {
            return new byte[] { };
        }

        public IPdfPos GetPos()
        {
            throw new NotImplementedException();
        }

        public IPdfRect GetRect()
        {
            return _rect ?? (_rect = new FakeRect());
        }

        public PdfPinToCorner GetRectPin()
        {
            throw new NotImplementedException();
        }

        public string GetRectString()
        {
            if (_rect == null) _rect = new FakeRect();
            return $"{_rect.Top},{_rect.Right},{_rect.Left},{_rect.Bottom}";
        }

        public double GetVPos()
        {
            return _vPos;
        }

        public double GetHeadHeightFirst()
        {
            throw new NotImplementedException();
        }

        public double GetHeadHeight()
        {
            throw new NotImplementedException();
        }

        public double GetFootHeightFirst()
        {
            throw new NotImplementedException();
        }

        public double GetFootHeight()
        {
            throw new NotImplementedException();
        }

        public double GetWidthMargin()
        {
            throw new NotImplementedException();
        }

        public double GetHeightMargin()
        {
            throw new NotImplementedException();
        }

        public int LayerCount => 1;

        public void Read(Stream stream, string password)
        {
            throw new NotImplementedException();
        }

        public void Read(string path)
        {
            throw new NotImplementedException();
        }

        public void Read(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void Read(Stream stream)
        {
            throw new NotImplementedException();
        }

        public void Read(string path, string password)
        {
            throw new NotImplementedException();
        }

        public void Read(byte[] data, string password)
        {
            throw new NotImplementedException();
        }

        public int Root => 1;
        public int PageCount { get; }

        public void Rotate(int angle, double anchorX, double anchorY)
        {
            //
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetBrowserWidth(int browserWidth)
        {
            _browserWidth = browserWidth;
        }

        public void SetColor(string colorString)
        {
            //
        }

        public void SetColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void SetFont(int fontId)
        {
            //
        }

        public void SetFont(string name, double size, double lineSpacing)
        {
            //
        }

        public void SetFontSize(int fontSize)
        {
            //
        }

        public void SetFootHeight(int height)
        {
            throw new NotImplementedException();
        }

        public void SetFootHeightFirst(int height)
        {
            throw new NotImplementedException();
        }

        public void SetHeadHeight(int height)
        {
            throw new NotImplementedException();
        }

        public void SetHeadHeightFirst(int height)
        {
            throw new NotImplementedException();
        }

        public void SetHeightMargin(int margin)
        {
            throw new NotImplementedException();
        }

        public void SetHPos(double x)
        {
            _hPos = x;
        }

        public void SetHtmlOptions(PdfEngineType engineType)
        {
            //
        }

        public void SetHtmlOptions(PdfMediaType mediaType)
        {
            throw new NotImplementedException();
        }

        public void SetHtmlOptionsBrowserWidth(int width)
        {
            //
        }

        public void SetInfo(int id, string type, string info)
        {
            //
        }

        public void SetIsBold(bool isBold)
        {
            //
        }

        public void SetLayer(int layer)
        {
            //
        }

        public void SetLineSpacing(double height)
        {
            //
        }

        public void SetMargins()
        {
            throw new NotImplementedException();
        }

        public void SetMarginsFirst()
        {
            throw new NotImplementedException();
        }

        public void SetMediaBox(string coords)
        {
            throw new NotImplementedException();
        }

        public void SetMediaBox(IPdfRect rect)
        {
            throw new NotImplementedException();
        }

        public void SetMediaBox(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }

        public void SetPage(int pageId)
        {
            _pageId = pageId;
        }

        public void SetPageNumber(int pageNumber)
        {
            throw new NotImplementedException();
        }

        public void SetPos(string coords)
        {
            throw new NotImplementedException();
        }

        public void SetPos(double x, double y)
        {
            throw new NotImplementedException();
        }

        public void SetPos(IPdfPos pos)
        {
            throw new NotImplementedException();
        }

        public void SetRect(string coords)
        {
            //When working in standard PDF coordinates the format of the string is "left bottom right top".
            //When working with top-down coordinates the format of the string is "left top right bottom".
            var coordsArray = coords.Replace(" ", ",").Split(',');
            var retVal = new FakeRect();
            if (_isTopDown)
            {
                retVal.Left = ToDouble(coordsArray[0]);
                retVal.Top = ToDouble(coordsArray[1]);
                if (coordsArray.Length > 2)
                {
                    retVal.Right = ToDouble(coordsArray[2]);
                    retVal.Bottom = ToDouble(coordsArray[3]);
                }
            }
            else
            {
                retVal.Left = ToDouble(coordsArray[0]);
                retVal.Bottom = ToDouble(coordsArray[1]);
                if (coordsArray.Length > 2)
                {
                    retVal.Right = ToDouble(coordsArray[2]);
                    retVal.Top = ToDouble(coordsArray[3]);
                }
            }
            _rect = retVal;
        }

        public void SetRect(IPdfRect rect)
        {
            throw new NotImplementedException();
        }

        public void SetRect(double x, double y, double width, double height)
        {
            _rect = new FakeRect(x, y, width, height);
        }

        public void SetRectInset(double x, double y)
        {
            //
        }

        public void SetRectPin(PdfPinToCorner pinToCorner)
        {
            //
        }

        public void SetTopDown(bool isTopDown)
        {
            _isTopDown = isTopDown;
        }

        public void SetUnitType(PdfUnitType units)
        {
            //
        }

        public void SetWidth(double width)
        {
            //
        }

        public void SetWidthMargin(int margin)
        {
            throw new NotImplementedException();
        }

        public void SetVPos(double y)
        {
            _vPos = y;
        }

        public void TransformReset()
        {
            //
        }

        public LinqPadPdfWrapper()
        {
            
        }

        public LinqPadPdfWrapper(string fileName)
        {
            Console.WriteLine("Created PDF...(" + fileName + ")");
            FileName = fileName;
            _rect = null;
            _objectCount = 0;
            _isTopDown = false;
            _pageId = 0;
            _pages = new List<int> {0};
            _browserWidth = 0;
        }

        private static double ToDouble(string coords)
        {
            return string.IsNullOrEmpty(coords) ? 0D : double.Parse(coords, NumberStyles.AllowDecimalPoint, new NumberFormatInfo {CurrencyDecimalSeparator = "."});
        }
    }
}