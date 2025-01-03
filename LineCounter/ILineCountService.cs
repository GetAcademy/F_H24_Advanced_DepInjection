namespace LineCounter;

public interface ILineCountService
{
    LineStats GetStats(string searchText);
}