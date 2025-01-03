namespace LineCounter.LineSources;

public interface ILineSourceFactory
{
    ILineSource CreateFileLineSource(string filePath);
    ILineSource CreateKeyboardLineSource();
    ILineSource CreateWebLineSource(string url);
}