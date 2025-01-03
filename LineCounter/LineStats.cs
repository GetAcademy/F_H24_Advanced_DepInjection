namespace LineCounter
{
    public class LineStats
    {
        public string SearchText { get; }
        public int MatchingLineCount { get; }
        public int TotalLineCount { get; }

        public LineStats(int matchingLineCount, int totalLineCount, string searchText)
        {
            SearchText = searchText;
            MatchingLineCount = matchingLineCount;
            TotalLineCount = totalLineCount;
        }

        public void Show()
        {
            Console.WriteLine($"{MatchingLineCount} av {TotalLineCount} linjer inneholder {SearchText}");
        }
    }
}
