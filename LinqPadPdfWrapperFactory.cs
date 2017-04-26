using Hilda.Shared.PDF.Contracts.Interfaces;

namespace LinqPadUtils
{
    public class LinqPadPdfWrapperFactory : IPdfWrapperFactory
    {
        public IPdfWrapper Create(string fileName)
        {
            return new LinqPadPdfWrapper(fileName);
        }
    }
}