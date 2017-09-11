// //-----------------------------------------------------------------------------
// // <copyright file="LinqPadPdfWrapper.cs" company="YourVoice">
// //     Copyright (c) Your Voice Network AB.  All rights reserved.
// // </copyright>
// //-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Hilda.Shared.PDF.Contracts.Enums;
using Hilda.Shared.PDF.Contracts.Interfaces;
using Hilda.Shared.PDF.Contracts.Models;

namespace LinqPadUtils
{
    public class LinqPadPdfWrapper : IPdfWrapper
    {
        private int _pageId;
        private readonly List<int> _pages;
        private int _browserWidth;
        private int _fontCount;
        private double _hPos;
        private int _imageCount;
        private bool _isTopDown;
        private FakeRect _rect;
        private double _vPos;

        public LinqPadPdfWrapper(string fileName)
        {
            Console.WriteLine("Created PDF...(" + fileName + ")");
            FileName = fileName;
            _rect = null;
            _imageCount = 0;
            _fontCount = 0;
            _isTopDown = false;
            _pageId = 0;
            _pages = new List<int> {0};
            _browserWidth = 0;
        }

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
            return _fontCount++;
        }

        public int AddImageCopy(int imageId)
        {
            return _imageCount++;
        }

        public int AddImageFile(string imageFilePath, int frame)
        {
            return _imageCount++;
        }

        public int AddImageHtml(string imageHtml)
        {
            return _imageCount++;
        }

        public int AddImageObject(IPdfImage theImg, bool transparent)
        {
            return _imageCount++;
        }

        public void AddLine(double x, double y, double w, double h)
        {
            //
        }

        public int AddPage()
        {
            var newPageId = _pages.Max() + 1;
            _pages.Add(newPageId);
            return newPageId;
        }

        public void AddText(string text)
        {
            //
        }

        public void ConfigPdfDoc(PdfDocConfiguration config)
        {
            //
        }

        public void DeleteCurrentPage()
        {
            //
        }

        public string FileName { get; }

        public void FillRect()
        {
            //
        }

        public void Flatten()
        {
            //
        }

        public void FrameRect()
        {
            //
        }

        public double GetHPos()
        {
            return _hPos;
        }

        public IPdfImage GetImage(string imageFilePath)
        {
            return new FakeImage();
        }

        public int GetPage() => _pageId;

        public byte[] GetPdfDocData()
        {
            return new byte[] { };
        }

        public IPdfRect GetRect()
        {
            return _rect ?? (_rect = new FakeRect());
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

        public int LayerCount => 1;
        public int Root => 1;

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

        public void SetPage(int pageId)
        {
            _pageId = pageId;
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

        private static double ToDouble(string coords)
        {
            return string.IsNullOrEmpty(coords) ? 0D : double.Parse(coords, NumberStyles.AllowDecimalPoint, new NumberFormatInfo {CurrencyDecimalSeparator = "."});
        }
    }
}