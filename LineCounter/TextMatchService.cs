namespace LineCounter;

public class TextMatchService : ITextMatchService
{
    public int MatchingLineCount { get; private set; } = 0;
    public int TotalLineCount { get; private set; } = 0;

    public void GatherMatchStats(string text, string searchText)
    {
        if (text.Contains(searchText))
        {
            MatchingLineCount++;
        }

        TotalLineCount++;
    }
}