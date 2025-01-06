using LineCounter.LineSources;

namespace LineCounter.Test;

public class MockLineSourceFactory : ILineSourceFactory
{
    public ILineSource CreateFileLineSource(string filePath)
    {
        throw new NotImplementedException();
    }

    public ILineSource CreateKeyboardLineSource()
    {
        throw new NotImplementedException();
    }

    public ILineSource CreateWebLineSource(string url)
    {
        return new MockLineSource();
    }
}