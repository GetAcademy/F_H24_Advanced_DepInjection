using LineCounter.LineSources;

namespace LineCounter
{
    public class LineCountService : ILineCountService
    {
        private readonly ILineSource _lineSource;
        private readonly ITextMatchService _textMatchService;

        public LineCountService(ILineSourceFactory lineSourceFactory, ITextMatchService textMatchService)
        {
            _lineSource = lineSourceFactory.CreateWebLineSource("https://www.vg.no/nyheter/i/nybAQd/lo-ber-om-at-nho-blir-med-paa-erna-solbergs-fredning-av-sykeloennsordninge");
            _textMatchService = textMatchService;
        }

        public LineStats GetStats(string searchText)
        {
            var line = _lineSource.GetNextLine();
            while (line != null)
            {
                _textMatchService.GatherMatchStats(line, searchText);
                line = _lineSource.GetNextLine();
            }
            
            return new LineStats(_textMatchService.MatchingLineCount, _textMatchService.TotalLineCount, searchText);
        }
    }
}
