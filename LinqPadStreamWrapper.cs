using System;
using System.Text;
using Hilda.Shared.Contracts.Models;

namespace LinqPadUtils
{
    public class LinqPadStreamWrapper : IStreamWrapper
    {
        public void Dispose()
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: Disposar...");
        }

        public void CreateStreamWriter(string fileName, bool append)
        {
            CreateStreamWriter(fileName, append, false);
        }

        public void CreateStreamWriter(string fileName, bool append, bool prependAbsolutePaths)
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: Skapar StreamWriter f�r fil: {fileName} (append: {append}, prependAbsolutePaths: {prependAbsolutePaths})");
        }

        public void Write(string value)
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: Skriver till stream, data: {value}");
        }

        public void Write(byte[] value)
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: Skriver till stream, data: {value.Length} bytes");
        }

        public void Flush()
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: Flushar...");
        }

        public void Close()
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: St�nger");
        }

        public void CreateStreamReader(string fileName)
        {
            CreateStreamReader(fileName, false);
        }

        public void CreateStreamReader(string fileName, bool prependAbsolutePaths)
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: Skapar StreamReader f�r fil: {fileName} (prependAbsolutePaths: {prependAbsolutePaths})");
        }

        public string ReadToEnd()
        {
            Console.WriteLine($"{nameof(LinqPadStreamWrapper)}:: L�ser fil.");
            var sb = new StringBuilder();
            sb.AppendLine("BEGINNING OF FILE ===");
            sb.AppendLine("FILE CONTENT ROW 2");
            sb.AppendLine("FILE CONTENT ROW 3");
            sb.AppendLine("FILE CONTENT ROW 4");
            sb.AppendLine("END OF FILE ===");
            return sb.ToString();
        }
    }
}