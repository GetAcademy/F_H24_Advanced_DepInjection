namespace Chat.Server
{
    public interface IChatClient
    {
        void Receive(string message);
    }
}
