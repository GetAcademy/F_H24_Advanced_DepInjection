namespace LineCounter.LineSources;

public class LineSourceFactory : ILineSourceFactory
{
    public ILineSource CreateFileLineSource(string filePath)
    {
        return new FileLineSource(filePath);
    }

    public ILineSource CreateKeyboardLineSource()
    {
        return new KeyboardLineSource();
    }

    public ILineSource CreateWebLineSource(string url)
    {
        return new WebLineSource(url);
    }
}