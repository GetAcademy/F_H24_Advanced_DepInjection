namespace Chat.Server
{
    public class ChatServer
    {
        readonly List<IChatClient> _clients;

        public ChatServer()
        {
            _clients = new List<IChatClient>();
        }

        public void Broadcast(IChatClient client, string message)
        {
            foreach (var chatClient in _clients)
            {
                if (chatClient != client)
                {
                    chatClient.Receive(message);
                }
            }
        }

        public void Register(IChatClient chatClient)
        {
            _clients.Add(chatClient);
        }
    }
}
