using LineCounter.LineSources;

namespace LineCounter
{
    public class LineCountService
    {
        private readonly ILineSource _lineSource;

        public LineCountService(ILineSource lineSource)
        {
            _lineSource = lineSource;
        }

        public LineStats GetStats(string searchText)
        {
            //using var reader = new StreamReader("vgsak.txt");
            var matchingLineCount = 0;
            var totalLineCount = 0;
            var line = _lineSource.GetNextLine();
            while (line != null)
            {
                if (line.Contains(searchText))
                {
                    matchingLineCount++;
                }

                totalLineCount++;
                line = _lineSource.GetNextLine();
            }
            return new LineStats(matchingLineCount, totalLineCount, searchText);
        }
    }
}
