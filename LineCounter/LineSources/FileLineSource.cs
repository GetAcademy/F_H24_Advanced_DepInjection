namespace LineCounter.LineSources
{
    internal class FileLineSource : ILineSource
    {
        private readonly StreamReader _reader;

        public FileLineSource(string filename)
        {
            _reader = new StreamReader(filename);
        }
        public string GetNextLine()
        {
            return _reader.ReadLine();
        }
    }
}
