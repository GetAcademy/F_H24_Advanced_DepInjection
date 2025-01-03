namespace LineCounter.LineSources
{
    internal class KeyboardLineSource : ILineSource
    {
        public string GetNextLine()
        {
            Console.Write("Skriv tekst: ");
            var text = Console.ReadLine();
            return text == "" ? null : text;
        }
    }
}
