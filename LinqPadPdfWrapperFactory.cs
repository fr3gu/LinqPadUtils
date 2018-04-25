using Hilda.Shared.PDF.Contracts.Interfaces;

namespace LinqPadUtils
{
    public class LinqPadPdfWrapperFactory : IPdfWrapperFactory
    {
        public IPdfWrapper Create(string fileName, bool initialize = true)
        {
            return initialize ? new LinqPadPdfWrapper(fileName) : new LinqPadPdfWrapper {FileName = fileName};
        }
    }
}