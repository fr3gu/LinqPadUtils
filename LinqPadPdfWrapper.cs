using System;
using System.Globalization;
using Hilda.Shared.PDF.Contracts.Enums;
using Hilda.Shared.PDF.Contracts.Interfaces;
using Hilda.Shared.PDF.Contracts.Models;

namespace LinqPadUtils
{
    public class LinqPadPdfWrapper : IPdfWrapper
    {
        private FakeRect _rect;
        private double _hPos;
        private double _vPos;
        private int _imageCount;
        private int _fontCount;
        private bool _isTopDown;

        public string FileName { get; }
        public int LayerCount => 1;
        public int Root => 1;

        public LinqPadPdfWrapper(string fileName)
        {
            Console.WriteLine("Created PDF...(" + fileName + ")");
            FileName = fileName;
            _rect = null;
            _imageCount = 0;
            _fontCount = 0;
            _isTopDown = false;
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

        public IPdfImage GetImage(string imageFilePath)
        {
            return new FakeImage();
        }

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

        public double GetHPos()
        {
            return _hPos;
        }

        public void Rotate(int angle, double anchorX, double anchorY)
        {
            //
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

        public void SetHPos(double x)
        {
            _hPos = x;
        }

        public void SetHtmlOptions(PdfEngineType engineType)
        {
            //
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

        private static double ToDouble(string coords)
        {
            return string.IsNullOrEmpty(coords) ? 0D : double.Parse(coords, NumberStyles.AllowDecimalPoint, new NumberFormatInfo { CurrencyDecimalSeparator = "."});
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

        public void SetVPos(double y)
        {
            _vPos = y;
        }

        public void SetWidth(double width)
        {
            //
        }

        public void TransformReset()
        {
            //
        }
    }
}
