using System.IO;

namespace WrapStaticAfter
{
    public class LineReader : ILineReader
    {
        public string[] ReadLines(string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (!File.Exists(filePath))
                return new[] { "" };
            return File.ReadAllLines(filePath);
        }
    }
}