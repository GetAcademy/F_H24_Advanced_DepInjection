namespace LineCounter;

public interface ITextMatchService
{
    int MatchingLineCount { get; }
    int TotalLineCount { get; }
    void GatherMatchStats(string text, string searchText);
}