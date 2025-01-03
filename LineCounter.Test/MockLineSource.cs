using LineCounter.LineSources;

namespace LineCounter.Test
{
    internal class MockLineSource : ILineSource
    {
        private int _index;

        public string GetNextLine()
        {
            _index++;
            if (_index == 1) return "Det er en fin dag";
            if (_index == 2) return "Det var en fin dag";
            if (_index == 3) return "Det vil bli en fin dag";
            return null;
        }
    }
}
