using System.Net;

namespace LineCounter.LineSources
{
    internal class WebLineSource : ILineSource
    {
        private StreamReader _reader;

        public WebLineSource(string url)
        {
            var webClient = new WebClient();
            var stream = webClient.OpenRead(url);
            _reader = new StreamReader(stream);
        }
        public string GetNextLine()
        {
            return _reader.ReadLine();
        }
    }
}
