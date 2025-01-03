using Chat;
using Chat.Client;
using Chat.Server;

var server = new ChatServer();

var per = new ChatClient("Per", server);
var pål = new ChatClient("Pål", server);
var espen = new ChatClient("Espen", server);

per.Say("Hello");
// Pål og Espen får beskjed "Per sier Hello"

pål.Say("Hello");
// Per og Espen får beskjed "Pål sier Hello"

espen.Say("Hello");
// Per og Pål får beskjed "Espen sier Hello"