using Hilda.Shared.PDF.Contracts.Interfaces;

namespace LinqPadUtils
{
    internal class FakeRect : IPdfRect
    {
        public FakeRect(double x, double y, double width, double height)
        {
            Left = x;
            Bottom = y;
            Width = width;
            Height = height;
        }

        public FakeRect()
        {
        }

        public double Left { get; set; }
        public double Bottom { get; set; }
        public double Right { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}