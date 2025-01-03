using System.Net;

namespace LineCounter.LineSources
{
    internal class WebLineSource : ILineSource
    {
        private StreamReader _reader;

        public WebLineSource(string url)
        {
            var httpClient = new HttpClient();
            var stream = httpClient.GetStreamAsync(url).Result;
            _reader = new StreamReader(stream);
        }
        
        public string? GetNextLine()
        {
            return _reader.ReadLine();
        }
    }
}
