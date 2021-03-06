using System;
using System.Text;
using Hilda.Shared.Contracts.Models;

namespace LinqPadUtils
{
    public class LinqPadFileWrapper : IFileWrapper
    {
        private readonly string _absoluteAppPath;
        private readonly string _absoluteOpen24Path;

        public LinqPadFileWrapper(string absoluteAppPath, string absoluteOpen24Path)
        {
            this._absoluteAppPath = absoluteAppPath;
            this._absoluteOpen24Path = absoluteOpen24Path;
        }

        public bool Exists(string fileName)
        {
            return this.Exists(fileName, false);
        }

        public bool Exists(string fileName, bool prependAbsolutePaths)
        {
            Console.WriteLine($"{nameof(LinqPadFileWrapper)}:: Letade efter fil: {fileName} (prependAbsolutePaths: {prependAbsolutePaths}). Returnerar 'true'");
            return true;
        }

        public void WriteAllBytes(string fileName, byte[] data)
        {
            this.WriteAllBytes(fileName, data, false);
        }

        public byte[] ReadAllBytes(string fileName)
        {
            var lorem = Encoding.UTF8.GetBytes("Lorem ipsum");

            Console.WriteLine($"{nameof(LinqPadFileWrapper)}:: Fejkar l�sning fr�n fil: {fileName} ({lorem.Length} bytes med data, prependAbsolutePaths: {false})");

            return lorem;
        }

        public void WriteAllBytes(string fileName, byte[] data, bool prependAbsolutePaths)
        {
            Console.WriteLine($"{nameof(LinqPadFileWrapper)}:: Fejkar skrivning till fil: {fileName} ({data.Length} bytes med data, prependAbsolutePaths: {prependAbsolutePaths})");
        }
    }
}