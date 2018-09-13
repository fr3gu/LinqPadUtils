using Hilda.Shared.PDF.Contracts.Interfaces;

namespace LinqPadUtils
{
    internal class FakeImage : IPdfImage
    {
        public void SetFile(string imageFilePath)
        {
            //
        }

        public void SetData(byte[] data)
        {
            throw new System.NotImplementedException();
        }

        public double Width => 640;
        public double Height => 480;
        public dynamic GetImage()
        {
            return new FakeImage();
        }
    }
}